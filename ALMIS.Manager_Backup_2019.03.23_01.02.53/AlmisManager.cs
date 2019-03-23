using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using ALMIS.Manager.App_Code;
using ALMIS.Manager.Properties;
using Telerik.WinControls.UI;
using BE = ALMIS.BusinessEntities;
using BL = ALMIS.BusinessLogic;

namespace ALMIS.Manager
{
    public partial class AlmisManager : RadForm
    {
        public AlmisManager()
        {
            _userRowSelected = 0;
            InitializeComponent();
            dgvTables.AutoGenerateColumns = false;
            dgvColumns.AutoGenerateColumns = false;
        }

        private readonly RadDesktopAlert _alert = new RadDesktopAlert();
        private bool _newuser;

        private void rpvAlmisManager_SelectedPageChanged(object sender, EventArgs e)
        {
            switch (rpvAlmisManager.SelectedPage.Text)
            {
                case "Archive  Log":
                    _alert.CaptionText = "Almis Info for Archive";
                    _alert.ContentText = "Please verify before archiving the log data...";
                    _alert.Show();
                    break;
                case "Uninstall Audit":
                    _alert.CaptionText = "Almis Info for Uninstalling Audit";
                    _alert.ContentText = "If you uninstall this is unrecoverable...";
                    _alert.Show();
                    break;
                case "Archive Or Delete Log":
                    SelectDateTimeArchiveDelete();
                    break;
            }
        }

        void SelectDateTimeArchiveDelete()
        {
            rdtpArchiveDate.Value = DateTime.Now;
            rdtpDateDelete.Value = DateTime.Now;
            rtpArchiveTime.Value = DateTime.MinValue;
            rtpTimeDelete.Value = DateTime.MinValue;

        }

        private void rmiContents_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Help\Almis.Manager.chm");
        }

        private void AlmisManager_Load(object sender, EventArgs e)
        {
            //rmcbSelectTable.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbDatabase.Text = CurrentSettings.Database;
            CurrentSettings.RuntimeConfigProperties = BL.AuditConfig.FindAll();
            GetAuditTablesAndColumns();
            PrepareConfiguration();
            rrbAllTables.IsChecked = true;
            rmcbSelectTable.DropDownAnimationEnabled = true;
            dgvAuditUsers.AutoGenerateColumns = false;
            LoadAuditUserList();


            //rmcbSelectTable.DropDownListElement.AutoCompleteAppend.LimitToList = true;
        }

        private void GetAuditTablesAndColumns()
        {
            CurrentSettings.DefaultAuditTableList = BL.AuditTables.FindAll();

            // rgvTables.DataSource = CurrentSettings.DefaultAuditTableList;
            rmcbSelectTable.DataSource = BL.General.FindTableList();
            //rmcbSelectTable.AutoSizeDropDownToBestFit = true;
            //rmcbSelectTable.BestFitColumns();
            if (CurrentSettings.DefaultAuditTableList != null && CurrentSettings.DefaultAuditTableList.Count > 0)
            {
                dgvColumns.DataSource =
                    BL.AuditColumns.FindColumnByTableName(CurrentSettings.DefaultAuditTableList[0].TableName);
                dgvTriggers.DataSource = BL.AuditTriggers.FindBy(CurrentSettings.DefaultAuditTableList[0].TableSchema, CurrentSettings.DefaultAuditTableList[0].TableName);
            }
            else
            {
                dgvColumns.DataSource = new List<BE.AuditColumns>();
                dgvTriggers.DataSource = new List<BE.AuditTriggers>();
            }
            Translator.TranslateColumns(dgvTables, this);
            Translator.TranslateColumns(dgvColumns, this);
            SelectDateTimeArchiveDelete();
            dgvTables.DataSource = CurrentSettings.DefaultAuditTableList;

        }
        public void PrepareConfiguration()
        {
            var result = CurrentSettings.Validate("PREREQUIREMENTS");
            if (result == "INSTALLED")
            {
                lblPrerequirementsMsg.Text =
                    Resources.prerequirementsMsgBox;
                rbtnInstallPrerequirements.Enabled = false;
                MakeEnabled(true);
            }
            else
            {
                rbtnInstallPrerequirements.Enabled = true;
                lblPrerequirementsMsg.Text = "";
                MakeEnabled(false);
            }
        }

