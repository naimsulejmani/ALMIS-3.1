
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

        //Metoda on load kur hapet Almis Viewer
        private void AlmisViewer_Load(object sender, EventArgs e)
        {
            rdtpOccuredAfter.Value = DateTime.Now;
            rdtpOccuredBefore.Value = DateTime.Now;
            rtpOccuredAfter.Value = DateTime.MinValue;
            rtpOccuredBefore.Value = DateTime.MaxValue;
            ControlCursor(this);

        }

        //Metoda e butonit qe e hap listen e tabelave [...]
        private void btnListTables_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;

            var filterText = cbTable.Text;
            var tableList = new FrmGeneralList
            {
                Title = "Lista Tabelave",
                SelectedEnumrator = EnumGeneralList.Table,
                FilterText = filterText
            };
            if (tableList.ShowDialog() == DialogResult.OK)
            {
                if (!cbTable.Items.Contains(tableList.TableName))
                    cbTable.Items.Add(tableList.TableName);
                cbTable.Text = tableList.TableName;
            }
        }
        //Metoda e butonit qe e hap listen e kolonave [...]
        private void btnListColumns_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            var filterText = cbColumn.Text;
            var columnList = new FrmGeneralList { Title = "Lista Kolonave", SelectedEnumrator = EnumGeneralList.Column, FilterText = filterText };
            var d = columnList.ShowDialog();
            if ( d== DialogResult.OK)
            {
                if (!cbColumn.Items.Contains(columnList.ColumName))
                    cbColumn.Items.Add(columnList.ColumName);
                cbColumn.Text = columnList.ColumName;
            }
        }
        //Metoda e butonit KERKO PER AUDIT LOG
        private void btnFind_Click(object sender, EventArgs e)
        {
            //Nese eshte help kursori hape helpin per ndryshe vazhdo
            if (IsHelpClick((Control)sender)) return;

            //Krijojm nje objekt nga fitlrat te cilat i kemi dhene 
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
                if (rtpOccuredAfter.Value != null)
                    after =
                        DateTime.Parse(rdtpOccuredAfter.Value.ToShortDateString() + " " +
                                       rtpOccuredAfter.Value.Value.TimeOfDay);
            }
            if (chbOccuredBefore.Checked)
            {
                if (rtpOccuredBefore.Value != null)
                    before =
                        DateTime.Parse(rdtpOccuredBefore.Value.ToShortDateString() + " " +
                                       rtpOccuredBefore.Value.Value.TimeOfDay);
            }
            //thirrim metoden duke ia dergu parametrat e dhene reports me filtra si tablename,columnname, etj
            //daten before dhe after dhe top maximum rows
            var result = BL.FindBy(reports, before, after, maximum);
            //mbushim data grid viewin me rezultatin qe na kthehet
            dgvReports.DataSource = result;
            //sa te hyra kemi ne raport
            txtLogEntries.Text = result.Count.ToString(CultureInfo.InvariantCulture);
            //dgvAuditLog.BestFitColumns(BestFitColumnMode.AllCells);
            GridColumnTranslator.TranslateColumns(dgvReports, this);
            //MessageBox.Show(result.Count.ToString(CultureInfo.InvariantCulture));}


        }

        //Per me mundesu aktivizimin ENABLED READONLY
        private void chbOccuredAfter_CheckedChanged(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            rdtpOccuredAfter.ReadOnly = !chbOccuredAfter.Checked;
            rtpOccuredAfter.ReadOnly = !chbOccuredAfter.Checked;
        }
        //Per me mundesu aktivizimin ENABLED READONLY
        private void chbOccuredBefore_CheckedChanged(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            rdtpOccuredBefore.ReadOnly = !chbOccuredBefore.Checked;
            rtpOccuredBefore.ReadOnly = !chbOccuredBefore.Checked;
        }

        //Metoda per butonin EXPORT ne CSV
        private void rbtnExportToCsv_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            var saveFileDialogCsv = new SaveFileDialog
                {
                    InitialDirectory = "C:\\",
                    Filter = @"txt files (*.txt)|*.txt | csv files (*.csv)|*.csv ",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };
            var listaReport = (List<BE>)dgvReports.DataSource;
            if (saveFileDialogCsv.ShowDialog() == DialogResult.OK)
            {

                Stream myStream;
                // ReSharper disable ConditionIsAlwaysTrueOrFalse
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
        }

        //ABOUT FORMA
        private void rmiAbout_Click(object sender, EventArgs e)
        {
            var about = new AboutAlmisViewer();
            about.Show();
        }

        //Mbyll
        private void rmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Metoda e butunit per XLS
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            var reports = (List<BE>)dgvReports.DataSource;


            if (reports != null)
            {
                var saveFileDialog = new SaveFileDialog { Filter = @"Excel Files |*.xls", FilterIndex = 2, RestoreDirectory = true, FileName = "reports.xls" };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;
                    ExcelExport.ExportToExcel(reports, fileName);
                }
                else
                {
                    // ReSharper disable RedundantJumpStatement
                    return;
                    // ReSharper restore RedundantJumpStatement
                    //app.Quit();
                }

            }
        }

        //Print Privie metoda 
        private void btnPrintPriview_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            var report = new ReportAuditLog { AuditingReports = (List<BE>)dgvReports.DataSource };
            report.Show();
        }

        //DISKONEKT METODA PER LOGOFF
        private void rmiDisconnect_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Metoda per shfaqejen e user name listave [...]
        private void btnUserNameList_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            var filter = cbUserName.Text;
            var userNameList = new FrmGeneralList { Title = "Lista Userave", SelectedEnumrator = EnumGeneralList.UserName,FilterText =filter};
            if (userNameList.ShowDialog() == DialogResult.OK)
            {
                if (!cbUserName.Items.Contains(userNameList.UserName))
                    cbUserName.Items.Add(userNameList.UserName);
                cbUserName.Text = userNameList.UserName;
            }
        }
        //Metoda per shfaqejen e workstation listave [...]
        private void btnWorkstationList_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            var filter = cbWorkstation.Text;
            var hostNameList = new FrmGeneralList { Title = "Lista e Workstation", SelectedEnumrator = EnumGeneralList.Workstation, FilterText = filter };
            if (hostNameList.ShowDialog() == DialogResult.OK)
            {
                if (!cbWorkstation.Items.Contains(hostNameList.HostName))
                    cbWorkstation.Items.Add(hostNameList.HostName);
                cbWorkstation.Text = hostNameList.HostName;
            }
        }
        //Metoda per shfaqejen e application listave [...]
        private void btnApplicationList_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            var filter = cbApplication.Text;
            var applicationList = new FrmGeneralList { Title = "Lista Aplikacioneve", SelectedEnumrator = EnumGeneralList.Application,FilterText = filter};
            if (applicationList.ShowDialog() == DialogResult.OK)
            {
                if (!cbApplication.Items.Contains(applicationList.ApplicationName))
                    cbApplication.Items.Add(applicationList.ApplicationName);
                cbApplication.Text = applicationList.ApplicationName;
            }
        }

        //Metoda per shfaqejen e celesit Primar te listave [...]
        private void btnRowKeyList_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            var filter = cbRowKey.Text;
            var rowKeyList = new FrmGeneralList { Title = "Lista Celesave Primar", SelectedEnumrator = EnumGeneralList.RowKey,FilterText = filter};
            if (rowKeyList.ShowDialog() == DialogResult.OK)
            {
                if (!cbRowKey.Items.Contains(rowKeyList.RowKey))
                    cbRowKey.Items.Add(rowKeyList.RowKey);
                cbRowKey.Text = rowKeyList.RowKey;
            }
        }

        //variabla PER ALERT
        private readonly RadDesktopAlert _alert = new RadDesktopAlert();
        //Metoda qe aktivizon KURSORIN PER HELP


        void HelpClickButton()
        {
            Cursor = !HelpLibrary.IsClicked ? new Cursor(Application.StartupPath + "\\images\\Help.cur") : Cursors.Default;
            ControlCursor(this);
            HelpLibrary.IsClicked = !HelpLibrary.IsClicked;
            if (HelpLibrary.IsClicked)
            {
                _alert.CaptionText = "Ndihma!";
                _alert.ContentText = "Kliko në kontrollën për të mësuar përdorimin e tij.";
                _alert.Show();
            }
        }
        //KTHIMI I KONTROLLAVE NE DEFAULT si eshte e definuar nga sistemi
        void ControlCursor(Control c)
        {
            foreach (var control in c.Controls)
            {
                var view = control as DataGridView;
                if (view != null)
                {
                    view.Cursor = Cursor;
                }
                else if (control is RadDateTimePicker)
                {
                    ((RadDateTimePicker)control).Cursor = Cursor;
                }
                else if (control is RadTimePicker)
                {
                    ((RadTimePicker)control).Cursor = Cursor;
                }
                else if (control is TextBox)
                {
                    ((TextBox)control).Cursor = Cursor;
                }
                else if (control is RadPanel)
                {
                    ControlCursor((RadPanel)control);
                }
                else if (control is SplitPanel)
                {
                    ControlCursor((SplitPanel)control);
                }
            }
        }

        //Kur klikojme ne COMBO BOX me na u hap helpi
        private void cbTable_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }

        //Kur klikojme ne COMBO BOX me na u hap helpi
        private bool IsHelpClick(Control ctrl)
        {
            HelpLibrary.IsClicked = false;
            if (Cursor != Cursors.Default)
            {
                Cursor = HelpLibrary.ControllHelp(this, ctrl);
                ControlCursor(this);
                return true;
            }
            return false;
        }

        //Metoda kur klikojme ne GRID VIEW TE ALMIS VIEWER
        private void dgvAuditLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
            int i = e.RowIndex;
            CurrentSettings.GridRowSelected = i;
            try
            {
                ShowObjectToForm(CreateObjectFromDataGridView(i));
            }
            catch
            {
                // ReSharper disable RedundantJumpStatement
                return;
                // ReSharper restore RedundantJumpStatement
            }
        }
        //Kur klikojme ne COMBO BOX me na u hap helpi
        private void cbColumn_Click(object sender, EventArgs e)
        {
            // ReSharper disable RedundantJumpStatement
            IsHelpClick((Control)sender);
            // ReSharper restore RedundantJumpStatement
        }
        //Kur klikojme ne COMBO BOX me na u hap helpi
        private void cbUserName_Click(object sender, EventArgs e)
        {
            // ReSharper disable RedundantJumpStatement
            IsHelpClick((Control)sender);
            // ReSharper restore RedundantJumpStatement
        }
        //Kur klikojme ne COMBO BOX me na u hap helpi
        private void cbWorkstation_Click(object sender, EventArgs e)
        {
            // ReSharper disable RedundantJumpStatement
            IsHelpClick((Control)sender);
            // ReSharper restore RedundantJumpStatement
        }
        //Kur klikojme ne COMBO BOX me na u hap helpi
        private void cbApplication_Click(object sender, EventArgs e)
        {
            // ReSharper disable RedundantJumpStatement
            IsHelpClick((Control)sender);
            // ReSharper restore RedundantJumpStatement
        }
        //Kur klikojme ne COMBO BOX me na u hap helpi
        private void cbRowKey_Click(object sender, EventArgs e)
        {
            // ReSharper disable RedundantJumpStatement
            IsHelpClick((Control)sender);

        }
        //Kur klikojme ne NUMERIC UP DOWN MAXIMUM me na u hap helpi
        private void nupMaxEntries_ValueChanged(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme neCHECKBOX me na u hap helpi
        private void chbInsert_CheckedChanged(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme neCHECKBOX me na u hap helpi
        private void chbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme neCHECKBOX me na u hap helpi
        private void chbDelete_CheckedChanged(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne DATETIME PICKER me na u hap helpi DATA
        private void rdtpOccuredAfter_ValueChanged(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne DATETIME PICKER me na u hap helpi DATA
        private void rdtpOccuredBefore_ValueChanged(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne DATETIME PICKER me na u hap helpi DATA
        private void rtpOccuredAfter_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne DATETIME PICKER me na u hap helpi DATA
        private void rtpOccuredBefore_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne NUMERIC UP DOWN MAXIMUM me na u hap helpi
        private void nupMaxEntries_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtNewValue_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtOldValue_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtAuditID_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtDateTime_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtEvent_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtTableName_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtColumnName_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtRowKey_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtUserName_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtHostname_Click(object sender, EventArgs e)
        {
            IsHelpClick((Control)sender);
        }
        //Kur klikojme ne TEXTBOX me na u hap helpi
        private void txtApplication_Click(object sender, EventArgs e)
        {
            if (IsHelpClick((Control)sender)) return;
        }

        //Hapja e permbajtjes se ndihmes per helpin online
        private void rmiContents_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Help\Almis.Viewer.chm");
        }

        //KJO ESHTE KUR PREKIM BUTONIN UP dhe DOWN
        private void dgvAuditLog_KeyDown(object sender, KeyEventArgs e)
        {

            int i = CurrentSettings.GridRowSelected;
            if (e.KeyCode == Keys.Up)
            {
                if (i > 0)
                {
                    i--;
                    CurrentSettings.GridRowSelected = i;
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (i < dgvReports.RowCount)
                {
                    i++;
                    CurrentSettings.GridRowSelected = i;
                }
            }
            try
            {
                ShowObjectToForm(CreateObjectFromDataGridView(i));
            }
            catch
            {
                // ReSharper disable RedundantJumpStatement
                return;
                // ReSharper restore RedundantJumpStatement
            }
        }

        //Krijimi i objektit nga GDIR VIEW
        private BE CreateObjectFromDataGridView(int rowIndex)
        {
            var rowReport = new BE
                {
                    AuditLogID = int.Parse(dgvReports.Rows[rowIndex].Cells[0].Value.ToString()),
                    PostedDateTime = DateTime.Parse(dgvReports.Rows[rowIndex].Cells[1].Value.ToString()),
                    Event = dgvReports.Rows[rowIndex].Cells[2].Value != null
                                ? dgvReports.Rows[rowIndex].Cells[2].Value.ToString()
                                : "",
                    TableName = dgvReports.Rows[rowIndex].Cells[3].Value != null
                                    ? dgvReports.Rows[rowIndex].Cells[3].Value.ToString()
                                    : "",
                    ColumnName = dgvReports.Rows[rowIndex].Cells[4].Value != null
                                     ? dgvReports.Rows[rowIndex].Cells[4].Value.ToString()
                                     : "",
                    RowKey = dgvReports.Rows[rowIndex].Cells[5].Value != null
                                 ? dgvReports.Rows[rowIndex].Cells[5].Value.ToString()
                                 : "",
                    UserName = dgvReports.Rows[rowIndex].Cells[6].Value != null
                                   ? dgvReports.Rows[rowIndex].Cells[6].Value.ToString()
                                   : "",
                    OldValue = dgvReports.Rows[rowIndex].Cells[7].Value != null
                                   ? dgvReports.Rows[rowIndex].Cells[7].Value.ToString()
                                   : "",
                    NewValue = dgvReports.Rows[rowIndex].Cells[8].Value != null
                                   ? dgvReports.Rows[rowIndex].Cells[8].Value.ToString()
                                   : "",
                    HostName = dgvReports.Rows[rowIndex].Cells[9].Value != null
                                   ? dgvReports.Rows[rowIndex].Cells[9].Value.ToString()
                                   : "",
                    ApplicationName = dgvReports.Rows[rowIndex].Cells[10].Value != null
                                          ? dgvReports.Rows[rowIndex].Cells[10].Value.ToString()
                                          : ""
                };
            return rowReport;
        }


        //SHFAQJA E OBJEKTIT NGA GRIDVIEW
        private void ShowObjectToForm(BE reports)
        {
            txtAuditID.Text = reports.AuditLogID.ToString(CultureInfo.InvariantCulture);
            txtDateTime.Text = reports.PostedDateTime.ToShortDateString();
            txtEvent.Text = reports.Event;
            txtTableName.Text = reports.TableName;
            txtColumnName.Text = reports.ColumnName;
            txtRowKey.Text = reports.RowKey;
            txtUserName.Text = reports.UserName;
            txtOldValue.Text = reports.OldValue;
            txtNewValue.Text = reports.NewValue;
            txtHostname.Text = reports.HostName;
            txtApplication.Text = reports.ApplicationName;
        }

        private void btnMoreDateTimeFilters_Click(object sender, EventArgs e)
        {
            var dtf = new DateFilterForm();
            if (dtf.ShowDialog() == DialogResult.OK)
            {
                if (dtf.ToDateTime > dtf.FromDateTime)
                {
                    rdtpOccuredAfter.Text = dtf.FromDateTime.ToShortDateString();
                    rdtpOccuredBefore.Text = dtf.ToDateTime.ToShortDateString();
                    chbOccuredAfter.Checked = true;
                    chbOccuredBefore.Checked = true;
                }
                else
                {
                    MessageBox.Show(@"Keni zgjedhur kombinimin e datave gabim...");
                }
            }
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            HelpClickButton();
        }
    }
}