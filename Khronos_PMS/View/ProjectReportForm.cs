using Khronos_PMS.Model;
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
    public partial class ProjectReportForm : Form
    {
        private Project project;
        public ProjectReportForm(Project p)
        {
            InitializeComponent();
            project = p;
        }

        private void ProjectReportForm_Load(object sender, EventArgs e)
        {
            ReportParameter[] parameters = new ReportParameter[6];
            parameters[0] = new ReportParameter("ProjectName", project.Name);
            parameters[1] = new ReportParameter("Boss", project.Boss.FirstName + " " + project.Boss.LastName);
            parameters[2] = new ReportParameter("Description", project.Description);
            parameters[3] = new ReportParameter("StartDate", project.StartDate.ToShortDateString());
            parameters[4] = new ReportParameter("Deadline", project.DeadlineDate.ToShortDateString());
            parameters[5] = new ReportParameter("Status", StatusManager.Name(StatusManager.getStausById(project.Status)));
            UnitBindingSource.DataSource = project.Units.ToList();
            this.ProjectReportViewer.LocalReport.SetParameters(parameters);
            this.ProjectReportViewer.RefreshReport();
        }
    }
}
