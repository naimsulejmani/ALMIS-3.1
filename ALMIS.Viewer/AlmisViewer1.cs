using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using ALMIS.Viewer.App_Code;
using ALMIS.Viewer.App_Code.UI;
using Telerik.WinControls.UI;
using BE = ALMIS.BusinessEntities.Reports;
using BL = ALMIS.BusinessLogic.Reports;

namespace ALMIS.Viewer
{
    public partial class AlmisViewer : RadForm
    {
        public AlmisViewer()
        {
            InitializeComponent();
        }

        private void AlmisViewer_Load(object sender, EventArgs e)
        {
            rdtpOccuredAfter.Value = DateTime.Now;
            rdtpOccuredBefore.Value = DateTime.Now;
            rtpOccuredAfter.Value = DateTime.MinValue;
            rtpOccuredBefore.Value = DateTime.MaxValue;
        }

        private void btnListTables_Click(object sender, EventArgs e)
        {
            var generalList = new FrmGeneralList { Title = "Lista Tabelave", SelectedEnumrator = EnumGeneralList.Table };
            if (generalList.ShowDialog() == DialogResult.OK)
            {
                if (!cbTable.Items.Contains(generalList.TableName))
                    cbTable.Items.Add(generalList.TableName);
                cbTable.Text = generalList.TableName;
            }
        }

        private void btnListColumns_Click(object sender, EventArgs e)
        {
            var generalList = new FrmGeneralList { Title = "Lista Kolonave", SelectedEnumrator = EnumGeneralList.Column };
            if (generalList.ShowDialog() == DialogResult.OK)
            {
                if (!cbColumn.Items.Contains(generalList.ColumName))
                    cbColumn.Items.Add(generalList.ColumName);
                cbColumn.Text = generalList.ColumName;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var reports = new BE
                {
                    ApplicationName = cbApplication.Text,
                    UserName = cbUserName.Text,
                    RowKey = cbRowKey.Text,
                    TableName = cbTable.Text,
                    ColumnName = cbColumn.Text,
                    HostName = cbWorkstation.Text
                };
            if (chbInsert.Checked) reports.Event += "I,";
            if (chbUpdate.Checked) reports.Event += "U,";
            if (chbDelete.Checked) reports.Event += "D";
            object maximum = nupMaxEntries.Text;
            DateTime before = DateTime.Parse("2099/01/01"), after = DateTime.Parse("1901/01/01");
            if (chbOccuredAfter.Checked)
            {
                after =
                    DateTime.Parse(rdtpOccuredAfter.Value.ToShortDateString() + " " +
                                   rtpOccuredAfter.Value.Value.TimeOfDay.ToString());


            }
            if (chbOccuredBefore.Checked)
            {
                before =
                    DateTime.Parse(rdtpOccuredBefore.Value.ToShortDateString() + " " +
                                   rtpOccuredBefore.Value.Value.TimeOfDay.ToString());
                //TimeSpan t = rtpOccuredBefore.Value.Value.TimeOfDay;
                //a.TimeOfDay.Add(t);
                //before = a;
            }
            var result = BL.FindBy(reports, before, after, maximum);

            rgvAuditLog.DataSource = result;
            txtLogEntries.Text = result.Count.ToString(CultureInfo.InvariantCulture);
            //rgvAuditLog.BestFitColumns(BestFitColumnMode.DisplayedDataCells);
            // rgvAuditLog.AutoSizeColumnsMode = (GridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.AllCells;
            //MessageBox.Show(result.Count.ToString(CultureInfo.InvariantCulture));}


        }

        private void rgvAuditLog_CellClick(object sender, GridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                txtAuditID.Text = rgvAuditLog.Rows[i].Cells[0].Value.ToString();
                txtDateTime.Text = rgvAuditLog.Rows[i].Cells[1].Value.ToString();
                txtEvent.Text = rgvAuditLog.Rows[i].Cells[2].Value.ToString();
                txtTableName.Text = rgvAuditLog.Rows[i].Cells[3].Value.ToString();
                txtColumnName.Text = rgvAuditLog.Rows[i].Cells[4].Value.ToString();
                txtRowKey.Text = rgvAuditLog.Rows[i].Cells[5].Value.ToString();
                txtUserName.Text = rgvAuditLog.Rows[i].Cells[6].Value.ToString();
                txtOldValue.Text = rgvAuditLog.Rows[i].Cells[7].Value.ToString();
                txtNewValue.Text = rgvAuditLog.Rows[i].Cells[8].Value.ToString();
                txtHostname.Text = rgvAuditLog.Rows[i].Cells[9].Value.ToString();
                txtApplication.Text = rgvAuditLog.Rows[i].Cells[10].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void chbOccuredAfter_CheckedChanged(object sender, EventArgs e)
        {
            rdtpOccuredAfter.ReadOnly = !chbOccuredAfter.Checked;
            rtpOccuredAfter.ReadOnly = !chbOccuredAfter.Checked;
        }

        private void chbOccuredBefore_CheckedChanged(object sender, EventArgs e)
        {
            rdtpOccuredBefore.ReadOnly = !chbOccuredBefore.Checked;
            rtpOccuredBefore.ReadOnly = !chbOccuredBefore.Checked;
        }

        private void rbtnExportToCsv_Click(object sender, EventArgs e)
        {
            var saveFileDialogCsv = new SaveFileDialog
                {
                    InitialDirectory = "C:\\",
                    Filter = @"txt files (*.txt)|*.txt | csv files (*.csv)|*.csv ",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };
            var listaReport = (List<BE>)rgvAuditLog.DataSource;
            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {
                // ReSharper disable ConditionIsAlwaysTrueOrFalse
                Stream myStream;
                if ((myStream = saveFileDialogCsv.OpenFile()) != null)
                // ReSharper restore ConditionIsAlwaysTrueOrFalse
                {
                    var wText = new StreamWriter(myStream);
                    wText.WriteLine(listaReport[0].GetReportHeader());
                    foreach (var report in listaReport)
                    {
                        wText.WriteLine(report.ToString());
                    }
                    wText.Close();
                    myStream.Close();
                }
            }
            Process.Start(saveFileDialogCsv.FileName);
        }

        private void rmiAbout_Click(object sender, EventArgs e)
        {
            var about = new AboutAlmisViewer();
            about.Show();
        }

        private void rmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            var reports = (List<BE>)rgvAuditLog.DataSource;


            if (reports != null)
            {
                var saveFileDialog = new SaveFileDialog { Filter = @"Excel Files |*.xls", FilterIndex = 2, RestoreDirectory = true, FileName = "reports.xls" };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    ExcelExport.ExportToExcel(reports, fileName);
                }
            }
        }

