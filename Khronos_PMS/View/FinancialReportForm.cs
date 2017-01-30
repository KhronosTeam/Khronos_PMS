using Khronos_PMS.Model;
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
    public partial class FinancialReportForm : Form
    {
        private Project project;

        public FinancialReportForm(Project p)
        {
            InitializeComponent();
            project = p;
        }

        private void FinancialReportForm_Load(object sender, EventArgs e)
        {
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("ProjectName", project.Name);
            parameters[1] = new ReportParameter("ProjectExpense", Convert.ToString(project.Expense));
            this.financialReportViewer.LocalReport.SetParameters(parameters);
            UnitBindingSource.DataSource = project.Units.ToList();
            this.financialReportViewer.RefreshReport();
        }
    }
}
