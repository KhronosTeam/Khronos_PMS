using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khronos_PMS.Model;
using Khronos_PMS.Util;

namespace Khronos_PMS.View {
    public partial class MainForm : Form {
        private User user;

        public MainForm(User user) {
            InitializeComponent();
            this.user = user;
        }

        private void MainForm_Load(Object sender, EventArgs e) {
            //todo Num 0. u zavisnoti ko se prijavio (worker, customer, superviosor) neke opcije trebaju biti prikazane, a neke ne

            //todo Num 1. učitati projekte, popuniti listview i po defaultu neka prvi bude selektovan

            //todo Num 2. inicijalizovati sva polja vezana za projekat (Project name, role, boss, description, dates, ...) 

            //todo Num 3. učitati radnike i popuniti listview

            //todo Num 4. učitati unite za selektovani projekat i popuniti treeview

            //todo Num 5. postaviti userLabel text za logovanog usera
        }

        private void button1_Click(Object sender, EventArgs e) {
            rightTableLayout.ColumnStyles[1].Width = 0;
        }
        
        private void projectsSearchButton_Click(Object sender, EventArgs e) {
            //todo Num 6. implementirati pretragu projekata, prikazati obavještenja
        }

        private void workersSearchButton_Click(Object sender, EventArgs e) {
            //todo Num 7. implementirati pretragu radnika, prikazati obavještenja
        }

        private void unitsSearchButton_Click(Object sender, EventArgs e) {
            //todo Num 8. implementirati pretragu unita, prikazati obavještenja
        }

        private void projectToolStripMenuItem_Click(Object sender, EventArgs e) {
            Status status = (Status)((ToolStripItem)sender).Tag;
            projectStatusMenuButton.Image = StatusManager.Image(status);

            new Task(() => {
                //todo Num 9. project status update
                //StatusManager.UpdateStatus(selected project, status);
            }).Start();
        }

        private void unitStatusToolStripMenuItem_Click(Object sender, EventArgs e) {
            Status status = (Status)((ToolStripItem)sender).Tag;
            unitStatusMenuButton.Image = StatusManager.Image(status);

            new Task(() => {
                //todo Num 10. unit status update
                //StatusManager.UpdateStatus(selected unit, status);
            }).Start();
        }

        private void unitPriorityToolStripMenuItem_Click(Object sender, EventArgs e) {
            Priority priority = (Priority) ((ToolStripItem)sender).Tag;
            unitPriorityMenuButton.Image = PriorityManager.Image(priority);

            new Task(() => {
                //todo Num 11. unit priority update
                //PriorityManager.UpdatePriority(selected unit, priority);
            }).Start();
        }
    }
}