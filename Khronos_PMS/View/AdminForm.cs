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

namespace Khronos_PMS {
    public partial class AdminForm : Form {
        private Admin admin;
        public AdminForm(Admin admin) {
            InitializeComponent();
            this.admin = admin;
        }
    }
}
