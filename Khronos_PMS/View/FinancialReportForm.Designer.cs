namespace Khronos_PMS.View
{
    partial class FinancialReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinancialReportForm));
            this.UnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.UnitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitBindingSource
            // 
            this.UnitBindingSource.DataSource = typeof(Khronos_PMS.Model.Unit);
            // 
            // financialReportViewer
            // 
            this.financialReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UnitBindingSource;
            this.financialReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.financialReportViewer.LocalReport.ReportEmbeddedResource = "Khronos_PMS.Report.FinancialReport.rdlc";
            this.financialReportViewer.Location = new System.Drawing.Point(0, 0);
            this.financialReportViewer.Name = "financialReportViewer";
            this.financialReportViewer.Size = new System.Drawing.Size(419, 269);
            this.financialReportViewer.TabIndex = 0;
            // 
            // FinancialReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 269);
            this.Controls.Add(this.financialReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinancialReportForm";
            this.Text = "FinancialReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FinancialReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer financialReportViewer;
        private System.Windows.Forms.BindingSource UnitBindingSource;
    }
}