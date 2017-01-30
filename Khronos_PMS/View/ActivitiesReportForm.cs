using Khronos_PMS.Model;
using Khronos_PMS.ModelView;
using Khronos_PMS.Util;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Khronos_PMS.View
{
    public partial class ActivitiesReportForm : Form
    {
        private Project project;
        public ActivitiesReportForm(Project p)
        {
            InitializeComponent();
            project = p;
        }

        private void ActivitiesReportForm_Load(object sender, EventArgs e)
        {
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("ProjectName", project.Name);
            this.activitiesReportViewer.LocalReport.SetParameters(parameters);
            var query = (from a in ProjectManager.entities.Activities
                         join u in ProjectManager.entities.Units on a.UnitID equals u.ID
                         join w in ProjectManager.entities.Workers on a.WorkerID equals w.ID
                         select new ActivityView { Note = a.Note, UnitName=u.Name, WorkerName=w.FirstName+" "+w.LastName});
            ActivityViewBindingSource.DataSource = query.ToList();
            this.activitiesReportViewer.RefreshReport();
        }
    }
}
