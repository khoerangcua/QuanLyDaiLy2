
namespace Interface_UI.Reports
{
    partial class BaoCaoDoanhSoReportViewerForm
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
            this.BaoCaoDoanhSoReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BaoCaoDoanhSoReportView
            // 
            this.BaoCaoDoanhSoReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaoCaoDoanhSoReportView.Location = new System.Drawing.Point(0, 0);
            this.BaoCaoDoanhSoReportView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BaoCaoDoanhSoReportView.Name = "BaoCaoDoanhSoReportView";
            this.BaoCaoDoanhSoReportView.ServerReport.BearerToken = null;
            this.BaoCaoDoanhSoReportView.Size = new System.Drawing.Size(741, 366);
            this.BaoCaoDoanhSoReportView.TabIndex = 0;
            // 
            // BaoCaoDoanhSoReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 366);
            this.Controls.Add(this.BaoCaoDoanhSoReportView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoDoanhSoReportViewerForm";
            this.Text = "BaoCaoDoanhSoReport";
            this.Load += new System.EventHandler(this.BaoCaoDoanhSoReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer BaoCaoDoanhSoReportView;
    }
}