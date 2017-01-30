using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Khronos_PMS.Model;
using Khronos_PMS.Util;
using BrightIdeasSoftware;
using Khronos_PMS.ModelView;

namespace Khronos_PMS.View {
    public partial class MainForm : Form {
        private User user;

        public MainForm(User user) {
            InitializeComponent();
            this.user = user;

            if (user != null)
                userLabel.Text = user.GetName();

            // pošto u LoginForm imamo progress bar ovdje ćemo učitati sve što treba iz baze
            // pa kada se forma pokrene sve bude učitano
            projectsListView.GetColumn(0).ImageGetter = i => 0;

            List<Project> projects = ProjectManager.GetProjects(user);
            projectsListView.DataSource = projects;
            unitsTreeView.CanExpandGetter = u => (u as Unit).HasChildren;
            unitsTreeView.ChildrenGetter = u => (u as Unit).Children;

            int statusOffset = 7, priorityOffset = 11;

            workersListView.GetColumn(0).ImageGetter = i => 1;
            unitsTreeView.GetColumn(0).ImageGetter = u => (u as Unit).Status + 2;
            unitsTreeView.GetColumn(1).ImageGetter = u => (u as Unit).Status + statusOffset;
            unitsTreeView.GetColumn(1).AspectToStringConverter = s => StatusManager.Name(StatusManager.getStausById((int) s));
            unitsTreeView.GetColumn(2).ImageGetter = u => (u as Unit).Priority + priorityOffset;
            unitsTreeView.GetColumn(2).AspectToStringConverter = s => PriorityManager.Name(PriorityManager.GetPriorityById((int) s));
            unitsTreeView.GetColumn(3).ImageGetter = u => 6;
            unitsTreeView.GetColumn(3).AspectToStringConverter = d => ((DateTime) d).ToShortDateString();
        }

        private void MainForm_Load(Object sender, EventArgs e) {
            //todo neke labele treba sakriti u zavisnoti ko se prijavio
        }

        private void button1_Click(Object sender, EventArgs e) {
            rightTableLayout.ColumnStyles[1].Width = 0;
        }

        private void projectsSearchButton_Click(Object sender, EventArgs e) {
            searchProjects();
        }

        private void workersSearchButton_Click(Object sender, EventArgs e) {
            searchWorkers();
        }

        private void unitsSearchButton_Click(Object sender, EventArgs e) {
            //todo Num 8. implementirati pretragu unita, prikazati obavještenja
        }

        private void projectToolStripMenuItem_Click(Object sender, EventArgs e) {
            Status status = (Status) ((ToolStripItem) sender).Tag;
            projectStatusMenuButton.Image = StatusManager.Image(status);

            new Task(() => {
                if (projectsListView.SelectedIndex != -1) {
                    Project selectedProject = (Project) projectsListView.SelectedObject;
                    StatusManager.UpdateStatus(selectedProject, status);
                }
            }).Start();
        }

        private void unitStatusToolStripMenuItem_Click(Object sender, EventArgs e) {
            Status status = (Status) ((ToolStripItem) sender).Tag;
            unitStatusMenuButton.Image = StatusManager.Image(status);

            new Task(() => {
                Unit selectedUnit = (Unit) unitsTreeView.SelectedObject;
                StatusManager.UpdateStatus(selectedUnit, status);
            }).Start();
        }

        private void unitPriorityToolStripMenuItem_Click(Object sender, EventArgs e) {
            Priority priority = (Priority) ((ToolStripItem) sender).Tag;
            unitPriorityMenuButton.Image = PriorityManager.Image(priority);

            new Task(() => {
                Unit selectedUnit = (Unit) unitsTreeView.SelectedObject;
                PriorityManager.UpdatePriority(selectedUnit, priority);
            }).Start();
        }

        private void projectsListView_SelectionChanged(Object sender, EventArgs e) {
            Project selectedProject = (Project) projectsListView.SelectedObject;
            if (selectedProject == null) return;
            List<Worker> workers = ProjectManager.GetWorkers(selectedProject);
            workersListView.DataSource = workers;
            projectNameLabel.Text = selectedProject.Name;
            projectDescriptionLabel.Text = selectedProject.Description;
            startDateLabel.Text = selectedProject.StartDate.ToShortDateString();
            endDateLabel.Text = selectedProject.DeadlineDate.ToShortDateString();
            budgetLabel.Text = selectedProject.Budget + " KM";
            expenseLabel.Text = selectedProject.Expense + " KM";
            bossNameLabel.Text = selectedProject.Boss.FullName;
            projectStatusMenuButton.Image = StatusManager.Image(StatusManager.getStausById(selectedProject.Status));
            setRole(selectedProject);
            
            List<Unit> u = ProjectManager.GetRootUnits(selectedProject);
            unitsTreeView.Roots = u;
        }

        private void projectsSearchTextbox_TextChanged(object sender, EventArgs e) {
            searchProjects();
        }

        private void searchProjects() {
            projectsListView.UseFiltering = true;
            projectsListView.ModelFilter = new ModelFilter(x => {
                var myProject = x as Project;
                return x != null && (myProject.Name.ToLower().Contains(projectsSearchTextbox.Text.ToLower()));
            });
        }

        private void searchWorkers() {
            workersListView.UseFiltering = true;
            workersListView.ModelFilter = new ModelFilter(x => {
                var worker = x as Worker;
                return x != null && (worker.FirstName.ToLower().Contains(workersSearchTextBox.Text.ToLower()));
            });
        }

        private void setRole(Project selectedProject) {
            if (user != null) {
                if (selectedProject.BossID == user.ID) {
                    projectRoleLabel.Text = Role.Boss.ToString();
                } else if (selectedProject.SupervisorID == user.ID) {
                    projectRoleLabel.Text = Role.Supervisor.ToString();
                } else {
                    bool roleSet = false;
                    foreach (var item in selectedProject.Customers) {
                        if (item.ID == user.ID) {
                            projectRoleLabel.Text = Role.Customer.ToString();
                            roleSet = true;
                        }
                    }
                    foreach (var item in selectedProject.AssignedWorkers) {
                        if (item.WorkerID == user.ID) {
                            projectRoleLabel.Text = Role.Worker.ToString();
                            roleSet = true;
                        }
                    }
                    if (roleSet != true) {
                        projectRoleLabel.Text = "Unknown";
                    }
                }
            } else {
                projectRoleLabel.Text = "Unknown";
            }
        }

        private void workersSearchTextBox_TextChanged(object sender, EventArgs e) {
            searchWorkers();
        }

        private void unitsTreeView_SelectionChanged(Object sender, EventArgs e) {
            Unit unit = (Unit) unitsTreeView.SelectedObject;
            if (unit == null) return;
        }
    }
}