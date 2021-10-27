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

namespace Interface_UI.Reports
{
    public partial class BaoCaoCongNoReportViewerForm : Form
    {
        public List<BaoCaoCongNoOj> BaoCaoCongNoList { get; set; }
        public BaoCaoCongNoReportViewerForm()
        {
            InitializeComponent();
        }

        private void BaoCaoCongNoReport_Load(object sender, EventArgs e)
        {
            this.BaoCaoCongNoReportView.LocalReport.ReportPath = "BaoCaoCongNoReport.rdlc";
            var reportDataSource = new ReportDataSource("BaoCaoCongNoDataSet", BaoCaoCongNoList);
            this.BaoCaoCongNoReportView.LocalReport.DataSources.Clear();
            this.BaoCaoCongNoReportView.LocalReport.DataSources.Add(reportDataSource);
            
            this.BaoCaoCongNoReportView.RefreshReport();


        }
    }
}
