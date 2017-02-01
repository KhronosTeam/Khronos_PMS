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

namespace Khronos_PMS.View {
    public partial class ActivityViewForm : Form {
        private Activity activity;

        public ActivityViewForm(Activity activity) {
            InitializeComponent();
            this.activity = activity;
        }

        private void ActivityViewForm_Load(Object sender, EventArgs e) {
            workerLabel.Text = activity.WorksOn.AssignedTo.Worker.FullName;
            dateLabel.Text = activity.Date.ToShortDateString();
            manhoursLabel.Text = activity.Manhour + " h";
            expanseLabel.Text = String.Format("{0:0.00} KM", activity.Expense);
            noteTextBox.Text = activity.Note;
        }

        private void cancelButton_Click(Object sender, EventArgs e) {
            Close();
        }
    }
}