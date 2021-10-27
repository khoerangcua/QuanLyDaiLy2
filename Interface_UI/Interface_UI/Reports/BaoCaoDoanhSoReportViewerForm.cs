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
    public partial class BaoCaoDoanhSoReportViewerForm : Form
    {
        public List<BaoCaoDoanhSoObject> baoCaoDoanhSoObjects;
        public BaoCaoDoanhSoReportViewerForm()
        {
            InitializeComponent();
        }

        private void BaoCaoDoanhSoReport_Load(object sender, EventArgs e)
        {

            this.BaoCaoDoanhSoReportView.LocalReport.ReportPath = "BaoCaoDoanhSoReport.rdlc";
            var reportDataSource = new ReportDataSource("BaoCaoCongNoDataSet", baoCaoDoanhSoObjects);
            this.BaoCaoDoanhSoReportView.LocalReport.DataSources.Clear();
            this.BaoCaoDoanhSoReportView.LocalReport.DataSources.Add(reportDataSource);

            this.BaoCaoDoanhSoReportView.RefreshReport();
        }
    }
}
