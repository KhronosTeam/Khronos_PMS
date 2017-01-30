using BrightIdeasSoftware;
using Khronos_PMS.Model;
using Khronos_PMS.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khronos_PMS.View {
    public partial class UnitForm : Form {
        private Project selectedProject;
        private Unit selectedUnit;
        private Unit editUnit;
        private Boolean edit = false;
        public UnitForm() {
            InitializeComponent();
            //todo UnitForm je forma za kreiranje i editovanje unita
        }

        public UnitForm(Unit editUnit, Project selectedProject)
        {
            InitializeComponent();
            this.editUnit = editUnit;
            this.selectedProject = selectedProject;
            edit = true;
            onStart();
        }

        public UnitForm(Project selectedProject)
        {
            InitializeComponent();
            this.selectedProject = selectedProject;
            onStart();
        }

        private void onStart() {
            unitsTreeView.CanExpandGetter = u => (u as Unit).HasChildren;
            unitsTreeView.ChildrenGetter = u => (u as Unit).Children;

            int statusOffset = 7;
           
            unitsTreeView.GetColumn(0).ImageGetter = u => (u as Unit).Status + 2;
            unitsTreeView.GetColumn(1).ImageGetter = u => (u as Unit).Status + statusOffset;
            unitsTreeView.GetColumn(1).AspectToStringConverter = s => StatusManager.Name(StatusManager.getStausById((int)s));

            workersListView.GetColumn(0).ImageGetter = i => 1;
            List<Worker> workers = ProjectManager.GetWorkers(selectedProject);
            workersListView.DataSource = workers;

            priorityComboBox.DataSource = Enum.GetValues(typeof(Priority));
            if (edit) {
                foreach (WorksOn worksOn in selectedUnit.Workers)
                {
                    workersListView.CheckedObjects.Add(worksOn.AssignedTo.Worker);
                }
                if (editUnit.ClosureUnits.ToArray()[0].Depth != 0)
                {
                    selectedUnit = ProjectManager.entities.Units.First(u => u.ID == editUnit.ClosureUnits.ToArray()[0].AncestorID);
                    unitsTreeView.CheckedObjects.Add(selectedUnit);
                }
                fillFields();
            }
            else {
                workersListView.UncheckAll();
            }

        }

        private void fillFields() {
            unitNameTextBox.Text = editUnit.Name;
            dueDateDateTimePicker.Value = editUnit.DueDate;
            estimatedManhoursTextBox.Text = editUnit.EstManhours.ToString();
            priorityComboBox.SelectedIndex = editUnit.Priority;
        }
        private void searchUnits()
        {
            unitsTreeView.UseFiltering = true;
            unitsTreeView.ModelFilter = new ModelFilter(x => {
                var unit = x as Unit;
                return (x as Unit) != null && unit.Name.ToLower().Contains(unitsSearchTextBox.Text.ToLower());
            });
        }

        private void unitsSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchUnits();
        }

        private void unitsSearchButton_Click(object sender, EventArgs e)
        {
            searchUnits();
        }

        private void searchWorkers()
        {
            workersListView.UseFiltering = true;
            workersListView.ModelFilter = new ModelFilter(x => {
                var worker = x as Worker;
                return x != null && (worker.FirstName.ToLower().Contains(workersSearchTextBox.Text.ToLower()));
            });
        }
        private void workersSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchWorkers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchWorkers();
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            List<Unit> u = ProjectManager.GetRootUnits(selectedProject);
            unitsTreeView.Roots = u;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                setAttributes(selectedUnit);

                setAncestorID(selectedUnit);
            }
            else {
                Unit newUnit = new Unit();
                setAttributes(newUnit);
                ProjectManager.entities.Units.Add(newUnit);
                ProjectManager.entities.SaveChanges();
                setAncestorID(newUnit);

            }
        }

        private void setAttributes(Unit unit) {
            unit.Name = unitNameTextBox.Text;
            try
            {
                unit.EstManhours = int.Parse(estimatedManhoursTextBox.Text);
            }
            catch (Exception) {
                unit.EstManhours = 0;
            }
            unit.DueDate = dueDateDateTimePicker.Value.Date;
            unit.Priority = (int)priorityComboBox.SelectedValue;
            unit.ProjectID = selectedProject.ID;
        }

        private void setAncestorID(Unit unit) {
            // unit se uvijek nalazi u closureunit ako nije novi
            ClosureUnit closureUnit;
            if (edit) closureUnit = ProjectManager.entities.ClosureUnits.First(cu => cu.ID == unit.ID);
            else
            {
                closureUnit = new ClosureUnit();
                closureUnit.ID = unit.ID;
            }
            if (unitsTreeView.CheckedObjects.Count == 0)
            {
                // unit je root unit, jer nema selektovanih unita, postavi na root
                // a to znači depth 0 i ancestor id jednak njemu samom
                // uh, mijenjanje primarnih ključeva? :D
              
                closureUnit.AncestorID = unit.ID;
                closureUnit.Depth = 0;
            }
            else {
                // postaviti ga kao sina selektovanog unita
                var list = unitsTreeView.CheckedObjects;
                var enumerator = list.GetEnumerator();
                enumerator.MoveNext();
                selectedUnit = (Unit)enumerator.Current;
                closureUnit.AncestorID = selectedUnit.ID;
                closureUnit.Depth = selectedUnit.ClosureUnits.ToArray()[0].Depth+1;
            }

            if (edit)
            {
                ProjectManager.entities.ClosureUnits.Attach(closureUnit);
                ProjectManager.entities.Entry(closureUnit).State = System.Data.Entity.EntityState.Modified;
                ProjectManager.entities.SaveChanges();
            }
            else {
                ProjectManager.entities.ClosureUnits.Add(closureUnit);
                ProjectManager.entities.SaveChanges();
            }
        }

     

        private void unitsTreeView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue == CheckState.Checked)
            if (unitsTreeView.CheckedObjects.Count == 1) {
                unitsTreeView.CheckedObjects = null;

            }
                
        }
    }
}