        void MakeEnabled(bool enabled)
        {
            //rbtnRebuildAuditTriggers.Enabled = enabled;
            //rrbSingelTable.Enabled = enabled;
            //rbtnRestoreToDefault.Enabled = enabled;
            //dgvTables.Enabled = enabled;
            //dgvTriggers.Enabled = enabled;
            //dgvColumns.Enabled = enabled;
            rpvAlmisManager.Pages[0].Enabled = !enabled;
            rpvAlmisManager.Pages[1].Enabled = enabled;
            rpvAlmisManager.Pages[2].Enabled = enabled;
            rpvAlmisManager.Pages[3].Enabled = enabled;
            rpvAlmisManager.Pages[4].Enabled = enabled;
            rpvAlmisManager.Pages[5].Enabled = enabled;
        }

        private int _selectedRowIndex;

        void SelectTriggersForTable(int index)
        {
            string tableName = dgvTables.Rows[index].Cells[0].Value.ToString();
            string tableSchema = dgvTables.Rows[index].Cells[1].Value.ToString();
            var triggers = BL.AuditTriggers.FindBy(tableSchema, tableName);

            dgvTriggers.DataSource = triggers;
            Translator.TranslateColumns(dgvTriggers, this);

        }
        void SelectColumnsForTable(int index)
        {
            string tableName = dgvTables.Rows[index].Cells[0].Value.ToString();
            var columnList = BL.AuditColumns.FindColumnByTableName(tableName);
            dgvColumns.DataSource = columnList;
            Translator.TranslateColumns(dgvColumns, this);
        }

