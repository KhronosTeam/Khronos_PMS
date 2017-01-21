using System;
using System.Collections.Generic;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Khronos_PMS.Model;
using Khronos_PMS.Properties;
using Khronos_PMS.Util;

namespace Khronos_PMS {
    public partial class MainForm : Form {
        private ProjectManager projectManager;
        private User user;

        public MainForm(User user) {
            InitializeComponent();
            this.user = user;
        }

        private void MainForm_Load(Object sender, EventArgs e) {
            projectManager = new ProjectManager();
            userLabel.Text = "Marko Stijak";
        }
        

        private void button1_Click(Object sender, EventArgs e) {
            rightTableLayout.ColumnStyles[0].Width = 100;
            rightTableLayout.ColumnStyles[1].Width = 0;
        }


        private async void LoadProjects() {
            List<Project> projects = new List<Project>();
            await Task.Run(() => projects = projectManager.GetProjects(user));
            
        }


        private void statusMenuButton_MouseEnter(Object sender, EventArgs e) {
            ((ToolStripSplitButton) sender).Image = Resources.status_set_complete;
        }

        private void statusMenuButton_MouseLeave(Object sender, EventArgs e) {

        }
    }
}