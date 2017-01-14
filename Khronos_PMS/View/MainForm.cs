using System;
using System.Windows.Forms;
using Khronos_PMS.Model;

namespace Khronos_PMS {
    public partial class MainForm : Form {
        private Worker worker;
        public MainForm(Worker worker) {
            InitializeComponent();
            this.worker = worker;
            
        }
    }
}
