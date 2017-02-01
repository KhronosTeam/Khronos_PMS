namespace Khronos_PMS.View
{
    partial class ActivitiesReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesReportForm));
            this.ActivityViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activitiesReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ActivityViewBindingSource
            // 
            this.ActivityViewBindingSource.DataSource = typeof(Khronos_PMS.ModelView.ActivityView);
            // 
            // activitiesReportViewer
            // 
            this.activitiesReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ActivityViewBindingSource;
            this.activitiesReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.activitiesReportViewer.LocalReport.ReportEmbeddedResource = "Khronos_PMS.Report.ActivitiesReport.rdlc";
            this.activitiesReportViewer.Location = new System.Drawing.Point(0, 0);
            this.activitiesReportViewer.Name = "activitiesReportViewer";
            this.activitiesReportViewer.Size = new System.Drawing.Size(592, 296);
            this.activitiesReportViewer.TabIndex = 0;
            // 
            // ActivitiesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 296);
            this.Controls.Add(this.activitiesReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActivitiesReportForm";
            this.Text = "ActivitiesReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ActivitiesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivityViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer activitiesReportViewer;
        private System.Windows.Forms.BindingSource ActivityViewBindingSource;
    }
}