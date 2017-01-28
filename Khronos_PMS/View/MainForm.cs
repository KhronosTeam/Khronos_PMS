using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khronos_PMS.Model;
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
            rightTableLayout.ColumnStyles[1].Width = 0;
        }


        private async void LoadProjects() {
            List<Project> projects = new List<Project>();
            await Task.Run(() => projects = projectManager.GetProjects(user));
        }

        private void toolStripMenuItem_Click(Object sender, EventArgs e) {
            Status status = (Status) ((ToolStripItem) sender).Tag;

            switch (status) {
                case Status.ACTIVE:
                    projectStatusButton.Image = StatusManager.Image(Status.ACTIVE);
                    break;
                case Status.IN_PROGRESS:
                    projectStatusButton.Image = StatusManager.Image(Status.IN_PROGRESS);
                    break;
                case Status.PAUSED:
                    projectStatusButton.Image = StatusManager.Image(Status.PAUSED);
                    break;
                case Status.COMPLETED:
                    projectStatusButton.Image = StatusManager.Image(Status.COMPLETED);
                    break;
                default:
                    throw new Exception("Invalid status!");
            }

            //todo project status update 
            //StatusManager.SaveStatus(project from listview, status);
        }
    }
}