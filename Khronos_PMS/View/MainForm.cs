using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khronos_PMS.Model;
using Khronos_PMS.Util;
using BrightIdeasSoftware;

namespace Khronos_PMS.View
{
    public partial class MainForm : Form
    {
        private User user;

        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void MainForm_Load(Object sender, EventArgs e)
        {
            //todo Num 0. u zavisnoti ko se prijavio (worker, customer, superviosor) neke opcije trebaju biti prikazane, a neke ne

            //učitati projekte, popuniti listview i po defaultu neka prvi bude selektovan
            this.Invoke(new MethodInvoker(() => { projectsListView.DataSource = ProjectManager.GetProjects(user); }));

            //todo Num 3. učitati radnike i popuniti listview

            //todo Num 4. učitati unite za selektovani projekat i popuniti treeview

            //postaviti userLabel text za logovanog usera
            if (user != null)
            {
                userLabel.Text = user.Username;
            }
        }

        private void button1_Click(Object sender, EventArgs e)
        {
            rightTableLayout.ColumnStyles[1].Width = 0;
        }

        private void projectsSearchButton_Click(Object sender, EventArgs e)
        {
            searchProjects();
            //Nema potrebe za ovim, sad pretrazuje odma na kucanje
        }

        private void workersSearchButton_Click(Object sender, EventArgs e)
        {
            searchWorkers();
        }

        private void unitsSearchButton_Click(Object sender, EventArgs e)
        {
            //todo Num 8. implementirati pretragu unita, prikazati obavještenja
        }

        private void projectToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Status status = (Status)((ToolStripItem)sender).Tag;
            projectStatusMenuButton.Image = StatusManager.Image(status);

            new Task(() =>
            {
                //project status update
                Invoke(new MethodInvoker(() =>
                {
                    if (projectsListView.SelectedIndex != -1)
                    {
                        Project selectedProject = (Project)projectsListView.SelectedObject;
                        StatusManager.UpdateStatus(selectedProject, status);
                    }
                }));
            }).Start();
        }

        private void unitStatusToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Status status = (Status)((ToolStripItem)sender).Tag;
            unitStatusMenuButton.Image = StatusManager.Image(status);

            new Task(() =>
            {
                //todo Num 10. unit status update
                //StatusManager.UpdateStatus(selected unit, status);
            }).Start();
        }

        private void unitPriorityToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Priority priority = (Priority)((ToolStripItem)sender).Tag;
            unitPriorityMenuButton.Image = PriorityManager.Image(priority);

            new Task(() =>
            {
                //todo Num 11. unit priority update
                //PriorityManager.UpdatePriority(selected unit, priority);
            }).Start();
        }

        private void projectsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //inicijalizovati sva polja vezana za projekat (Project name, role, boss, description, dates, ...) 
            if (projectsListView.SelectedIndex != -1)
            {
                Project selectedProject = (Project)projectsListView.SelectedObject;
                projectNameLabel.Text = selectedProject.Name;
                projectDescriptionLabel.Text = selectedProject.Description;
                startDateLabel.Text = selectedProject.StartDate.ToShortDateString();
                endDateLabel.Text = selectedProject.DeadlineDate.ToShortDateString();
                budgetLabel.Text = selectedProject.Budget.ToString() + " KM";
                expenseLabel.Text = selectedProject.Expense.ToString() + " KM";
                bossNameLabel.Text = selectedProject.Boss.FirstName + " " + selectedProject.Boss.LastName;
                projectStatusMenuButton.Image = StatusManager.Image(StatusManager.getStausById(selectedProject.Status));
                setRole(selectedProject);
            }
        }

        private void projectsSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            searchProjects();
        }

        private void searchProjects()
        {
            //Ovdje je implementirana pretraga
            projectsListView.UseFiltering = true;
            projectsListView.ModelFilter = new ModelFilter(x =>
            {
                var myProject = x as Project;
                return x != null && (myProject.Name.ToLower().Contains(projectsSearchTextbox.Text.ToLower()));
            });
        }

        private void searchWorkers()
        {
            Project selectedProject = (Project)projectsListView.SelectedObject;
            List<Worker> mylist = ProjectManager.GetWorkers(selectedProject);
            List<Worker> temp = new List<Worker>();
            if (workersSearchTextBox.Text.Equals(""))
            {
                workersListView.DataSource = mylist;
            }
            else
            {
                foreach (var x in mylist)
                {
                    if (x.FirstName.ToLower().Contains(workersSearchTextBox.Text.ToLower()))
                    {

                        temp.Add(x);
                    }
                }
                workersListView.DataSource = temp;
            }

        }

        private void setRole(Project selectedProject)
        {
            if (user != null)
            {
                if (selectedProject.BossID == user.ID)
                {
                    projectRoleLabel.Text = Role.Boss.ToString();
                }
                else if (selectedProject.SupervisorID == user.ID)
                {
                    projectRoleLabel.Text = Role.Supervisor.ToString();
                }
                else
                {
                    bool roleSet = false;
                    foreach (var item in selectedProject.Customers)
                    {
                        if (item.ID == user.ID)
                        {
                            projectRoleLabel.Text = Role.Customer.ToString();
                            roleSet = true;
                        }
                    }
                    foreach (var item in selectedProject.AssignedWorkers)
                    {
                        if (item.WorkerID == user.ID)
                        {
                            projectRoleLabel.Text = Role.Worker.ToString();
                            roleSet = true;
                        }
                    }
                    if (roleSet != true)
                    {
                        projectRoleLabel.Text = "Unknown";
                    }
                }
            }
            else
            {
                projectRoleLabel.Text = "Unknown";
            }
        }

        private void workersSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            searchWorkers();
        }
    }
}