        private void chbAuditAllInserted_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheckBoxOnGrid(3, chbAuditAllInserted, dgvTables);
        }

        void ChangeCheckBoxOnGrid(int columnIndex, CheckBox chb, DataGridView rgv)
        {
            for (int rowIndex = 0; rowIndex < rgv.Rows.Count; rowIndex++)
            {
                //DataGridViewRow row = rgv.Rows[i];
                //row.Cells[index].Value = chb.Checked;
                SelectRowColumnCheckBoxes(rowIndex, columnIndex, chb.Checked);
            }
            CurrentSettings.DefaultAuditTableList = GetListFromGridView();
        }

        private void chbAuditAllUpdated_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheckBoxOnGrid(4, chbAuditAllUpdated, dgvTables);
        }

        private void chbAuditAllDeleted_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheckBoxOnGrid(5, chbAuditAllDeleted, dgvTables);
        }

        private void chbAuditAll_CheckedChanged(object sender, EventArgs e)
        {
            ChangeCheckBoxOnGrid(2, chbAuditAll, dgvTables);
            ChangeCheckBoxOnGrid(3, chbAuditAll, dgvTables);
            ChangeCheckBoxOnGrid(4, chbAuditAll, dgvTables);
            ChangeCheckBoxOnGrid(5, chbAuditAll, dgvTables);
            chbAuditAllInserted.Checked = chbAuditAll.Checked;
            chbAuditAllUpdated.Checked = chbAuditAll.Checked;
            chbAuditAllDeleted.Checked = chbAuditAll.Checked;
        }

        private void chbAllColumns_CheckedChanged(object sender, EventArgs e)
        {
            var result = BL.AuditColumns.ChangeAllColumnState(chbAllColumns.Checked);
            if (result)
            {
                ChangeCheckBoxOnGridColumns(1, chbAllColumns, dgvColumns);
                WriteAuditColumnLogGeneral(chbAllColumns.Checked);
            }
        }

        private void WriteAuditColumnLogGeneral(bool isChecked)
        {
            var fs = new FileStream(Application.StartupPath + "\\Logs\\AuditColumnLog.txt", FileMode.Append, FileAccess.Write);
            var sw = new StreamWriter(fs);
            sw.WriteLine("[{0}] - TableName: ALL TABLES - ColumnName: ALLCOLUMNS - OVal: {1} -> NVal: {2}", DateTime.Now.ToString("G"), !isChecked, isChecked);
            sw.Close();
            fs.Close();
        }

        private void rbtnSearchPerson_Click(object sender, EventArgs e)
        {
            SearchUser();
        }

        private void SearchUser()
        {
            if (txtUsername.Text != "")
            {
                CurrentSettings.AuditUser = BL.AuditUsers.FindBy(txtUsername.Text);
                if (CurrentSettings.AuditUser != null && CurrentSettings.AuditUser.Username != null)
                {
                    ShowAuditUserOnUserPage();
                    //_newuser = !auditUsers.CanAccess;

                    MakeReadOnlyUserPage(true, false);
                }
                else
                {
                    MakeReadOnlyUserPage(false, true);
                    _newuser = true;
                    txtName.Focus();
                }
            }
            else MessageBox.Show(@"Ju lutem plotesoni fushen per kerkim");
        }

        private void Reset()
        {

            txtUsername.Text = "";
            txtName.Text = "";
            txtSurname.Text = "";
            txtPassword1.Text = "";
            txtPassword2.Text = "";
            chbAccessAlmisViewer.Checked = false;
            MakeReadOnlyUserPage(true, false);
            _newuser = false;
            CurrentSettings.AuditUser = null;
        }

        private byte[] PasswordHash(string password)
        {
            byte[] source = Encoding.Unicode.GetBytes(password);
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] result = sha.ComputeHash(source);

            return result;
        }

        private void rbtnConfirm_Click(object sender, EventArgs e)
        {

            if (_newuser)
            {
                if (chbAccessAlmisViewer.Checked && !lblPasswordInfo.Visible)
                {
                    CurrentSettings.AuditUser = new BE.AuditUsers
                       {
                           Username = txtUsername.Text,
                           Name = txtName.Text,
                           Surname = txtSurname.Text,
                           Password = PasswordHash(txtPassword1.Text),
                           CanAccess = true
                       };
                    int result = BL.AuditUsers.Inserts(CurrentSettings.AuditUser);
                    if (result > 0)
                    {
                        MessageBox.Show(Resources.userRegisteredMsgBox);
                        dgvAuditUsers.DataSource = null;
                        //var result =
                        LoadAuditUserList();
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show(Resources.userNotRegisteredMsgBox);
                    }

                }
                else
                    MessageBox.Show(Resources.userHasNoRightMsgBox);
            }
            else
            {
                if (CurrentSettings.AuditUser != null)
                {
                    CurrentSettings.AuditUser.Name = txtName.Text;
                    CurrentSettings.AuditUser.Surname = txtSurname.Text;
                    CurrentSettings.AuditUser.CanAccess = chbAccessAlmisViewer.Checked;
                    if (chbChangePassword.Checked)
                        CurrentSettings.AuditUser.Password = PasswordHash(txtPassword1.Text);
                    var result = BL.AuditUsers.Update(CurrentSettings.AuditUser);
                    MessageBox.Show(result > 0
                                        ? "Modifikimi i shfrytezuesit u be me sukses"
                                        : "Modifikimi i shfrytezuesit deshtoi...");
                    LoadAuditUserList();
                    Reset();
                }
            }
            //else
            //{
            //    if (!chbAccessAlmisViewer.Checked && txtName.Text != "")
            //    {
            //        bool result = BL.AuditUsers.Delete(txtUsername.Text);
            //        if (result)
            //        {
            //            MessageBox.Show(Resources.userUnRegisteredMsgBox);
            //            Reset();
            //        }
            //        else
            //        {
            //            MessageBox.Show(Resources.userUnRegisteredFailMsgBox);
            //        }
            //    }
            //}


        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void rrbDateArchive_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ArchiveEnableDisable(rrbIntervalArchive.IsChecked);
            if (rrbDateArchive.IsChecked)
            {
                if (rtpArchiveTime.Value != null)
                    lblArchivedDate.Text =
                        DateTime.Parse(rdtpArchiveDate.Value.ToShortDateString() + " " + rtpArchiveTime.Value.Value.TimeOfDay.ToString())
                            .ToString(CultureInfo.InvariantCulture);
            }

        }

        private void rrbIntervalArchive_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            ArchiveEnableDisable(rrbIntervalArchive.IsChecked);
            if (rrbIntervalArchive.IsChecked)
            {
                ShowArchiveDate();
            }
        }
        void ArchiveEnableDisable(bool archive)
        {
            rdtpArchiveDate.Enabled = !archive;
            rtpArchiveTime.Enabled = !archive;
            rbMonthArchive.Enabled = archive;
            rbYearArchive.Enabled = archive;
            nupArchive.Enabled = archive;
        }

        private void rrbDateDelete_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            DeleteEnableDisable(rrbIntervalDelete.IsChecked);
            if (rrbDateDelete.IsChecked)
            {
                if (rtpTimeDelete.Value != null)
                    lblDeletedDate.Text =
                        DateTime.Parse(rdtpDateDelete.Value.ToShortDateString() + " " + rtpTimeDelete.Value.Value.TimeOfDay)
                            .ToString(CultureInfo.InvariantCulture);
            }
        }

        private void rrbIntervalDelete_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            DeleteEnableDisable(rrbIntervalDelete.IsChecked);
            if (rrbIntervalDelete.IsChecked)
            {
                ShowDeleteDate();
            }
        }

        private void ShowDeleteDate()
        {
            int nup = int.Parse(nudDelete.Value.ToString(CultureInfo.InvariantCulture));
            lblDeletedDate.Text = rbMonthDelete.Checked ? DateTime.Now.AddMonths(-nup).ToString("G") : DateTime.Now.AddYears(-nup).ToString("G");
        }
        void DeleteEnableDisable(bool archive)
        {
            rdtpDateDelete.Enabled = !archive;
            rtpTimeDelete.Enabled = !archive;
            rbMonthDelete.Enabled = archive;
            rbYearDelete.Enabled = archive;
            nudDelete.Enabled = archive;
        }

        private void rdtpArchiveDate_ValueChanged(object sender, EventArgs e)
        {
            if (rtpArchiveTime.Value != null)
                lblArchivedDate.Text =
                    DateTime.Parse(rdtpArchiveDate.Value.ToShortDateString() + " " + rtpArchiveTime.Value.Value.TimeOfDay.ToString())
                            .ToString(CultureInfo.InvariantCulture);
        }

        private void rbtnArchiveAuditLogData_Click(object sender, EventArgs e)
        {

            if (rtpArchiveTime.Value != null)
            {
                var amb = new AlmisMessageBox
                {
                    Caption = Translator.GetText("captionArchiveMsb", this),
                    Message = "A jeni i sigurte se deshironi te arkivoni logun!?",
                    AgreeMessage = "A pajtoheni per arkvimin e logut!?",
                    ShowNoButton = true,
                    ShowAgreeMessage = true
                };
                if (amb.ShowDialog() == DialogResult.Yes)
                {
                    if (amb.IAgree)
                    {
                        DateTime archiveDateTime =
                            DateTime.Parse(rdtpArchiveDate.Value.ToShortDateString() + " " +
                                           rtpArchiveTime.Value.Value.TimeOfDay.ToString());
                        int result = BL.General.ArchiveAuditLog(archiveDateTime);
                        if (result != -999)
                            MessageBox.Show(result > 0 ? Resources.logArchivedMsgBox : Resources.logArchivedFailMsgBox);
                        else
                            MessageBox.Show(@"Nuk ka shenime ne Audit Log per ti arkivuar.");
                    }
                    else
                    {
                        MessageBox.Show(@"First you must check the box to Agree Archiving Log Audit");
                    }

                }
            }
        }

        private void rbtnDeleteAuditLog_Click(object sender, EventArgs e)
        {
            if (rtpTimeDelete.Value != null)
            {
                var amb = new AlmisMessageBox
                    {
                        Caption = "Fshierja e logut nga arkiva",
                        Message = "A jeni i sigurte se deshironi te fshini logun!?",
                        AgreeMessage = "A pajtoheni per fshierjen e logut!?",
                        ShowNoButton = true,
                        ShowAgreeMessage = true
                    };
                if (amb.ShowDialog() == DialogResult.Yes)
                {
                    if (amb.IAgree)
                    {
                        DateTime archiveDateTime = DateTime.Parse(rdtpDateDelete.Value.ToShortDateString() + " " + rtpTimeDelete.Value.Value.TimeOfDay.ToString());
                        int result = BL.General.DeleteAuditLog(archiveDateTime);
                        if (result != -999)
                            MessageBox.Show(result > 0 ? Resources.logDeletedMsgBox : Resources.logDeletedFailMsgBox);
                        else
                            MessageBox.Show(@"Nuk ka shenime ne Audit Log Archive per tu fshire!");
                    }
                }
            }
        }

        private List<BE.AuditTables> GetListFromGridView()
        {
            return (from DataGridViewRow row in dgvTables.Rows
                    select new BE.AuditTables
                        {
                            TableSchema = (string)row.Cells[1].Value,
                            TableName = (string)row.Cells[0].Value,
                            AuditTable = (bool)row.Cells[2].Value,
                            AuditInserts = (bool)row.Cells[3].Value,
                            AuditUpdates = (bool)row.Cells[4].Value,
                            AuditDeletes = (bool)row.Cells[5].Value
                        }).ToList();
        }

        //private void rbtnRemoveAuditTriggers_Click(object sender, EventArgs e)
        //{
        //    for (int i = 0; i < CurrentSettings.RuntimeTableList.Count; i++)
        //    {
        //        if (CurrentSettings.RuntimeTableList[i].AuditInserts == false &&
        //            CurrentSettings.DefaultTableList[i].AuditInserts)
        //        {
        //            BL.AuditTriggers.DeleteTrigger("Tr_" + CurrentSettings.DefaultTableList[i].TableName + "_Ins");

        //        }
        //    }
        //}

        private void radPageView2_SelectedPageChanged(object sender, EventArgs e)
        {

        }

        private void rbtnInstallPrerequirements_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var files =
                Directory.GetFiles(Application.StartupPath + @"\Scripts\");
            var orderedFiles = from f in files orderby f select f;
            foreach (string file in orderedFiles)
            {
                var fs = new FileStream(file, FileMode.Open, FileAccess.Read);
                var sr = new StreamReader(fs);
                var script = sr.ReadToEnd();
                BL.General.InstallPrerequirements(script);
                //if (result) MessageBox.Show("Script: " + file + " successfully installed.");
            }
            CurrentSettings.RuntimeConfigProperties = BL.AuditConfig.FindAll();
            PrepareConfiguration();
            GetAuditTablesAndColumns();
            Cursor.Current = Cursors.Default;
        }

        private void rbtnUninstallAuditing_Click(object sender, EventArgs e)
        {
            var ucb = new AlmisMessageBox
                {
                    Caption = Resources.AlmisMessageBoxCaption,
                    Message = Resources.AlmisMessageBoxMessage,
                    AgreeMessage = Resources.AlmisMessageBoxAgreeMessage,
                    ShowNoButton = true,
                    ShowAgreeMessage = true
                };
            if (ucb.ShowDialog() == DialogResult.Yes)
            {
                if (ucb.IAgree)
                {
                    var result = BL.General.UninstallAuditing();
                    if (result)
                    {
                        MessageBox.Show(Resources.AlmisUninstallingMessageBox);
                        CurrentSettings.RuntimeConfigProperties = BL.AuditConfig.FindAll();
                    }
                    PrepareConfiguration();
                    GetAuditTablesAndColumns();
                }
                else
                {
                    MessageBox.Show(Resources.AlmisUninstallingMessageBoxAgree);
                }

            }
        }

        private void RebuildTriggers(BE.AuditTables auditTables)
        {
            BL.General.RebuildTriggerFor(auditTables.TableSchema, auditTables.TableName, "Ins", auditTables.AuditInserts);

            BL.General.RebuildTriggerFor(auditTables.TableSchema, auditTables.TableName, "Upd", auditTables.AuditUpdates);

            BL.General.RebuildTriggerFor(auditTables.TableSchema, auditTables.TableName, "Del", auditTables.AuditDeletes);
        }
        private void rbtnRebuildAuditTriggers_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (rrbSingelTable.IsChecked)
            {
                var obj = GetListFromGridView().FirstOrDefault(x => x.TableName == rmcbSelectTable.Text);
                if (obj != null)
                    RebuildTriggers(obj);
            }
            if (rrbAllTables.IsChecked)
            {
                foreach (var auditTables in GetListFromGridView())
                {
                    RebuildTriggers(auditTables);
                }
            }
            Cursor.Current = Cursors.Default;
            MessageBox.Show(@"Trigerat u rikonstruan me sukses.");
            //Cursor.Current = Cursors.WaitCursor;
            //CurrentSettings.AuditDatabaseTableList = BL.AuditTables.FindAll();
            //List<BE.AuditTables> query = (from dtl in CurrentSettings.DefaultAuditTableList
            //                              join rtl in CurrentSettings.AuditDatabaseTableList on dtl.TableName equals rtl.TableName
            //                              where dtl.AuditTable != rtl.AuditTable && (dtl.AuditInserts != rtl.AuditInserts ||
            //                                                                         dtl.AuditDeletes != rtl.AuditDeletes ||
            //                                                                         dtl.AuditUpdates != rtl.AuditUpdates)
            //                              select dtl).ToList();

            //var test = new List<BE.AuditTables>();
            //foreach (var auditTablese in CurrentSettings.DefaultAuditTableList)
            //{
            //    var obj = CurrentSettings.AuditDatabaseTableList.FirstOrDefault(x => x.TableName == auditTablese.TableName);
            //    if (obj != null && obj.AuditTable)
            //    {
            //        if (obj.AuditInserts != auditTablese.AuditInserts || obj.AuditUpdates != auditTablese.AuditUpdates
            //            || obj.AuditDeletes != auditTablese.AuditDeletes)
            //        {
            //            test.Add(auditTablese);
            //        }
            //    }
            //}

            //UpdateTables(test);

            //foreach (var auditTablese in test)
            //{
            //    var obj = CurrentSettings.AuditDatabaseTableList.FirstOrDefault(x => x.TableName == auditTablese.TableName);
            //    if (obj != null && auditTablese.AuditTable)
            //    {
            //        if (obj.AuditInserts != auditTablese.AuditInserts && auditTablese.AuditInserts)
            //            BL.General.CreateTriggerFor(auditTablese.TableName, "Ins");
            //        if (obj.AuditInserts != auditTablese.AuditInserts && !auditTablese.AuditInserts)
            //            BL.General.DropTriggerFor(auditTablese.TableName, "Ins");
            //        if (obj.AuditUpdates != auditTablese.AuditUpdates && auditTablese.AuditUpdates)
            //            BL.General.CreateTriggerFor(auditTablese.TableName, "Upd");
            //        if (obj.AuditUpdates != auditTablese.AuditUpdates && !auditTablese.AuditUpdates)
            //            BL.General.DropTriggerFor(auditTablese.TableName, "Upd");
            //        if (obj.AuditDeletes != auditTablese.AuditDeletes && auditTablese.AuditDeletes)
            //            BL.General.CreateTriggerFor(auditTablese.TableName, "Del");
            //        if (obj.AuditDeletes != auditTablese.AuditDeletes && !auditTablese.AuditDeletes)
            //            BL.General.DropTriggerFor(auditTablese.TableName, "Del");
            //    }
            //}
            //Cursor.Current = Cursors.Default;
        }

        //private void UpdateTables(List<BE.AuditTables> tableList)
        //{
        //    foreach (var auditTablese in tableList)
        //    {
        //        var result = BL.AuditTables.Update(auditTablese);

        //    }
        //}

        private void rbtnRestoreToDefault_Click(object sender, EventArgs e)
        {
            dgvTables.DataSource = BL.AuditTables.FindAll();
            Translator.TranslateColumns(dgvTables, this);
        }

        private void rmiDisconnect_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedRowIndex = e.RowIndex;
            int selectedColumnIndex = e.ColumnIndex;
            if (_selectedRowIndex != -1)
            {
                SelectColumnsForTable(_selectedRowIndex);
                SelectTriggersForTable(_selectedRowIndex);
                if (selectedColumnIndex == 2)
                {
                    SelectAllRowCheckBoxes(!(Boolean)dgvTables.Rows[_selectedRowIndex].Cells[2].Value);
                }
                else if (selectedColumnIndex > 2)
                {
                    SelectRowColumnCheckBoxes(_selectedRowIndex, selectedColumnIndex,
                                              !(Boolean)dgvTables.Rows[_selectedRowIndex].Cells[selectedColumnIndex].Value);
                }
            }
        }
        void ChangeCheckBoxOnGridColumns(int index, CheckBox chb, DataGridView rgv)
        {
            for (int i = 0; i < rgv.Rows.Count; i++)
            {
                DataGridViewRow row = rgv.Rows[i];
                row.Cells[index].Value = chb.Checked;
                //SelectRowColumnCheckBoxes(rowIndex, columnIndex, chb.Checked);
            }
            // CurrentSettings.DefaultAuditTableList = GetListFromGridView();
        }
        void SelectAllRowCheckBoxes(bool state)
        {
            dgvTables.Rows[_selectedRowIndex].Cells[2].Value = state;
            dgvTables.Rows[_selectedRowIndex].Cells[3].Value = state;
            dgvTables.Rows[_selectedRowIndex].Cells[4].Value = state;
            dgvTables.Rows[_selectedRowIndex].Cells[5].Value = state;
            dgvTables.RefreshEdit();
        }
        void SelectRowColumnCheckBoxes(int rowIndex, int columnIndex, bool state)
        {
            dgvTables.Rows[rowIndex].Cells[columnIndex].Value = state;
            CheckAuditTableForRow(rowIndex);
            dgvTables.RefreshEdit();
        }

        void CheckAuditTableForRow(int rowIndex)
        {
            if ((Boolean)dgvTables.Rows[rowIndex].Cells[3].Value != true &&
                (Boolean)dgvTables.Rows[rowIndex].Cells[4].Value != true &&
                (Boolean)dgvTables.Rows[rowIndex].Cells[5].Value != true)
            {
                dgvTables.Rows[rowIndex].Cells[2].Value = false;
            }
            else dgvTables.Rows[rowIndex].Cells[2].Value = true;
        }

        private void dgvColumns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
                if (e.ColumnIndex == 1)
                {
                    var columns = new BE.AuditColumns { ColumnName = dgvColumns.Rows[i].Cells[0].Value.ToString() };
                    //                    rgvColumns.Rows[i].Cells[1].Value = !(Boolean)rgvColumns.Rows[i].Cells[1].Value;
                    //columns.AuditColumn = !(Boolean)rgvColumns.Rows[i].Cells[1].Value;
                    string tableName = dgvTables.Rows[_selectedRowIndex].Cells[0].Value.ToString();
                    string tableSchema = dgvTables.Rows[_selectedRowIndex].Cells[1].Value.ToString();
                    var result = BL.AuditColumns.ChangeColumnState(columns, tableName, tableSchema);
                    //if (result)
                    dgvColumns.Rows[i].Cells[1].Value = result; // !(Boolean)dgvColumns.Rows[i].Cells[1].Value;
                    dgvColumns.RefreshEdit();
                    WriteApplicationLogsForAuditColumn(tableName, columns.ColumnName, result);
                }
        }

        private void WriteApplicationLogsForAuditColumn(string tableName, string columnName, bool isAudit)
        {
            var fs = new FileStream(Application.StartupPath + "\\Logs\\AuditColumnLog.txt", FileMode.Append, FileAccess.Write);
            var sw = new StreamWriter(fs);
            sw.WriteLine("[{0}] - TableName: {1} - ColumnName: {2} - OVal: {3} -> NVal: {4} - User: {5}", DateTime.Now.ToString("G"), tableName, columnName, !isAudit, isAudit, CurrentSettings.UseriAktiv);
            sw.Close();
            fs.Close();
        }

        private void dgvTriggers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i != -1)
                if (e.ColumnIndex == 3)
                {
                    var triggers = new BE.AuditTriggers();
                    dgvTriggers.Rows[i].Cells[3].Value = !(Boolean)dgvTriggers.Rows[i].Cells[3].Value;
                    triggers.TableSchema = dgvTriggers.Rows[i].Cells[0].Value.ToString();
                    triggers.TableName = dgvTriggers.Rows[i].Cells[1].Value.ToString();
                    triggers.TriggerName = dgvTriggers.Rows[i].Cells[2].Value.ToString();
                    triggers.Disabled = (Boolean)dgvTriggers.Rows[i].Cells[3].Value;
                    BL.AuditTriggers.ChangeTriggersStatus(triggers);
                    WriteLogsForAuditTriggers(triggers.TableName, triggers.TriggerName, triggers.Disabled);
                }
        }

        private void WriteLogsForAuditTriggers(string tableName, string triggerName, bool isDisabled)
        {
            var fs = new FileStream(Application.StartupPath + "\\Logs\\AuditTriggersLog.txt", FileMode.Append, FileAccess.Write);
            var sw = new StreamWriter(fs);
            sw.WriteLine("[{0}] - TableName: {1} - TriggerName: {2} - OVal: {3} -> NVal: {4} - User: {5}", DateTime.Now.ToString("G"), tableName, triggerName, !isDisabled, isDisabled, CurrentSettings.UseriAktiv);
            sw.Close();
            fs.Close();
        }

        private void rmiAbout_Click(object sender, EventArgs e)
        {
            //var about = new AboutAlmisManager();
            //about.Show();
        }

        private void rmcbSelectTable_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            rrbSingelTable.IsChecked = true;
        }

        private void rmcbSelectTable_Click(object sender, EventArgs e)
        {
            rrbSingelTable.IsChecked = true;
        }

        private void rbtnEdit_Click(object sender, EventArgs e)
        {
            if (!_newuser)
                MakeReadOnlyUserPage(false, false);
        }

        private void MakeReadOnlyUserPage(bool state, bool password)
        {
            txtName.ReadOnly = state;
            txtSurname.ReadOnly = state;
            chbChangePassword.Checked = password;
            //txtPassword1.ReadOnly = state;
            //txtPassword2.ReadOnly = state;
            chbAccessAlmisViewer.Enabled = !state;
        }

        private void rbtnDelete_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "")
            {
                var user = txtUsername.Text.Trim();
                var result = BL.AuditUsers.Delete(user);
                MessageBox.Show(result ? "Shfrytezuesi u fshi me sukses" : "Deshtoi te fshihet shfrytezuesi");
                LoadAuditUserList();
                Reset();
            }
        }

        private void LoadAuditUserList()
        {
            dgvAuditUsers.DataSource = BL.AuditUsers.FindAll();
            dgvAuditUsers.RefreshEdit();
        }

        private void chbChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword1.ReadOnly = !chbChangePassword.Checked;
            txtPassword2.ReadOnly = !chbChangePassword.Checked;
        }

        private void dgvTables_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (_selectedRowIndex > 0)
                    _selectedRowIndex--;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (_selectedRowIndex < dgvTables.RowCount)
                    _selectedRowIndex++;
            }
            try
            {
                SelectColumnsForTable(_selectedRowIndex);
                SelectTriggersForTable(_selectedRowIndex);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                //nothing happens here
            }
        }

        private void dgvAuditUsers_DoubleClick(object sender, EventArgs e)
        {
            string username = dgvAuditUsers.Rows[_userRowSelected].Cells[0].Value.ToString();
            CurrentSettings.AuditUser = BL.AuditUsers.FindBy(username);
            ShowAuditUserOnUserPage();
        }


        private void ShowAuditUserOnUserPage()
        {
            if (CurrentSettings.AuditUser != null)
            {
                txtName.Text = CurrentSettings.AuditUser.Name;
                txtSurname.Text = CurrentSettings.AuditUser.Surname;
                txtUsername.Text = CurrentSettings.AuditUser.Username;
                chbAccessAlmisViewer.Checked = CurrentSettings.AuditUser.CanAccess;
            }
        }
        private int _userRowSelected;
        private void dgvAuditUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                _userRowSelected = e.RowIndex;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                SearchUser();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SearchUser();
        }

        private void nupArchive_ValueChanged(object sender, EventArgs e)
        {
            ShowArchiveDate();
        }

        void ShowArchiveDate()
        {
            int nup = int.Parse(nupArchive.Value.ToString(CultureInfo.InvariantCulture));
            lblArchivedDate.Text = rbMonthArchive.Checked ? DateTime.Now.AddMonths(-nup).ToString("G") : DateTime.Now.AddYears(-nup).ToString("G");
        }
        private void rbYearArchive_CheckedChanged(object sender, EventArgs e)
        {
            ShowArchiveDate();
        }

        private void rbMonthArchive_CheckedChanged(object sender, EventArgs e)
        {
            ShowArchiveDate();
        }

        private void rbMonthDelete_CheckedChanged(object sender, EventArgs e)
        {
            ShowDeleteDate();
        }

        private void rbYearDelete_CheckedChanged(object sender, EventArgs e)
        {
            ShowDeleteDate();
        }

        private void nudDelete_ValueChanged(object sender, EventArgs e)
        {
            ShowDeleteDate();
        }
    }
}

