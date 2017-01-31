using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khronos_PMS.Model;
using Khronos_PMS.Util;
using Khronos_PMS.ModelView;
using Khronos_PMS.View;

namespace Khronos_PMS {
    public partial class AdminForm : Form {
        private Admin admin;

        public AdminForm(int adminID) {
            InitializeComponent();
            this.admin = ProjectManagement.entities.Admins.Find(adminID);
            newAdminToolStripButton.Click += ToolStripButton_Click;
            newCustomerToolStripButton.Click += ToolStripButton_Click;
            newWorkerToolStripButton.Click += ToolStripButton_Click;
            changePasswordToolStripButton.Click += ToolStripButton_Click;
            newAdminToolStripButton.CheckedChanged += NewAdminToolStripButton_CheckedChanged;
            newCustomerToolStripButton.CheckedChanged += NewCustomerToolStripButton_CheckedChanged;
            newWorkerToolStripButton.CheckedChanged += NewWorkerToolStripButton_CheckedChanged;
            changePasswordToolStripButton.CheckedChanged += ChangePasswordToolStripButton_CheckedChanged;
        }

        private void ChangePasswordToolStripButton_CheckedChanged(object sender, EventArgs e) {
            ToolStripButton b = (ToolStripButton) sender;
            if (b.Checked) {
                changePasswordPanel.Visible = true;
            } else {
                resetControls(changePasswordPanel.Controls);
                changePasswordPanel.Visible = false;
            }
        }

        private void NewWorkerToolStripButton_CheckedChanged(object sender, EventArgs e) {
            ToolStripButton b = (ToolStripButton) sender;
            if (b.Checked) {
                newWorkerPanel.Visible = true;
            } else {
                resetControls(newWorkerPanel.Controls);
                newWorkerPanel.Visible = false;
            }
        }

        private void NewCustomerToolStripButton_CheckedChanged(object sender, EventArgs e) {
            ToolStripButton b = (ToolStripButton) sender;
            if (b.Checked) {
                newCustomerPanel.Visible = true;
            } else {
                resetControls(newCustomerPanel.Controls);
                newCustomerPanel.Visible = false;
            }
        }

        private void NewAdminToolStripButton_CheckedChanged(object sender, EventArgs e) {
            ToolStripButton b = (ToolStripButton) sender;
            if (b.Checked) {
                newAdminPanel.Visible = true;
            } else {
                resetControls(newAdminPanel.Controls);
                newAdminPanel.Visible = false;
            }
        }

        private void ToolStripButton_Click(object sender, EventArgs e) {
            foreach (var item in accountToolStrip.Items) {
                ToolStripButton i = (ToolStripButton) item;
                i.Checked = false;
            }
            ToolStripButton button = (ToolStripButton) sender;
            button.Checked = true;
        }

        private void workerOKButton_Click(object sender, EventArgs e) {
            createWorker();
        }

        private void adminOKButton_Click(object sender, EventArgs e) {
            createAdmin();
        }

        private void customerOKButton_Click(object sender, EventArgs e) {
            createCustomer();
        }

        private void changeOKButton_Click(object sender, EventArgs e) {
            changePassword();
        }

        private async void changePassword() {
            string username = changeUsernameComboBox.Text;
            string password = changeNewPasswordTextBox.Text;

            if (textBoxNotValid(changeNewPasswordTextBox) || textBoxNotValid(changeUsernameComboBox)) {
                return;
            } else {
                bool result = false;
                accountProgressBar.Style = ProgressBarStyle.Marquee;
                await Task.Run(() => { result = AccountManagement.ChangePassword(username, password); });
                accountProgressBar.Style = ProgressBarStyle.Continuous;
                if (result) {
                    MessageBox.Show("Success!");
                    resetControls(changePasswordPanel.Controls);
                } else {
                    MessageBox.Show("Error!");
                }
            }
        }

        private async void createCustomer() {
            string username = customerUsernameTextBox.Text;
            string password = customerPasswordTextBox.Text;
            string name = customerNameTextBox.Text;
            if (textBoxNotValid(customerUsernameTextBox) || textBoxNotValid(customerPasswordTextBox) || textBoxNotValid(customerNameTextBox)) {
                return;
            } else {
                bool result = false;
                accountProgressBar.Style = ProgressBarStyle.Marquee;
                await Task.Run(() => { result = AccountManagement.CreateCustomer(username, password, name); });
                accountProgressBar.Style = ProgressBarStyle.Continuous;
                if (result) {
                    MessageBox.Show("Success!");
                    resetControls(newWorkerPanel.Controls);
                } else {
                    MessageBox.Show("Error!");
                }
            }
        }

