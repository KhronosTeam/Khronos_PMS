using BrightIdeasSoftware;
using Khronos_PMS.Model;
using Khronos_PMS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khronos_PMS.View {
    public partial class UnitForm2 : Form {
        private Project selectedProject;
        private Unit selectedUnit;
        private Unit editUnit;
        private Boolean edit = false;
        /*-----------------------------------------------------------------------------------------*/

        public UnitForm2() {
            InitializeComponent();
        }

        /// <summary>
        /// POZIVA SE NA EDIT
        /// </summary>
        /// <param name="editUnit"></param>
        /// <param name="selectedProject"></param>
        public UnitForm2(Unit editUnit, Project selectedProject) {
            InitializeComponent();
            this.editUnit = editUnit;
            this.selectedProject = selectedProject;
            edit = true;
            onStart();
        }

        /// <summary>
        /// poziva se na dodavanje novog unita, tekst se upiše u name tetbox za ime unita, a automatski se selektuje
        /// nadam se i father unit
        /// </summary>
        /// <param name="selectedProject"></param>
        /// <param name="name"></param>
        /// <param name="selectedUnit"></param>
        public UnitForm2(Project selectedProject, string name, Unit selectedUnit) {
            InitializeComponent();
            this.selectedProject = selectedProject;
            this.selectedUnit = selectedUnit;
            onStart();
            unitNameTextBox.Text = name;
        }

        private void setUp() {
            unitsTreeView.CanExpandGetter = un => (un as Unit).HasChildren;
            unitsTreeView.ChildrenGetter = un => (un as Unit).Children;

            int statusOffset = 7;

            unitsTreeView.GetColumn(0).ImageGetter = un => (un as Unit).Status + 2;
            unitsTreeView.GetColumn(1).ImageGetter = un => (un as Unit).Status + statusOffset;
            unitsTreeView.GetColumn(1).AspectToStringConverter = s => StatusManager.Name(StatusManager.getStausById((int) s));

            priorityComboBox.DataSource = PriorityManager.GetPriorities();

            workersListView.GetColumn(0).ImageGetter = i => 1;
            List<Worker> workers = ProjectManager.GetWorkers(selectedProject);
            workersListView.SetObjects(workers);

            List<Unit> u = ProjectManager.GetRootUnits(selectedProject);
            unitsTreeView.Roots = u;
            unitsTreeView.ExpandAll();
        }

        private void onStart() {
            setUp();
            if (edit) {
                fillFields();
                foreach (WorksOn worksOn in editUnit.Workers.Where(wo => wo.Active).ToList()) {
                    workersListView.CheckObject(worksOn.AssignedTo.Worker);
                }
                if (!editUnit.IsRoot) {
                    selectedUnit = editUnit.Ancestor;
                    unitsTreeView.CheckObject(selectedUnit);
                }
            } else {
                workersListView.UncheckAll();
                if (selectedUnit != null) {
                    unitsTreeView.CheckObject(selectedUnit);
                }
            }
        }

        private void fillFields() {
            unitNameTextBox.Text = editUnit.Name;
            dueDateDateTimePicker.Value = editUnit.DueDate;
            estimatedManhoursTextBox.Text = editUnit.EstManhours.ToString();
            priorityComboBox.SelectedIndex = 0;
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
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e) {
            Unit unit;
            string toLog = "";

            if (edit) {
                unit = editUnit;
                toLog = editUnit.Name + "#" + editUnit.EstManhours + "#";
            } else {
                unit = new Unit();
            }

            setAttributes(unit);
            setAncestorID(unit);
            setWorkers(unit);

            if (edit) {
                LogManager.writeToLog(ProjectManager.entities, "Unit", "insert", toLog, LoginManager.LoggedUser.ID);
                ProjectManager.entities.Units.Attach(unit);
                ProjectManager.entities.Entry(unit).State = System.Data.Entity.EntityState.Modified;
            } else {
                ProjectManager.entities.Units.Add(unit);
                LogManager.writeToLog(ProjectManager.entities, "Unit", "insert", unit.ID.ToString(), LoginManager.LoggedUser.ID);
            }

            try {
                ProjectManager.entities.SaveChangesAsync();
            } catch (Exception) {
                ProjectManager.entities.Entry(unit).State = System.Data.Entity.EntityState.Detached;
            }

            DialogResult = DialogResult.OK;
        }

        public void setWorkers(Unit unit) {
            var list = workersListView.CheckedObjects;
            var enumerator = list.GetEnumerator();
            WorksOn[] niz = ProjectManager.entities.WorksOns.Where(wo => wo.Active && wo.UnitID == unit.ID && wo.ProjectID == selectedProject.ID).ToArray();

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
            unit.Status = 0;
            unit.SpentManhours = 0;
            unit.Expense = 0;
            unit.Active = true;
        }

        private void setAncestorID(Unit unit) {
            Unit selectedUnit = (Unit) unitsTreeView.CheckedObject;
            if (selectedUnit != null && selectedUnit.ID != unit.ID)
                unit.Ancestor = selectedUnit;
        }

        private void unitsTreeView_ItemCheck(object sender, ItemCheckEventArgs e) {
            if (e.NewValue == CheckState.Checked)
                if (unitsTreeView.CheckedObjects.Count == 1) {
                    unitsTreeView.CheckedObjects = null;
                }
        }
    }
}