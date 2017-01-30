using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Khronos_PMS.Util;

namespace Khronos_PMS.View
{
    public partial class ActivityForm : Form
    {
        private ActivityManager manager;

        public ActivityForm(ActivityManager manager, bool edit)
        {
            InitializeComponent();
            this.manager = manager;
            if (edit)
            {
                this.Name = "Add new activity";
            }else
            {
                this.Name = "Edit activity";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if("Add new activity".Equals(this.Name))
            {
                int manhour = int.Parse(manHourSpentTextBox.Text);
                String note = noteTextBox.Text;
                if (manager.addActivity(manhour, note))
                {
                    this.Close();
                }else
                {
                    //Ispisati neku gresku
                }
            }
        }
    }
}
