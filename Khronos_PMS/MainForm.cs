using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khronos_PMS {
    public partial class MainForm : Form {
        private User user;
        public MainForm(User user) {
            InitializeComponent();
            this.user = user;
        }
    }
}
