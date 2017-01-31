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
            if (!edit)
            {
                this.Text = "Add new activity";
            }else
            {
                this.Text = "Edit activity";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int manhour = int.Parse(manHourSpentTextBox.Text);
            String note = noteTextBox.Text;
            double expense = double.Parse(expensesTextBox.Text);
            if ("Add new activity".Equals(this.Text))
            {
                
                if (manager.addActivity(manhour, expense, note))
                {
                    this.Close();
                }else
                {
                    //todo Ispisati neku gresku
                }
            }else
            {
                if (manager.addActivity(manhour, expense, note))
                {
                    this.Close();
                }
                else
                {
                    //todo Ispisati neku gresku
                }
            }
        }
    }
}
