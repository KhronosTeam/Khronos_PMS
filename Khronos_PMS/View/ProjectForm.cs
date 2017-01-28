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

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            bossUsernameComboBox.DataSource = ProjectManagement.GetWorkers();
            bossUsernameComboBox.DisplayMember = "Username";
            bossUsernameComboBox.ValueMember = "ID";

            supervisorUsernameComboBox.DataSource = ProjectManagement.GetWorkers();
            supervisorUsernameComboBox.DisplayMember = "Username";
            supervisorUsernameComboBox.ValueMember = "ID";

            customerComboBox.DataSource = ProjectManagement.GetCustomers();
            customerComboBox.DisplayMember = "Username";
            customerComboBox.ValueMember = "ID";

            if (edit) {
                project = ProjectManagement.entities.Projects.Where(p => p.ID == projectView.ID).First();
                
                fill();
            }
            else
            {
                bs = new BindingSource();
                bs.DataSource = projectCustomers;
                customerDataGridView.DataSource = bs;
            }
        }

        private  void fill() {
            // TODO dodati description
            foreach (Customer customer in project.Customers)
            {
                projectCustomers.Add(new CustomerView(customer.ID, customer.User.Username, customer.Name));
            }
            bs = new BindingSource();
            bs.DataSource = projectCustomers;
            customerDataGridView.DataSource = bs;
            
            projectNameTextBox.Text = projectView.Name;
            startDateDateTimePicker.Value = projectView.StartDate;
            deadlineDateTimePicker.Value = projectView.DeadlineDate;
            budgetTextBox.Text = projectView.Budget.ToString();
            descriptionTextBox.Text = projectView.Name;
            //bossUsernameComboBox.SelectedIndex = bossUsernameComboBox.Items.IndexOf(new WorkerView(projectView.Boss.ID, ""));
            bossUsernameComboBox.SelectedIndex = bossUsernameComboBox.FindString(project.Boss.User.Username);
            supervisorUsernameComboBox.SelectedIndex = supervisorUsernameComboBox.FindString(project.Supervisor.User.Username);

            //supervisorUsernameComboBox.SelectedIndex = supervisorUsernameComboBox.Items.IndexOf(new WorkerView(projectView.Supervisor.ID, ""));
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (!projectCustomers.Contains((CustomerView)customerComboBox.SelectedItem)) {
                projectCustomers.Add((CustomerView)customerComboBox.SelectedItem);
            }
            
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerView customer = null;
            customer =(CustomerView) customerDataGridView.SelectedRows[0].DataBoundItem;
            if (customer != null) {
                projectCustomers.Remove(customer);
            }
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // TODO dodati description
            if (edit) {
                try
                {
                    project.Name = projectNameTextBox.Text;
                project.BossID = ((WorkerView)bossUsernameComboBox.SelectedItem).ID;
                project.SupervisorID = ((WorkerView)supervisorUsernameComboBox.SelectedItem).ID;
                project.StartDate = startDateDateTimePicker.Value.Date;
                project.DeadlineDate = deadlineDateTimePicker.Value.Date;
                project.Budget = decimal.Parse(budgetTextBox.Text);

                    project.Customers = new List<Customer>();
                foreach (CustomerView customer in projectCustomers)
                {
                    Customer cc = ProjectManagement.entities.Customers.Where(c => c.ID == customer.ID).First();
                    project.Customers.Add(cc);
                }

                ProjectManagement.entities.Projects.Attach(project);
                ProjectManagement.entities.Entry(project).State = System.Data.Entity.EntityState.Modified;
                ProjectManagement.entities.SaveChanges();
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
                    newProject.Budget = decimal.Parse(budgetTextBox.Text);

                   

                    foreach (CustomerView customer in projectCustomers) {
                        Customer cc = ProjectManagement.entities.Customers.Where(c => c.ID == customer.ID).First();
                        newProject.Customers.Add(cc);
                    }

                    ProjectManagement.entities.Projects.Add(newProject);
                    ProjectManagement.entities.SaveChanges();
                    this.Close();

                }
                catch (Exception) { }
            }
        }
    }
}
