using System;
using System.Collections.Generic;
using System.Windows.Forms;
//using Microsoft.Reporting.WinForms;
using BE = ALMIS.BusinessEntities.Reports;

namespace ALMIS.Viewer
{
    public partial class ReportAuditLog : Form
    {
        public ReportAuditLog()
        {
            InitializeComponent();
        }
        public List<BE> AuditingReports { get; set; }
       // public ReportDataSource ReportAuditLogDataSource { get; set; }


        private void ReportAuditLog_Load(object sender, EventArgs e)
        {
            //ReportAuditLogDataSource = new ReportDataSource("Reports", AuditingReports);
            //reportViewer1.ProcessingMode = ProcessingMode.Local;
            //reportViewer1.LocalReport.ReportPath = @"rptAuditLog.rdlc";
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(ReportAuditLogDataSource);
            //reportViewer1.LocalReport.Refresh();
            //reportViewer1.RefreshReport();
        }
    }
}
