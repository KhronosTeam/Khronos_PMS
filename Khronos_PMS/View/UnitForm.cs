using BrightIdeasSoftware;
using Khronos_PMS.Model;
using Khronos_PMS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khronos_PMS.View {
    public partial class UnitForm : Form {
        private Project selectedProject;
        private Unit selectedUnit;
        private Unit editUnit;
        private Unit rootUnit;
        private Boolean edit = false;

        public UnitForm() {
            InitializeComponent();
        }

        /// <summary>
        /// POZIVA SE NA EDIT
        /// </summary>
        /// <param name="editUnit"></param>
        /// <param name="selectedProject"></param>
        public UnitForm(Unit editUnit, Project selectedProject) {
            InitializeComponent();
            this.editUnit = editUnit;
            this.selectedProject = selectedProject;
            edit = true;
            onStart();
        }

        public UnitForm(Project selectedProject) {
            InitializeComponent();
            this.selectedProject = selectedProject;
            onStart();
        }

        /// <summary>
        /// poziva se na dodavanje novog unita, tekst se upiše u name tetbox za ime unita, a automatski se selektuje
        /// nadam se i father unit
        /// </summary>
        /// <param name="selectedProject"></param>
        /// <param name="name"></param>
        /// <param name="selectedUnit"></param>
        public UnitForm(Project selectedProject, string name, Unit selectedUnit) {
            InitializeComponent();
            this.selectedProject = selectedProject;
            this.selectedUnit = selectedUnit;
            onStart();
            unitNameTextBox.Text = name;
        }

        private void onStart() {
            unitsTreeView.CanExpandGetter = u => (u as Unit).HasChildren;
            unitsTreeView.ChildrenGetter = u => (u as Unit).Children;

            int statusOffset = 7;

            unitsTreeView.GetColumn(0).ImageGetter = u => (u as Unit).Status + 2;
            unitsTreeView.GetColumn(1).ImageGetter = u => (u as Unit).Status + statusOffset;
            unitsTreeView.GetColumn(1).AspectToStringConverter = s => StatusManager.Name(StatusManager.getStausById((int) s));

            priorityComboBox.DataSource = PriorityManager.GetPriorities();

            workersListView.GetColumn(0).ImageGetter = i => 1;
            List<Worker> workers = ProjectManager.GetWorkers(selectedProject);
            workersListView.SetObjects(workers);

            if (edit) {
                foreach (WorksOn worksOn in editUnit.Workers.Where(wo => wo.Active).ToList()) {
                    workersListView.CheckedObjects.Add(worksOn.AssignedTo.Worker);
                    workersListView.CheckObject(worksOn.AssignedTo.Worker);
                }
                if (editUnit.ClosureUnits.ToArray()[0].Depth != 0) {
                    int ancestorId = editUnit.ClosureUnits.ToArray()[0].AncestorID;
                    selectedUnit = ProjectManager.entities.Units.First(u => u.ID == ancestorId);
                    unitsTreeView.CheckedObjects.Add(selectedUnit);
                }
                fillFields();
            } else {
                workersListView.UncheckAll();
            }

            if (selectedUnit != null) {
                unitsTreeView.CheckedObjects.Add(selectedUnit);
                unitsTreeView.CheckObject(selectedUnit);
            }
        }

        private void fillFields() {
            unitNameTextBox.Text = editUnit.Name;
            dueDateDateTimePicker.Value = editUnit.DueDate;
            estimatedManhoursTextBox.Text = editUnit.EstManhours.ToString();
            priorityComboBox.SelectedIndex = editUnit.Priority;
        }

        private void searchUnits() {
            unitsTreeView.UseFiltering = true;
            unitsTreeView.ModelFilter = new ModelFilter(x => {
                var unit = x as Unit;
                return (x as Unit) != null && unit.Name.ToLower().Contains(unitsSearchTextBox.Text.ToLower());
            });
        }

        private void unitsSearchTextBox_TextChanged(object sender, EventArgs e) {
            searchUnits();
        }

        private void unitsSearchButton_Click(object sender, EventArgs e) {
            searchUnits();
        }

        private void searchWorkers() {
            workersListView.UseFiltering = true;
            workersListView.ModelFilter = new ModelFilter(x => {
                var worker = x as Worker;
                return x != null && (worker.FirstName.ToLower().Contains(workersSearchTextBox.Text.ToLower()));
            });
        }

        private void workersSearchTextBox_TextChanged(object sender, EventArgs e) {
            searchWorkers();
        }

        private void button1_Click(object sender, EventArgs e) {
            searchWorkers();
        }

        private void UnitForm_Load(object sender, EventArgs e) {
            List<Unit> u = ProjectManager.GetRootUnits(selectedProject);
            unitsTreeView.Roots = u;
            unitsTreeView.ExpandAll();
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e) {
            if (edit) {
                setAttributes(editUnit);

                setAncestorID(editUnit);
                setWorkers(editUnit);
            } else {
                Unit newUnit = new Unit();
                setAttributes(newUnit);
                ProjectManager.entities.Units.Add(newUnit);
                setAncestorID(newUnit);
                setWorkers(newUnit);
                if(unitsTreeView.SelectedIndex == -1)
                {
                    rootUnit = newUnit;
                }
                ProjectManager.entities.SaveChangesAsync();
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }
        public void setWorkers(Unit unit) {
            var list = workersListView.CheckedObjects;
            var enumerator = list.GetEnumerator();
            WorksOn[] niz = ProjectManager.entities.WorksOns.Where(wo => wo.Active == true && wo.UnitID == unit.ID && wo.ProjectID == selectedProject.ID).ToArray();

            foreach (WorksOn workson in niz) {
                workson.Active = false;
            }
            while (enumerator.MoveNext()) {
                Worker selectedWorker = (Worker) enumerator.Current;
                List<WorksOn> lista = ProjectManager.entities.WorksOns.Where(wo => wo.WorkerID == selectedWorker.ID && wo.UnitID == unit.ID && wo.ProjectID == selectedProject.ID).ToList();
                if (lista.Count == 0) {
                    // novi upis, postavi na aktivan
                    WorksOn newWorksOn = new WorksOn();
                    newWorksOn.ProjectID = selectedProject.ID;
                    newWorksOn.UnitID = unit.ID;
                    newWorksOn.WorkerID = selectedWorker.ID;
                    newWorksOn.Active = true;
                    ProjectManager.entities.WorksOns.Add(newWorksOn);
                } else {
                    WorksOn newWorksOn = lista.ToArray()[0];
                    newWorksOn.Active = true;
                    ProjectManager.entities.WorksOns.Attach(newWorksOn);
                    ProjectManager.entities.Entry(newWorksOn).State = System.Data.Entity.EntityState.Modified;
                }
            }
            ProjectManager.entities.SaveChangesAsync();
        }

        private void setAttributes(Unit unit) {
            unit.Name = unitNameTextBox.Text;
            try {
                unit.EstManhours = int.Parse(estimatedManhoursTextBox.Text);
            } catch (Exception) {
                unit.EstManhours = 0;
            }
            unit.DueDate = dueDateDateTimePicker.Value.Date;
            unit.Priority = priorityComboBox.SelectedIndex;
            unit.ProjectID = selectedProject.ID;
        }


        private void setAncestorID(Unit unit) {
            // unit se uvijek nalazi u closureunit ako nije novi
            ClosureUnit closureUnit;
            if (edit)
                closureUnit = ProjectManager.entities.ClosureUnits.First(cu => cu.ID == unit.ID);
            else {
                closureUnit = new ClosureUnit();
                closureUnit.ID = unit.ID;
            }
            ClosureUnit newclosureUnit = new ClosureUnit();

            // test
            if (edit) { 
            ProjectManager.entities.ClosureUnits.Attach(closureUnit);
            ProjectManager.entities.Entry(closureUnit).State = System.Data.Entity.EntityState.Deleted;
        }
            if (unitsTreeView.CheckedObjects.Count == 0) {
                // unit je root unit, jer nema selektovanih unita, postavi na root
                // a to znači depth 0 i ancestor id jednak njemu samom
                // uh, mijenjanje primarnih ključeva? :D
                //prepravka stabla ukoliko je unit imao djecu
                if (edit && unit.HasChildren)
                {
                    Unit[] children = unit.Children.ToArray();
                    foreach (Unit child in children)
                    {
                        ClosureUnit childClosureUnit = child.ClosureUnits.ToArray()[0];
                        ProjectManager.entities.ClosureUnits.Attach(childClosureUnit);
                        ProjectManager.entities.Entry(childClosureUnit).State = System.Data.Entity.EntityState.Deleted;
                        ClosureUnit newChild = new ClosureUnit();

                        if(closureUnit.ID ==closureUnit.AncestorID)
                        newChild.AncestorID = child.ID;
                        else
                            newChild.AncestorID = closureUnit.AncestorID;
                        newChild.ID = child.ID;
                        newChild.Depth = closureUnit.Depth;
                        ProjectManager.entities.ClosureUnits.Add(newChild);
                    }
                }

                newclosureUnit.ID = unit.ID;
                newclosureUnit.AncestorID = unit.ID;
                newclosureUnit.Depth = 0;
            } else {
                // postaviti ga kao sina selektovanog unita
                /*
                var list = unitsTreeView.CheckedObjects;
                var enumerator = list.GetEnumerator();
                enumerator.MoveNext();
                */
                if (edit && unit.HasChildren)
                {
                    Unit[] children = unit.Children.ToArray();
                    foreach (Unit child in children)
                    {

                        ClosureUnit childClosureUnit = child.ClosureUnits.ToArray()[0];
                        ProjectManager.entities.ClosureUnits.Attach(childClosureUnit);
                        ProjectManager.entities.Entry(childClosureUnit).State = System.Data.Entity.EntityState.Deleted;
                        ClosureUnit newChild = new ClosureUnit();
                        if (closureUnit.ID == closureUnit.AncestorID)
                            newChild.AncestorID = child.ID;
                        else
                            newChild.AncestorID = closureUnit.AncestorID;
                        newChild.ID = child.ID;
                        newChild.Depth = closureUnit.Depth;
                        ProjectManager.entities.ClosureUnits.Add(newChild);
                    }
                }
                selectedUnit = (Unit) unitsTreeView.CheckedObject;
                newclosureUnit.ID = unit.ID;
                newclosureUnit.AncestorID = selectedUnit.ID;
                // ne koristimo depth
                newclosureUnit.Depth =  1;
            }

            ProjectManager.entities.ClosureUnits.Add(newclosureUnit);
            ProjectManager.entities.SaveChangesAsync();
            /*
            if (edit) {
                ProjectManager.entities.ClosureUnits.Attach(closureUnit);
                ProjectManager.entities.Entry(closureUnit).State = System.Data.Entity.EntityState.Modified;
                ProjectManager.entities.SaveChangesAsync();
            } else {
                ProjectManager.entities.ClosureUnits.Add(closureUnit);
                ProjectManager.entities.SaveChangesAsync();
            }
            */
        }

        public Unit getRootUnit()
        {
            return rootUnit;
        }


        private void unitsTreeView_ItemCheck(object sender, ItemCheckEventArgs e) {
            if (e.NewValue == CheckState.Checked)
                if (unitsTreeView.CheckedObjects.Count == 1) {
                    unitsTreeView.CheckedObjects = null;
                }
        }
    }
}