        private void btnPrintPriview_Click(object sender, EventArgs e)
        {
            var report = new ReportAuditLog { AuditingReports = (List<BE>)rgvAuditLog.DataSource };
            report.Show();
        }

        private void rmiDisconnect_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnUserNameList_Click(object sender, EventArgs e)
        {
            var generalList = new FrmGeneralList { Title = "Lista Userave", SelectedEnumrator = EnumGeneralList.UserName };
            if (generalList.ShowDialog() == DialogResult.OK)
            {
                if (!cbUserName.Items.Contains(generalList.UserName))
                    cbUserName.Items.Add(generalList.UserName);
                cbUserName.Text = generalList.UserName;
            }
        }

        private void btnWorkstationList_Click(object sender, EventArgs e)
        {
            var generalList = new FrmGeneralList { Title = "Lista e Workstation", SelectedEnumrator = EnumGeneralList.Workstation };
            if (generalList.ShowDialog() == DialogResult.OK)
            {
                if (!cbWorkstation.Items.Contains(generalList.HostName))
                    cbWorkstation.Items.Add(generalList.HostName);
                cbWorkstation.Text = generalList.HostName;
            }
        }

        private void btnApplicationList_Click(object sender, EventArgs e)
        {
            var generalList = new FrmGeneralList { Title = "Lista Aplikacioneve", SelectedEnumrator = EnumGeneralList.Application };
            if (generalList.ShowDialog() == DialogResult.OK)
            {
                if (!cbApplication.Items.Contains(generalList.ApplicationName))
                    cbApplication.Items.Add(generalList.ApplicationName);
                cbApplication.Text = generalList.ApplicationName;
            }
        }

        private void btnRowKeyList_Click(object sender, EventArgs e)
        {
            var generalList = new FrmGeneralList { Title = "Lista Celesave Primar", SelectedEnumrator = EnumGeneralList.RowKey };
            if (generalList.ShowDialog() == DialogResult.OK)
            {
                if (!cbRowKey.Items.Contains(generalList.RowKey))
                    cbRowKey.Items.Add(generalList.RowKey);
                cbRowKey.Text = generalList.RowKey;
            }
        }
    }
}