        private async void createWorker() {
            string username = workerUsernameTextBox.Text;
            string password = workerPasswordTextBox.Text;
            string firstname = workerFirstnameTextBox.Text;
            string lastname = workerLastnameTextBox.Text;
            if (textBoxNotValid(workerUsernameTextBox) || textBoxNotValid(workerPasswordTextBox) || textBoxNotValid(workerFirstnameTextBox) || textBoxNotValid(workerLastnameTextBox)) {
                return;
            } else {
                bool result = false;
                accountProgressBar.Style = ProgressBarStyle.Marquee;
                await Task.Run(() => { result = AccountManagement.CreateWorker(username, password, firstname, lastname); });
                accountProgressBar.Style = ProgressBarStyle.Continuous;
                if (result) {
                    MessageBox.Show("Success!");
                    resetControls(newWorkerPanel.Controls);
                } else {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void resetControls(Control.ControlCollection c) {
            foreach (var item in c) {
                if (item is TextBox) {
                    ((TextBox) item).Text = "";
                }
            }
        }

        private bool textBoxNotValid(Control t) {
            if (String.IsNullOrEmpty(t.Text)) {
                t.CreateGraphics().DrawRectangle(Pens.Red, 0, 0, t.Width - 1, t.Height - 1);
                return true;
            }
            return false;
        }

        private async void createAdmin() {
            string username = adminUsernameTextBox.Text;
            string password = adminPasswordTextBox.Text;
            string firstname = adminFirstnameTextBox.Text;
            string lastname = adminLastnameTextBox.Text;
            if (textBoxNotValid(adminUsernameTextBox) || textBoxNotValid(adminPasswordTextBox) || textBoxNotValid(adminFirstnameTextBox) || textBoxNotValid(adminLastnameTextBox)) {
                return;
            } else {
                bool result = false;
                accountProgressBar.Style = ProgressBarStyle.Marquee;
                await Task.Run(() => { result = AccountManagement.CreateAdmin(username, password, firstname, lastname); });
                accountProgressBar.Style = ProgressBarStyle.Continuous;
                if (result) {
                    MessageBox.Show("Success!");
                    resetControls(newAdminPanel.Controls);
                } else {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void changePasswordPanel_VisibleChanged(object sender, EventArgs e) {
            if (((Panel) sender).Visible) {
                accountProgressBar.Style = ProgressBarStyle.Marquee;
                new Task(() => { List<string> users = AccountManagement.GetUsernames(); Invoke(new MethodInvoker(() => { changeUsernameComboBox.DataSource = users; accountProgressBar.Style = ProgressBarStyle.Continuous; })); }).Start();
            }
        }

        private async void refreshButton_Click(object sender, EventArgs e) {
            refreshButton.Enabled = false;
            List<ProjectView> data = new List<ProjectView>();
            await Task.Run(() => { data.AddRange(ProjectManagement.getData(ProjectManagement.entities)); });
            projectDataGridView.DataSource = data;

            ProjectManagement.formatColumns(projectDataGridView);
            if (projectDataGridView.RowCount > 0) {
                projectDataGridView.Rows[0].Selected = true;
            }
            refreshButton.Enabled = true;
        }

        private void projectDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (projectDataGridView.SelectedRows.Count > 0) {
                ProjectView projectView = (ProjectView) ((DataGridView) sender).SelectedRows[0].DataBoundItem;
                Project project = ProjectManagement.entities.Projects.Where(q => q.ID == projectView.ID).First();
                projectDetailsTextBox.Text = project.Description;
            }
        }

        private void searchButton_Click(object sender, EventArgs e) {
            ProjectManagement.searchData(projectDataGridView, searchTextBox.Text, ProjectManagement.entities);
            ProjectManagement.formatColumns(projectDataGridView);
        }

        private void addProjectButton_Click(object sender, EventArgs e) {
            new ProjectForm().Show();
        }

        private void editProjectButton_Click(object sender, EventArgs e) {
            ProjectView projectView = (ProjectView) projectDataGridView.SelectedRows[0].DataBoundItem;
            if (projectView != null)
                new ProjectForm(projectView).Show();
        }

        private void activateToolStripButton_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripButton b = (ToolStripButton)sender;
            if (b.Checked)
            {
                ActivatePanel.Visible = true;
            }
            else
            {
                resetControls(ActivatePanel.Controls);
                ActivatePanel.Visible = false;
            }
        }

        private void activeOKButton_Click(object sender, EventArgs e)
        {
            activate();
        }

        private async void activate()
        {
            string username = activateUsernameComboBox.Text;
            bool active = activeCheckBox.Checked;

            if (textBoxNotValid(activateUsernameComboBox))
            {
                return;
            }
            else
            {
                bool result = false;
                accountProgressBar.Style = ProgressBarStyle.Marquee;
                await Task.Run(() => { result = AccountManagement.Activate(username, active); });
                accountProgressBar.Style = ProgressBarStyle.Continuous;
                if (result)
                {
                    MessageBox.Show("Success!");
                    resetControls(ActivatePanel.Controls);
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
        }

        private void ActivatePanel_VisibleChanged(object sender, EventArgs e)
        {
            if (((Panel)sender).Visible)
            {
                accountProgressBar.Style = ProgressBarStyle.Marquee;
                new Task(() => { List<User> users = AccountManagement.GetUsers(); Invoke(new MethodInvoker(() => { activateUsernameComboBox.DataSource = users; activateUsernameComboBox.DisplayMember = "Username"; accountProgressBar.Style = ProgressBarStyle.Continuous; })); }).Start();
            }
        }

        /*private void activateUsernameComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            activeCheckBox.Checked = ((User)activateUsernameComboBox.SelectedItem).Active;
        }*/

        private void activateUsernameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activateUsernameComboBox.SelectedIndex != -1)
            {
                activeCheckBox.Checked = ((User)activateUsernameComboBox.SelectedItem).Active;
            }
        }
    }
}