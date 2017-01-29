using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;
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
        }

        private void MainForm_Load(Object sender, EventArgs e) {
            //todo Num 0. u zavisnoti ko se prijavio (worker, customer, superviosor) neke opcije trebaju biti prikazane, a neke ne
            projectsListView.GetColumn(0).ImageGetter = i => 0;
            workersListView.GetColumn(0).ImageGetter = i => 1;

            new Thread(() => {
                List<Project> projects = ProjectManager.GetProjects(user);
                Invoke(new MethodInvoker(() => {
                    projectsListView.DataSource = projects;
                    projectsListView.SelectedIndex = 0;
                    workersListView.DataSource = ProjectManager.GetWorkers(projects[0]);
                }));
            }).Start();


            //todo Num 4. učitati unite za selektovani projekat i popuniti treeview

            //postaviti userLabel text za logovanog usera
            if (user != null) {
                userLabel.Text = user.Username;
            }
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
                //project status update
                Invoke(new MethodInvoker(() => {
                    if (projectsListView.SelectedIndex != -1) {
                        Project selectedProject = (Project) projectsListView.SelectedObject;
                        StatusManager.UpdateStatus(selectedProject, status);
                    }
                }));
            }).Start();
        }

        private void unitStatusToolStripMenuItem_Click(Object sender, EventArgs e) {
            Status status = (Status) ((ToolStripItem) sender).Tag;
            unitStatusMenuButton.Image = StatusManager.Image(status);

            new Task(() => {
                //todo Num 10. unit status update
                //StatusManager.UpdateStatus(selected unit, status);
            }).Start();
        }

        private void unitPriorityToolStripMenuItem_Click(Object sender, EventArgs e) {
            Priority priority = (Priority) ((ToolStripItem) sender).Tag;
            unitPriorityMenuButton.Image = PriorityManager.Image(priority);

            new Task(() => {
                //todo Num 11. unit priority update
                //PriorityManager.UpdatePriority(selected unit, priority);
            }).Start();
        }

        private void projectsListView_SelectedIndexChanged(object sender, EventArgs e) {
            //inicijalizovati sva polja vezana za projekat (Project name, role, boss, description, dates, ...) 
            if (projectsListView.SelectedIndex != -1) {
                Project selectedProject = (Project) projectsListView.SelectedObject;
                projectNameLabel.Text = selectedProject.Name;
                projectDescriptionLabel.Text = selectedProject.Description;
                startDateLabel.Text = selectedProject.StartDate.ToShortDateString();
                endDateLabel.Text = selectedProject.DeadlineDate.ToShortDateString();
                budgetLabel.Text = selectedProject.Budget + " KM";
                expenseLabel.Text = selectedProject.Expense + " KM";
                bossNameLabel.Text = selectedProject.Boss.FullName;
                projectStatusMenuButton.Image = StatusManager.Image(StatusManager.getStausById(selectedProject.Status));
                setRole(selectedProject);

                // možda treba u background
                workersListView.DataSource = ProjectManager.GetWorkers(selectedProject);
                /*
                // postavka unita
                // TODO pozvati u thread pa invoke
                //unitsTreeView.Nodes.Add(UnitView.getRootUnits(selectedProject.ID));
                unitsTreeView.Nodes.Clear();
                List<UnitView> units = UnitView.getRootUnits(selectedProject.ID);
                foreach (UnitView unitView in units) {
                    TreeNode rootNode = new TreeNode(unitView.Name);
                    rootNode.Tag = unitView;
                    unitsTreeView.Nodes.Add(rootNode);
                }
                */
            }
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

        private void unitsTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            TreeNode selectedNode = e.Node;
            List<UnitView> units = ((UnitView) selectedNode.Tag).getChildren();
            if (selectedNode.Nodes.Count == 0)
                foreach (UnitView unitView in units) {
                    TreeNode childNode = new TreeNode(unitView.Name);
                    childNode.Tag = unitView;
                    selectedNode.Nodes.Add(childNode);
                }
            selectedNode.Expand();
        }

        private void workersSearchTextBox_TextChanged(object sender, EventArgs e) {
            searchWorkers();
        }

        private void ShowWorkers(List<Worker> workers) {
            foreach (Worker worker in workers)
                workersListView.Items.Add(new ListViewItem(worker.FirstName + " " + worker.LastName, 0));
        }

        private void ShowUnitAssignees(Unit unit) {
            List<Worker> workers = UnitManager.GetAssigness(unit);
            assigneesListView.Items.Clear();
            foreach (Worker worker in workers)
                assigneesListView.Items.Add(new ListViewItem(worker.FirstName + " " + worker.LastName, 0));
        }
    }
}