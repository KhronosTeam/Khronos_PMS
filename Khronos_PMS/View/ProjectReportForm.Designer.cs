namespace Khronos_PMS.View
{
    partial class ProjectReportForm
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
            this.ProjectReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UnitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UnitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectReportViewer
            // 
            this.ProjectReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.UnitBindingSource;
            this.ProjectReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ProjectReportViewer.LocalReport.ReportEmbeddedResource = "Khronos_PMS.Report.ProjectReport.rdlc";
            this.ProjectReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ProjectReportViewer.Name = "ProjectReportViewer";
            this.ProjectReportViewer.Size = new System.Drawing.Size(418, 262);
            this.ProjectReportViewer.TabIndex = 0;
            // 
            // UnitBindingSource
            // 
            this.UnitBindingSource.DataSource = typeof(Khronos_PMS.Model.Unit);
            // 
            // ProjectReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 262);
            this.Controls.Add(this.ProjectReportViewer);
            this.Name = "ProjectReportForm";
            this.Text = "ProjectReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProjectReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ProjectReportViewer;
        private System.Windows.Forms.BindingSource UnitBindingSource;
    }
}