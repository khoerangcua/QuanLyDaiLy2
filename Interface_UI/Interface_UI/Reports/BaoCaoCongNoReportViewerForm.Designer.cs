
namespace Interface_UI.Reports
{
    partial class BaoCaoCongNoReportViewerForm
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
            this.BaoCaoCongNoReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BaoCaoCongNoReportView
            // 
            this.BaoCaoCongNoReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaoCaoCongNoReportView.Location = new System.Drawing.Point(0, 0);
            this.BaoCaoCongNoReportView.Margin = new System.Windows.Forms.Padding(2);
            this.BaoCaoCongNoReportView.Name = "BaoCaoCongNoReportView";
            this.BaoCaoCongNoReportView.ServerReport.BearerToken = null;
            this.BaoCaoCongNoReportView.Size = new System.Drawing.Size(629, 366);
            this.BaoCaoCongNoReportView.TabIndex = 0;
            // 
            // BaoCaoCongNoReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 366);
            this.Controls.Add(this.BaoCaoCongNoReportView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BaoCaoCongNoReportViewerForm";
            this.Text = "BaoCaoCongNoReport";
            this.Load += new System.EventHandler(this.BaoCaoCongNoReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer BaoCaoCongNoReportView;
    }
}