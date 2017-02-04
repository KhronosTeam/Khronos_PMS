using Khronos_PMS.Model;
using Khronos_PMS.ModelView;
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

namespace Khronos_PMS.View
{
    public partial class ProjectForm : Form
    {
        ProjectView projectView;
        Project project;
        List<CustomerView> projectCustomers = new List<CustomerView>();
        BindingSource bs;
        private bool edit=false;
        public ProjectForm()
        {
            InitializeComponent();
            this.Name = "New Project";
        }
        public ProjectForm(ProjectView ProjectView)
        {
            InitializeComponent();
            edit = true;
            this.projectView = ProjectView;
            this.Name = "Edit Project";
        }

        private async void setupComponents() {
            List<WorkerView> workerList = null;
            List<WorkerView> workerList2 = null;
            List<CustomerView> customerList = null;
            this.Enabled = false;
            await Task.Run(() => {
                workerList = ProjectManagement.GetWorkers();
                workerList2 = ProjectManagement.GetWorkers();
                customerList = ProjectManagement.GetCustomers();
            });

            bossUsernameComboBox.DataSource = workerList;
            bossUsernameComboBox.DisplayMember = "Username";
            bossUsernameComboBox.ValueMember = "ID";

            supervisorUsernameComboBox.DataSource = workerList2;
            supervisorUsernameComboBox.DisplayMember = "Username";
            supervisorUsernameComboBox.ValueMember = "ID";

            customerComboBox.DataSource = customerList;
            customerComboBox.DisplayMember = "Username";
            customerComboBox.ValueMember = "ID";

            if (edit)
            {
                project = ProjectManagement.entities.Projects.Where(p => p.ID == projectView.ID).First();

                fill();
            }
            else
            {
                bs = new BindingSource();
                bs.DataSource = projectCustomers;
                customerDataGridView.DataSource = bs;
                customerDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                customerDataGridView.Columns[2].Visible = false;
            }
            this.Enabled = true;
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            setupComponents();
        }

        private  void fill() {
            foreach (Customer customer in project.Customers)
            {
                projectCustomers.Add(new CustomerView(customer.ID, customer.User.Username, customer.Name));
            }
            bs = new BindingSource();
            bs.DataSource = projectCustomers;
            customerDataGridView.DataSource = bs;
            descriptionTextBox.Text = project.Description;
            projectNameTextBox.Text = projectView.Name;
            startDateDateTimePicker.Value = projectView.StartDate;
            deadlineDateTimePicker.Value = projectView.DeadlineDate;
            budgetTextBox.Text = projectView.Budget.ToString();
            descriptionTextBox.Text = project.Description;
            //bossUsernameComboBox.SelectedIndex = bossUsernameComboBox.Items.IndexOf(new WorkerView(projectView.Boss.ID, ""));
            bossUsernameComboBox.SelectedIndex = bossUsernameComboBox.FindString(project.Boss.User.Username);
            supervisorUsernameComboBox.SelectedIndex = supervisorUsernameComboBox.FindString(project.Supervisor.User.Username);

            //supervisorUsernameComboBox.SelectedIndex = supervisorUsernameComboBox.Items.IndexOf(new WorkerView(projectView.Supervisor.ID, ""));
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (!projectCustomers.Contains((CustomerView)customerComboBox.SelectedItem)) {
                projectCustomers.Add((CustomerView)customerComboBox.SelectedItem);
                bs.ResetBindings(false);
            }
            
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerView customer = null;
            customer =(CustomerView) customerDataGridView.SelectedRows[0].DataBoundItem;
            if (customer != null) {
                projectCustomers.Remove(customer);
                bs.ResetBindings(false);
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (edit) {
                try
                {
                    string logParams =project.ID.ToString() + "#" +
                        project.Name + "#"
                        + project.BossID.ToString() + "#" +
                        project.SupervisorID.ToString() + "#" +
                        project.StartDate.ToString() + "#" +
                        project.DeadlineDate.ToString() + "#" +
                        project.Budget.ToString() + "#" +
                        project.Description.ToString();
                    project.Name = projectNameTextBox.Text;
                project.BossID = ((WorkerView)bossUsernameComboBox.SelectedItem).ID;
                project.SupervisorID = ((WorkerView)supervisorUsernameComboBox.SelectedItem).ID;
                project.StartDate = startDateDateTimePicker.Value.Date;
                project.DeadlineDate = deadlineDateTimePicker.Value.Date;
                    try
                    {
                        project.Budget = decimal.Parse(budgetTextBox.Text);
                    }
                    catch (Exception) {
                        project.Budget = 0;
                    }
                    project.Description = descriptionTextBox.Text;

                    project.Customers = new List<Customer>();
                    string customerLog = "";
                foreach (CustomerView customer in projectCustomers)
                {
                    Customer cc = ProjectManagement.entities.Customers.Where(c => c.ID == customer.ID).First();
                    project.Customers.Add(cc);
                        customerLog += "newCustomerID:" + customer.ID + "#";
                }
                   ProjectManagement.entities.Projects.Attach(project);
                ProjectManagement.entities.Entry(project).State = System.Data.Entity.EntityState.Modified;

                ProjectManagement.entities.SaveChanges();

                    LogManager.writeToLog(ProjectManagement.entities, "Project", "update", logParams, LoginManager.LoggedUser.ID);
                    LogManager.writeToLog(ProjectManagement.entities, "CustomerProject", "insert", customerLog, LoginManager.LoggedUser.ID);

                    this.Close();
                }
                catch (Exception) { }
            }
            else {
                try
                {
                    Project newProject = new Project();
                    newProject.Name = projectNameTextBox.Text;
                    newProject.BossID = ((WorkerView)bossUsernameComboBox.SelectedItem).ID;
                    newProject.SupervisorID = ((WorkerView)supervisorUsernameComboBox.SelectedItem).ID;
                    newProject.StartDate = startDateDateTimePicker.Value.Date;
                    newProject.DeadlineDate = deadlineDateTimePicker.Value.Date;
                    try
                    {
                        newProject.Budget = decimal.Parse(budgetTextBox.Text);
                    }
                    catch (Exception)
                    {
                        newProject.Budget = 0;
                    }
                    newProject.Description = descriptionTextBox.Text;

                    string customerLog = "";
                    foreach (CustomerView customer in projectCustomers) {
                        Customer cc = ProjectManagement.entities.Customers.Where(c => c.ID == customer.ID).First();
                        newProject.Customers.Add(cc);
                        customerLog += "newCustomerID:" + customer.ID + "#";
                    }

                    ProjectManagement.entities.Projects.Add(newProject);
                    
                    ProjectManagement.entities.SaveChanges();
                    LogManager.writeToLog(ProjectManagement.entities, "Project", "insert", newProject.ID.ToString(), LoginManager.LoggedUser.ID);
                    LogManager.writeToLog(ProjectManagement.entities, "CustomerProject", "insert", customerLog, LoginManager.LoggedUser.ID);

                    this.Close();

                }
                catch (Exception) { }
            }
        }
    }
}
