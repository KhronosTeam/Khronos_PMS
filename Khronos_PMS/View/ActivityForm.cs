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
using Khronos_PMS.Model;

namespace Khronos_PMS.View
{
    public partial class ActivityForm : Form
    {
        private Unit unit;
        private User user;
        private Activity activity;

        public ActivityForm(Unit unit, User user, Activity activity)
        {
            InitializeComponent();
            this.unit = unit;
            this.user = user;
            this.activity = activity;
            if (activity == null)
            {
                this.Text = "Add new activity";
            }else
            {
                this.Text = "Edit activity";
                manHourSpentTextBox.Text = activity.Manhour.ToString();
                expensesTextBox.Text = activity.Expense.ToString();
                noteTextBox.Text = activity.Note;
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
                new ActivityManager(unit, user, manhour, expense, note);
                this.Close();
            }else
            {
                activity.Manhour = manhour;
                activity.Expense = (decimal)expense;
                activity.Note = note;
                new ActivityManager(activity);
                this.Close();
            }
        }
    }
}
