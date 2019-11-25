using Telerik.WinControls.Enumerations;

namespace ALMIS.Viewer
{
    partial class AlmisViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlmisViewer));
            Telerik.WinControls.Keyboard.InputBinding inputBinding1 = new Telerik.WinControls.Keyboard.InputBinding();
            Telerik.WinControls.Keyboard.Chord chord1 = new Telerik.WinControls.Keyboard.Chord();
            Telerik.WinControls.Keyboard.ChordModifier chordModifier1 = new Telerik.WinControls.Keyboard.ChordModifier();
            Telerik.WinControls.Elements.ClickCommand clickCommand1 = new Telerik.WinControls.Elements.ClickCommand();
            Telerik.WinControls.Keyboard.InputBinding inputBinding2 = new Telerik.WinControls.Keyboard.InputBinding();
            Telerik.WinControls.Keyboard.Chord chord2 = new Telerik.WinControls.Keyboard.Chord();
            Telerik.WinControls.Keyboard.ChordModifier chordModifier2 = new Telerik.WinControls.Keyboard.ChordModifier();
            Telerik.WinControls.Keyboard.InputBinding inputBinding3 = new Telerik.WinControls.Keyboard.InputBinding();
            Telerik.WinControls.Keyboard.Chord chord3 = new Telerik.WinControls.Keyboard.Chord();
            Telerik.WinControls.Keyboard.ChordModifier chordModifier3 = new Telerik.WinControls.Keyboard.ChordModifier();
            Telerik.WinControls.Keyboard.InputBinding inputBinding4 = new Telerik.WinControls.Keyboard.InputBinding();
            Telerik.WinControls.Keyboard.Chord chord4 = new Telerik.WinControls.Keyboard.Chord();
            Telerik.WinControls.Keyboard.ChordModifier chordModifier4 = new Telerik.WinControls.Keyboard.ChordModifier();
            this.rmiLogOff = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiExit = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiContents = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiFile = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiHelp = new Telerik.WinControls.UI.RadMenuItem();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.rbtnExportToCsv = new Telerik.WinControls.UI.RadButton();
            this.btnPrintPriview = new Telerik.WinControls.UI.RadButton();
            this.btnExcel = new Telerik.WinControls.UI.RadButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnFind = new Telerik.WinControls.UI.RadButton();
            this.gbLogEntryLimit = new System.Windows.Forms.GroupBox();
            this.nupMaxEntries = new System.Windows.Forms.NumericUpDown();
            this.txtLogEntries = new System.Windows.Forms.TextBox();
            this.lblMaximumEntries = new System.Windows.Forms.Label();
            this.lblLogEntries = new System.Windows.Forms.Label();
            this.gbEvent = new System.Windows.Forms.GroupBox();
            this.chbDelete = new System.Windows.Forms.CheckBox();
            this.chbUpdate = new System.Windows.Forms.CheckBox();
            this.chbInsert = new System.Windows.Forms.CheckBox();
            this.gbDateTimeRange = new System.Windows.Forms.GroupBox();
            this.btnMoreDateTimeFilters = new System.Windows.Forms.Button();
            this.chbOccuredBefore = new System.Windows.Forms.CheckBox();
            this.chbOccuredAfter = new System.Windows.Forms.CheckBox();
            this.rtpOccuredBefore = new Telerik.WinControls.UI.RadTimePicker();
            this.rtpOccuredAfter = new Telerik.WinControls.UI.RadTimePicker();
            this.rdtpOccuredBefore = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdtpOccuredAfter = new Telerik.WinControls.UI.RadDateTimePicker();
            this.gbRowKey = new System.Windows.Forms.GroupBox();
            this.btnRowKeyList = new System.Windows.Forms.Button();
            this.cbRowKey = new System.Windows.Forms.ComboBox();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.btnApplicationList = new System.Windows.Forms.Button();
            this.btnWorkstationList = new System.Windows.Forms.Button();
            this.btnUserNameList = new System.Windows.Forms.Button();
            this.btnColumnList = new System.Windows.Forms.Button();
            this.btnTableList = new System.Windows.Forms.Button();
            this.cbApplication = new System.Windows.Forms.ComboBox();
            this.cbWorkstation = new System.Windows.Forms.ComboBox();
            this.cbUserName = new System.Windows.Forms.ComboBox();
            this.cbColumn = new System.Windows.Forms.ComboBox();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.lblApplication = new System.Windows.Forms.Label();
            this.lblWorkstation = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblColumn = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.officeShape1 = new Telerik.WinControls.UI.OfficeShape();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.splitPanel3 = new Telerik.WinControls.UI.SplitPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.txtOldValue = new System.Windows.Forms.TextBox();
            this.txtNewValue = new System.Windows.Forms.TextBox();
            this.lblOldValue = new System.Windows.Forms.Label();
            this.lblNewValue = new System.Windows.Forms.Label();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.txtRowKey = new System.Windows.Forms.TextBox();
            this.lblRowKey = new System.Windows.Forms.Label();
            this.txtApplication = new System.Windows.Forms.TextBox();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtAuditID = new System.Windows.Forms.TextBox();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblHostname = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblColumnName = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblAuditID = new System.Windows.Forms.Label();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnExportToCsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintPriview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).BeginInit();
            this.gbLogEntryLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxEntries)).BeginInit();
            this.gbEvent.SuspendLayout();
            this.gbDateTimeRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtpOccuredBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpOccuredAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpOccuredBefore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpOccuredAfter)).BeginInit();
            this.gbRowKey.SuspendLayout();
            this.gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).BeginInit();
            this.splitPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rmiLogOff
            // 
            this.rmiLogOff.AccessibleDescription = "Disconnect";
            resources.ApplyResources(this.rmiLogOff, "rmiLogOff");
            this.rmiLogOff.Name = "rmiLogOff";
            this.rmiLogOff.Click += new System.EventHandler(this.rmiDisconnect_Click);
            // 
            // rmiExit
            // 
            this.rmiExit.AccessibleDescription = "Exit";
            resources.ApplyResources(this.rmiExit, "rmiExit");
            this.rmiExit.Name = "rmiExit";
            this.rmiExit.Click += new System.EventHandler(this.rmiExit_Click);
            // 
            // rmiContents
            // 
            this.rmiContents.AccessibleDescription = "Contents";
            resources.ApplyResources(this.rmiContents, "rmiContents");
            this.rmiContents.Name = "rmiContents";
            this.rmiContents.Click += new System.EventHandler(this.rmiContents_Click);
            // 
            // rmiAbout
            // 
            this.rmiAbout.AccessibleDescription = "About";
            resources.ApplyResources(this.rmiAbout, "rmiAbout");
            this.rmiAbout.Name = "rmiAbout";
            this.rmiAbout.Click += new System.EventHandler(this.rmiAbout_Click);
            // 
            // rmiFile
            // 
            this.rmiFile.AccessibleDescription = "File";
            resources.ApplyResources(this.rmiFile, "rmiFile");
            this.rmiFile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiLogOff,
            this.rmiExit});
            this.rmiFile.Name = "rmiFile";
            // 
            // rmiHelp
            // 
            this.rmiHelp.AccessibleDescription = "Help";
            resources.ApplyResources(this.rmiHelp, "rmiHelp");
            this.rmiHelp.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiContents,
            this.rmiAbout});
            this.rmiHelp.Name = "rmiHelp";
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Controls.Add(this.splitPanel3);
            resources.ApplyResources(this.radSplitContainer1, "radSplitContainer1");
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.AccessibleDescription = null;
            this.radSplitContainer1.RootElement.AccessibleName = null;
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.TabStop = false;
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.radButton1);
            this.splitPanel1.Controls.Add(this.rbtnExportToCsv);
            this.splitPanel1.Controls.Add(this.btnPrintPriview);
            this.splitPanel1.Controls.Add(this.btnExcel);
            this.splitPanel1.Controls.Add(this.lblResult);
            this.splitPanel1.Controls.Add(this.btnFind);
            this.splitPanel1.Controls.Add(this.gbLogEntryLimit);
            this.splitPanel1.Controls.Add(this.gbEvent);
            this.splitPanel1.Controls.Add(this.gbDateTimeRange);
            this.splitPanel1.Controls.Add(this.gbRowKey);
            this.splitPanel1.Controls.Add(this.gbFilters);
            resources.ApplyResources(this.splitPanel1, "splitPanel1");
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.AccessibleDescription = null;
            this.splitPanel1.RootElement.AccessibleName = null;
            this.splitPanel1.RootElement.ApplyShapeToControl = true;
            this.splitPanel1.RootElement.ClickMode = Telerik.WinControls.ClickMode.Release;
            this.splitPanel1.RootElement.ClipDrawing = false;
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.RootElement.Shape = this.officeShape1;
            this.splitPanel1.RootElement.ShouldPaint = true;
            this.splitPanel1.RootElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.02949361F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -32);
            this.splitPanel1.TabStop = false;
            ((Telerik.WinControls.UI.SplitPanelElement)(this.splitPanel1.GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            ((Telerik.WinControls.UI.SplitPanelElement)(this.splitPanel1.GetChildAt(0))).ShouldPaint = true;
            ((Telerik.WinControls.UI.SplitPanelElement)(this.splitPanel1.GetChildAt(0))).Shape = this.officeShape1;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.splitPanel1.GetChildAt(0).GetChildAt(0))).Shape = this.officeShape1;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.splitPanel1.GetChildAt(0).GetChildAt(1))).Shape = this.officeShape1;
            // 
            // radButton1
            // 
            resources.ApplyResources(this.radButton1, "radButton1");
            this.radButton1.Name = "radButton1";
            // 
            // 
            // 
            this.radButton1.RootElement.AccessibleDescription = null;
            this.radButton1.RootElement.AccessibleName = null;
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // rbtnExportToCsv
            // 
            resources.ApplyResources(this.rbtnExportToCsv, "rbtnExportToCsv");
            this.rbtnExportToCsv.Name = "rbtnExportToCsv";
            // 
            // 
            // 
            this.rbtnExportToCsv.RootElement.AccessibleDescription = null;
            this.rbtnExportToCsv.RootElement.AccessibleName = null;
            this.rbtnExportToCsv.Click += new System.EventHandler(this.rbtnExportToCsv_Click);
            // 
            // btnPrintPriview
            // 
            resources.ApplyResources(this.btnPrintPriview, "btnPrintPriview");
            this.btnPrintPriview.Name = "btnPrintPriview";
            // 
            // 
            // 
            this.btnPrintPriview.RootElement.AccessibleDescription = null;
            this.btnPrintPriview.RootElement.AccessibleName = null;
            this.btnPrintPriview.Click += new System.EventHandler(this.btnPrintPriview_Click);
            // 
            // btnExcel
            // 
            resources.ApplyResources(this.btnExcel, "btnExcel");
            this.btnExcel.Name = "btnExcel";
            // 
            // 
            // 
            this.btnExcel.RootElement.AccessibleDescription = null;
            this.btnExcel.RootElement.AccessibleName = null;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblResult
            // 
            resources.ApplyResources(this.lblResult, "lblResult");
            this.lblResult.Name = "lblResult";
            // 
            // btnFind
            // 
            resources.ApplyResources(this.btnFind, "btnFind");
            this.btnFind.Name = "btnFind";
            // 
            // 
            // 
            this.btnFind.RootElement.AccessibleDescription = null;
            this.btnFind.RootElement.AccessibleName = null;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // gbLogEntryLimit
            // 
            this.gbLogEntryLimit.Controls.Add(this.nupMaxEntries);
            this.gbLogEntryLimit.Controls.Add(this.txtLogEntries);
            this.gbLogEntryLimit.Controls.Add(this.lblMaximumEntries);
            this.gbLogEntryLimit.Controls.Add(this.lblLogEntries);
            resources.ApplyResources(this.gbLogEntryLimit, "gbLogEntryLimit");
            this.gbLogEntryLimit.Name = "gbLogEntryLimit";
            this.gbLogEntryLimit.TabStop = false;
            // 
            // nupMaxEntries
            // 
            resources.ApplyResources(this.nupMaxEntries, "nupMaxEntries");
            this.nupMaxEntries.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nupMaxEntries.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupMaxEntries.Name = "nupMaxEntries";
            this.nupMaxEntries.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nupMaxEntries.ValueChanged += new System.EventHandler(this.nupMaxEntries_ValueChanged);
            this.nupMaxEntries.Click += new System.EventHandler(this.nupMaxEntries_Click);
            // 
            // txtLogEntries
            // 
            resources.ApplyResources(this.txtLogEntries, "txtLogEntries");
            this.txtLogEntries.Name = "txtLogEntries";
            this.txtLogEntries.ReadOnly = true;
            // 
            // lblMaximumEntries
            // 
            resources.ApplyResources(this.lblMaximumEntries, "lblMaximumEntries");
            this.lblMaximumEntries.Name = "lblMaximumEntries";
            // 
            // lblLogEntries
            // 
            resources.ApplyResources(this.lblLogEntries, "lblLogEntries");
            this.lblLogEntries.Name = "lblLogEntries";
            // 
            // gbEvent
            // 
            this.gbEvent.Controls.Add(this.chbDelete);
            this.gbEvent.Controls.Add(this.chbUpdate);
            this.gbEvent.Controls.Add(this.chbInsert);
            resources.ApplyResources(this.gbEvent, "gbEvent");
            this.gbEvent.Name = "gbEvent";
            this.gbEvent.TabStop = false;
            // 
            // chbDelete
            // 
            resources.ApplyResources(this.chbDelete, "chbDelete");
            this.chbDelete.Checked = true;
            this.chbDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDelete.Name = "chbDelete";
            this.chbDelete.UseVisualStyleBackColor = true;
            this.chbDelete.CheckedChanged += new System.EventHandler(this.chbDelete_CheckedChanged);
            // 
            // chbUpdate
            // 
            resources.ApplyResources(this.chbUpdate, "chbUpdate");
            this.chbUpdate.Checked = true;
            this.chbUpdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbUpdate.Name = "chbUpdate";
            this.chbUpdate.UseVisualStyleBackColor = true;
            this.chbUpdate.CheckedChanged += new System.EventHandler(this.chbUpdate_CheckedChanged);
            // 
            // chbInsert
            // 
            resources.ApplyResources(this.chbInsert, "chbInsert");
            this.chbInsert.Checked = true;
            this.chbInsert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbInsert.Name = "chbInsert";
            this.chbInsert.UseVisualStyleBackColor = true;
            this.chbInsert.CheckedChanged += new System.EventHandler(this.chbInsert_CheckedChanged);
            // 
            // gbDateTimeRange
            // 
            this.gbDateTimeRange.Controls.Add(this.btnMoreDateTimeFilters);
            this.gbDateTimeRange.Controls.Add(this.chbOccuredBefore);
            this.gbDateTimeRange.Controls.Add(this.chbOccuredAfter);
            this.gbDateTimeRange.Controls.Add(this.rtpOccuredBefore);
            this.gbDateTimeRange.Controls.Add(this.rtpOccuredAfter);
            this.gbDateTimeRange.Controls.Add(this.rdtpOccuredBefore);
            this.gbDateTimeRange.Controls.Add(this.rdtpOccuredAfter);
            resources.ApplyResources(this.gbDateTimeRange, "gbDateTimeRange");
            this.gbDateTimeRange.Name = "gbDateTimeRange";
            this.gbDateTimeRange.TabStop = false;
            // 
            // btnMoreDateTimeFilters
            // 
            resources.ApplyResources(this.btnMoreDateTimeFilters, "btnMoreDateTimeFilters");
            this.btnMoreDateTimeFilters.Name = "btnMoreDateTimeFilters";
            this.btnMoreDateTimeFilters.Tag = "More DateTime Filters";
            this.btnMoreDateTimeFilters.UseVisualStyleBackColor = true;
            this.btnMoreDateTimeFilters.Click += new System.EventHandler(this.btnMoreDateTimeFilters_Click);
            // 
            // chbOccuredBefore
            // 
            resources.ApplyResources(this.chbOccuredBefore, "chbOccuredBefore");
            this.chbOccuredBefore.Name = "chbOccuredBefore";
            this.chbOccuredBefore.UseVisualStyleBackColor = true;
            this.chbOccuredBefore.CheckedChanged += new System.EventHandler(this.chbOccuredBefore_CheckedChanged);
            // 
            // chbOccuredAfter
            // 
            resources.ApplyResources(this.chbOccuredAfter, "chbOccuredAfter");
            this.chbOccuredAfter.Name = "chbOccuredAfter";
            this.chbOccuredAfter.UseVisualStyleBackColor = true;
            this.chbOccuredAfter.CheckedChanged += new System.EventHandler(this.chbOccuredAfter_CheckedChanged);
            // 
            // rtpOccuredBefore
            // 
            resources.ApplyResources(this.rtpOccuredBefore, "rtpOccuredBefore");
            this.rtpOccuredBefore.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.rtpOccuredBefore.MinValue = new System.DateTime(((long)(0)));
            this.rtpOccuredBefore.Name = "rtpOccuredBefore";
            this.rtpOccuredBefore.ReadOnly = true;
            // 
            // 
            // 
            this.rtpOccuredBefore.RootElement.AccessibleDescription = null;
            this.rtpOccuredBefore.RootElement.AccessibleName = null;
            this.rtpOccuredBefore.TabStop = false;
            this.rtpOccuredBefore.Value = new System.DateTime(2013, 5, 14, 22, 46, 26, 0);
            this.rtpOccuredBefore.Click += new System.EventHandler(this.rtpOccuredBefore_Click);
            // 
            // rtpOccuredAfter
            // 
            resources.ApplyResources(this.rtpOccuredAfter, "rtpOccuredAfter");
            this.rtpOccuredAfter.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.rtpOccuredAfter.MinValue = new System.DateTime(((long)(0)));
            this.rtpOccuredAfter.Name = "rtpOccuredAfter";
            this.rtpOccuredAfter.ReadOnly = true;
            // 
            // 
            // 
            this.rtpOccuredAfter.RootElement.AccessibleDescription = null;
            this.rtpOccuredAfter.RootElement.AccessibleName = null;
            this.rtpOccuredAfter.TabStop = false;
            this.rtpOccuredAfter.Value = new System.DateTime(2013, 5, 14, 22, 46, 26, 0);
            this.rtpOccuredAfter.Click += new System.EventHandler(this.rtpOccuredAfter_Click);
            // 
            // rdtpOccuredBefore
            // 
            this.rdtpOccuredBefore.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.rdtpOccuredBefore, "rdtpOccuredBefore");
            this.rdtpOccuredBefore.Name = "rdtpOccuredBefore";
            this.rdtpOccuredBefore.ReadOnly = true;
            // 
            // 
            // 
            this.rdtpOccuredBefore.RootElement.AccessibleDescription = null;
            this.rdtpOccuredBefore.RootElement.AccessibleName = null;
            this.rdtpOccuredBefore.TabStop = false;
            this.rdtpOccuredBefore.Value = new System.DateTime(2013, 5, 14, 22, 46, 12, 400);
            this.rdtpOccuredBefore.ValueChanged += new System.EventHandler(this.rdtpOccuredBefore_ValueChanged);
            // 
            // rdtpOccuredAfter
            // 
            this.rdtpOccuredAfter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.rdtpOccuredAfter, "rdtpOccuredAfter");
            this.rdtpOccuredAfter.Name = "rdtpOccuredAfter";
            this.rdtpOccuredAfter.ReadOnly = true;
            // 
            // 
            // 
            this.rdtpOccuredAfter.RootElement.AccessibleDescription = null;
            this.rdtpOccuredAfter.RootElement.AccessibleName = null;
            this.rdtpOccuredAfter.TabStop = false;
            this.rdtpOccuredAfter.Value = new System.DateTime(2013, 5, 14, 22, 46, 12, 400);
            this.rdtpOccuredAfter.ValueChanged += new System.EventHandler(this.rdtpOccuredAfter_ValueChanged);
            // 
            // gbRowKey
            // 
            this.gbRowKey.Controls.Add(this.btnRowKeyList);
            this.gbRowKey.Controls.Add(this.cbRowKey);
            resources.ApplyResources(this.gbRowKey, "gbRowKey");
            this.gbRowKey.Name = "gbRowKey";
            this.gbRowKey.TabStop = false;
            // 
            // btnRowKeyList
            // 
            resources.ApplyResources(this.btnRowKeyList, "btnRowKeyList");
            this.btnRowKeyList.Name = "btnRowKeyList";
            this.btnRowKeyList.UseVisualStyleBackColor = true;
            this.btnRowKeyList.Click += new System.EventHandler(this.btnRowKeyList_Click);
            // 
            // cbRowKey
            // 
            this.cbRowKey.FormattingEnabled = true;
            resources.ApplyResources(this.cbRowKey, "cbRowKey");
            this.cbRowKey.Name = "cbRowKey";
            this.cbRowKey.Click += new System.EventHandler(this.cbRowKey_Click);
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnApplicationList);
            this.gbFilters.Controls.Add(this.btnWorkstationList);
            this.gbFilters.Controls.Add(this.btnUserNameList);
            this.gbFilters.Controls.Add(this.btnColumnList);
            this.gbFilters.Controls.Add(this.btnTableList);
            this.gbFilters.Controls.Add(this.cbApplication);
            this.gbFilters.Controls.Add(this.cbWorkstation);
            this.gbFilters.Controls.Add(this.cbUserName);
            this.gbFilters.Controls.Add(this.cbColumn);
            this.gbFilters.Controls.Add(this.cbTable);
            this.gbFilters.Controls.Add(this.lblApplication);
            this.gbFilters.Controls.Add(this.lblWorkstation);
            this.gbFilters.Controls.Add(this.lblUserName);
            this.gbFilters.Controls.Add(this.lblColumn);
            this.gbFilters.Controls.Add(this.lblTable);
            resources.ApplyResources(this.gbFilters, "gbFilters");
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.TabStop = false;
            // 
            // btnApplicationList
            // 
            resources.ApplyResources(this.btnApplicationList, "btnApplicationList");
            this.btnApplicationList.Name = "btnApplicationList";
            this.btnApplicationList.UseVisualStyleBackColor = true;
            this.btnApplicationList.Click += new System.EventHandler(this.btnApplicationList_Click);
            // 
            // btnWorkstationList
            // 
            resources.ApplyResources(this.btnWorkstationList, "btnWorkstationList");
            this.btnWorkstationList.Name = "btnWorkstationList";
            this.btnWorkstationList.UseVisualStyleBackColor = true;
            this.btnWorkstationList.Click += new System.EventHandler(this.btnWorkstationList_Click);
            // 
            // btnUserNameList
            // 
            resources.ApplyResources(this.btnUserNameList, "btnUserNameList");
            this.btnUserNameList.Name = "btnUserNameList";
            this.btnUserNameList.UseVisualStyleBackColor = true;
            this.btnUserNameList.Click += new System.EventHandler(this.btnUserNameList_Click);
            // 
            // btnColumnList
            // 
            resources.ApplyResources(this.btnColumnList, "btnColumnList");
            this.btnColumnList.Name = "btnColumnList";
            this.btnColumnList.UseVisualStyleBackColor = true;
            this.btnColumnList.Click += new System.EventHandler(this.btnListColumns_Click);
            // 
            // btnTableList
            // 
            resources.ApplyResources(this.btnTableList, "btnTableList");
            this.btnTableList.Name = "btnTableList";
            this.btnTableList.UseVisualStyleBackColor = true;
            this.btnTableList.Click += new System.EventHandler(this.btnListTables_Click);
            // 
            // cbApplication
            // 
            this.cbApplication.FormattingEnabled = true;
            resources.ApplyResources(this.cbApplication, "cbApplication");
            this.cbApplication.Name = "cbApplication";
            this.cbApplication.Click += new System.EventHandler(this.cbApplication_Click);
            // 
            // cbWorkstation
            // 
            this.cbWorkstation.FormattingEnabled = true;
            resources.ApplyResources(this.cbWorkstation, "cbWorkstation");
            this.cbWorkstation.Name = "cbWorkstation";
            this.cbWorkstation.Click += new System.EventHandler(this.cbWorkstation_Click);
            // 
            // cbUserName
            // 
            this.cbUserName.FormattingEnabled = true;
            resources.ApplyResources(this.cbUserName, "cbUserName");
            this.cbUserName.Name = "cbUserName";
            this.cbUserName.Click += new System.EventHandler(this.cbUserName_Click);
            // 
            // cbColumn
            // 
            this.cbColumn.FormattingEnabled = true;
            resources.ApplyResources(this.cbColumn, "cbColumn");
            this.cbColumn.Name = "cbColumn";
            this.cbColumn.Click += new System.EventHandler(this.cbColumn_Click);
            // 
            // cbTable
            // 
            this.cbTable.BackColor = System.Drawing.SystemColors.Window;
            this.cbTable.FormattingEnabled = true;
            resources.ApplyResources(this.cbTable, "cbTable");
            this.cbTable.Name = "cbTable";
            this.cbTable.Click += new System.EventHandler(this.cbTable_Click);
            // 
            // lblApplication
            // 
            resources.ApplyResources(this.lblApplication, "lblApplication");
            this.lblApplication.Name = "lblApplication";
            // 
            // lblWorkstation
            // 
            resources.ApplyResources(this.lblWorkstation, "lblWorkstation");
            this.lblWorkstation.Name = "lblWorkstation";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // lblColumn
            // 
            resources.ApplyResources(this.lblColumn, "lblColumn");
            this.lblColumn.Name = "lblColumn";
            // 
            // lblTable
            // 
            resources.ApplyResources(this.lblTable, "lblTable");
            this.lblTable.Name = "lblTable";
            // 
            // officeShape1
            // 
            this.officeShape1.IsRightToLeft = false;
            this.officeShape1.RoundedBottom = true;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.dgvReports);
            resources.ApplyResources(this.splitPanel2, "splitPanel2");
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.AccessibleDescription = null;
            this.splitPanel2.RootElement.AccessibleName = null;
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, 0.1741792F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, 103);
            this.splitPanel2.TabStop = false;
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvReports, "dgvReports");
            this.dgvReports.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditLog_CellClick);
            this.dgvReports.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAuditLog_KeyDown);
            // 
            // splitPanel3
            // 
            this.splitPanel3.Controls.Add(this.radPanel2);
            this.splitPanel3.Controls.Add(this.radPanel1);
            resources.ApplyResources(this.splitPanel3, "splitPanel3");
            this.splitPanel3.Name = "splitPanel3";
            // 
            // 
            // 
            this.splitPanel3.RootElement.AccessibleDescription = null;
            this.splitPanel3.RootElement.AccessibleName = null;
            this.splitPanel3.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel3.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0F, -0.1446856F);
            this.splitPanel3.SizeInfo.SplitterCorrection = new System.Drawing.Size(0, -71);
            this.splitPanel3.TabStop = false;
            // 
            // radPanel2
            // 
            resources.ApplyResources(this.radPanel2, "radPanel2");
            this.radPanel2.Controls.Add(this.txtOldValue);
            this.radPanel2.Controls.Add(this.txtNewValue);
            this.radPanel2.Controls.Add(this.lblOldValue);
            this.radPanel2.Controls.Add(this.lblNewValue);
            this.radPanel2.Name = "radPanel2";
            // 
            // 
            // 
            this.radPanel2.RootElement.AccessibleDescription = null;
            this.radPanel2.RootElement.AccessibleName = null;
            // 
            // txtOldValue
            // 
            resources.ApplyResources(this.txtOldValue, "txtOldValue");
            this.txtOldValue.Name = "txtOldValue";
            this.txtOldValue.ReadOnly = true;
            this.txtOldValue.Click += new System.EventHandler(this.txtOldValue_Click);
            // 
            // txtNewValue
            // 
            resources.ApplyResources(this.txtNewValue, "txtNewValue");
            this.txtNewValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewValue.Name = "txtNewValue";
            this.txtNewValue.ReadOnly = true;
            this.txtNewValue.Click += new System.EventHandler(this.txtNewValue_Click);
            // 
            // lblOldValue
            // 
            resources.ApplyResources(this.lblOldValue, "lblOldValue");
            this.lblOldValue.Name = "lblOldValue";
            // 
            // lblNewValue
            // 
            resources.ApplyResources(this.lblNewValue, "lblNewValue");
            this.lblNewValue.Name = "lblNewValue";
            // 
            // radPanel1
            // 
            resources.ApplyResources(this.radPanel1, "radPanel1");
            this.radPanel1.Controls.Add(this.txtRowKey);
            this.radPanel1.Controls.Add(this.lblRowKey);
            this.radPanel1.Controls.Add(this.txtApplication);
            this.radPanel1.Controls.Add(this.txtHostname);
            this.radPanel1.Controls.Add(this.txtUserName);
            this.radPanel1.Controls.Add(this.txtColumnName);
            this.radPanel1.Controls.Add(this.txtTableName);
            this.radPanel1.Controls.Add(this.txtEvent);
            this.radPanel1.Controls.Add(this.txtDateTime);
            this.radPanel1.Controls.Add(this.txtAuditID);
            this.radPanel1.Controls.Add(this.lblApp);
            this.radPanel1.Controls.Add(this.lblHostname);
            this.radPanel1.Controls.Add(this.lblUser);
            this.radPanel1.Controls.Add(this.lblColumnName);
            this.radPanel1.Controls.Add(this.lblTableName);
            this.radPanel1.Controls.Add(this.lblEvent);
            this.radPanel1.Controls.Add(this.lblDateTime);
            this.radPanel1.Controls.Add(this.lblAuditID);
            this.radPanel1.Name = "radPanel1";
            // 
            // 
            // 
            this.radPanel1.RootElement.AccessibleDescription = null;
            this.radPanel1.RootElement.AccessibleName = null;
            // 
            // txtRowKey
            // 
            resources.ApplyResources(this.txtRowKey, "txtRowKey");
            this.txtRowKey.Name = "txtRowKey";
            this.txtRowKey.ReadOnly = true;
            this.txtRowKey.Click += new System.EventHandler(this.txtRowKey_Click);
            // 
            // lblRowKey
            // 
            resources.ApplyResources(this.lblRowKey, "lblRowKey");
            this.lblRowKey.Name = "lblRowKey";
            // 
            // txtApplication
            // 
            resources.ApplyResources(this.txtApplication, "txtApplication");
            this.txtApplication.Name = "txtApplication";
            this.txtApplication.ReadOnly = true;
            this.txtApplication.Click += new System.EventHandler(this.txtApplication_Click);
            // 
            // txtHostname
            // 
            resources.ApplyResources(this.txtHostname, "txtHostname");
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.ReadOnly = true;
            this.txtHostname.Click += new System.EventHandler(this.txtHostname_Click);
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            // 
            // txtColumnName
            // 
            resources.ApplyResources(this.txtColumnName, "txtColumnName");
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.ReadOnly = true;
            this.txtColumnName.Click += new System.EventHandler(this.txtColumnName_Click);
            // 
            // txtTableName
            // 
            resources.ApplyResources(this.txtTableName, "txtTableName");
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.ReadOnly = true;
            this.txtTableName.Click += new System.EventHandler(this.txtTableName_Click);
            // 
            // txtEvent
            // 
            resources.ApplyResources(this.txtEvent, "txtEvent");
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.ReadOnly = true;
            this.txtEvent.Click += new System.EventHandler(this.txtEvent_Click);
            // 
            // txtDateTime
            // 
            resources.ApplyResources(this.txtDateTime, "txtDateTime");
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.ReadOnly = true;
            this.txtDateTime.Click += new System.EventHandler(this.txtDateTime_Click);
            // 
            // txtAuditID
            // 
            resources.ApplyResources(this.txtAuditID, "txtAuditID");
            this.txtAuditID.Name = "txtAuditID";
            this.txtAuditID.ReadOnly = true;
            this.txtAuditID.Click += new System.EventHandler(this.txtAuditID_Click);
            // 
            // lblApp
            // 
            resources.ApplyResources(this.lblApp, "lblApp");
            this.lblApp.Name = "lblApp";
            // 
            // lblHostname
            // 
            resources.ApplyResources(this.lblHostname, "lblHostname");
            this.lblHostname.Name = "lblHostname";
            // 
            // lblUser
            // 
            resources.ApplyResources(this.lblUser, "lblUser");
            this.lblUser.Name = "lblUser";
            // 
            // lblColumnName
            // 
            resources.ApplyResources(this.lblColumnName, "lblColumnName");
            this.lblColumnName.Name = "lblColumnName";
            // 
            // lblTableName
            // 
            resources.ApplyResources(this.lblTableName, "lblTableName");
            this.lblTableName.Name = "lblTableName";
            // 
            // lblEvent
            // 
            resources.ApplyResources(this.lblEvent, "lblEvent");
            this.lblEvent.Name = "lblEvent";
            // 
            // lblDateTime
            // 
            resources.ApplyResources(this.lblDateTime, "lblDateTime");
            this.lblDateTime.Name = "lblDateTime";
            // 
            // lblAuditID
            // 
            resources.ApplyResources(this.lblAuditID, "lblAuditID");
            this.lblAuditID.Name = "lblAuditID";
            // 
            // radMenu1
            // 
            chordModifier1.AltModifier = false;
            chordModifier1.ControlModifier = true;
            chordModifier1.ShiftModifier = false;
            chord1.ChordModifier = chordModifier1;
            chord1.Keys = "Ctrl+L";
            inputBinding1.Chord = chord1;
            clickCommand1.ContextType = null;
            clickCommand1.ImageList = null;
            clickCommand1.Name = "ActionCommand";
            clickCommand1.OwnerType = typeof(Telerik.WinControls.RadItem);
            clickCommand1.Text = "This command rises the Click event of a selected RadItem instance.";
            clickCommand1.Type = "";
            inputBinding1.Command = clickCommand1;
            inputBinding1.CommandContext = this.rmiLogOff;
            chordModifier2.AltModifier = true;
            chordModifier2.ControlModifier = false;
            chordModifier2.ShiftModifier = false;
            chord2.ChordModifier = chordModifier2;
            chord2.Keys = "Alt+X";
            inputBinding2.Chord = chord2;
            inputBinding2.Command = clickCommand1;
            inputBinding2.CommandContext = this.rmiExit;
            chordModifier3.AltModifier = false;
            chordModifier3.ControlModifier = false;
            chordModifier3.ShiftModifier = false;
            chord3.ChordModifier = chordModifier3;
            chord3.Keys = "F1";
            inputBinding3.Chord = chord3;
            inputBinding3.Command = clickCommand1;
            inputBinding3.CommandContext = this.rmiContents;
            chordModifier4.AltModifier = false;
            chordModifier4.ControlModifier = true;
            chordModifier4.ShiftModifier = false;
            chord4.ChordModifier = chordModifier4;
            chord4.Keys = "Ctrl+A";
            inputBinding4.Chord = chord4;
            inputBinding4.Command = clickCommand1;
            inputBinding4.CommandContext = this.rmiAbout;
            this.radMenu1.CommandBindings.AddRange(new Telerik.WinControls.Keyboard.InputBinding[] {
            inputBinding1,
            inputBinding2,
            inputBinding3,
            inputBinding4});
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiFile,
            this.rmiHelp});
            resources.ApplyResources(this.radMenu1, "radMenu1");
            this.radMenu1.Name = "radMenu1";
            // 
            // AlmisViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radSplitContainer1);
            this.Controls.Add(this.radMenu1);
            this.Name = "AlmisViewer";
            // 
            // 
            // 
            this.RootElement.AccessibleDescription = null;
            this.RootElement.AccessibleName = null;
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "ControlDefault";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AlmisViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnExportToCsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrintPriview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFind)).EndInit();
            this.gbLogEntryLimit.ResumeLayout(false);
            this.gbLogEntryLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxEntries)).EndInit();
            this.gbEvent.ResumeLayout(false);
            this.gbEvent.PerformLayout();
            this.gbDateTimeRange.ResumeLayout(false);
            this.gbDateTimeRange.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rtpOccuredBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpOccuredAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpOccuredBefore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpOccuredAfter)).EndInit();
            this.gbRowKey.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel3)).EndInit();
            this.splitPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenuItem rmiFile;
        private Telerik.WinControls.UI.RadMenuItem rmiLogOff;
        private Telerik.WinControls.UI.RadMenuItem rmiExit;
        private Telerik.WinControls.UI.RadMenuItem rmiHelp;
        private Telerik.WinControls.UI.RadMenuItem rmiContents;
        private Telerik.WinControls.UI.RadMenuItem rmiAbout;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.SplitPanel splitPanel3;
        private System.Windows.Forms.GroupBox gbEvent;
        private System.Windows.Forms.CheckBox chbDelete;
        private System.Windows.Forms.CheckBox chbUpdate;
        private System.Windows.Forms.CheckBox chbInsert;
        private System.Windows.Forms.GroupBox gbDateTimeRange;
        private Telerik.WinControls.UI.RadTimePicker rtpOccuredBefore;
        private Telerik.WinControls.UI.RadTimePicker rtpOccuredAfter;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpOccuredBefore;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpOccuredAfter;
        private System.Windows.Forms.GroupBox gbRowKey;
        private System.Windows.Forms.Button btnRowKeyList;
        private System.Windows.Forms.ComboBox cbRowKey;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnApplicationList;
        private System.Windows.Forms.Button btnWorkstationList;
        private System.Windows.Forms.Button btnUserNameList;
        private System.Windows.Forms.Button btnColumnList;
        private System.Windows.Forms.Button btnTableList;
        private System.Windows.Forms.ComboBox cbApplication;
        private System.Windows.Forms.ComboBox cbWorkstation;
        private System.Windows.Forms.ComboBox cbUserName;
        private System.Windows.Forms.ComboBox cbColumn;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label lblApplication;
        private System.Windows.Forms.Label lblWorkstation;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.CheckBox chbOccuredBefore;
        private System.Windows.Forms.CheckBox chbOccuredAfter;
        private System.Windows.Forms.GroupBox gbLogEntryLimit;
        private System.Windows.Forms.NumericUpDown nupMaxEntries;
        private System.Windows.Forms.TextBox txtLogEntries;
        private System.Windows.Forms.Label lblMaximumEntries;
        private System.Windows.Forms.Label lblLogEntries;
        private Telerik.WinControls.UI.RadButton btnFind;
        private System.Windows.Forms.Label lblResult;
        private Telerik.WinControls.UI.OfficeShape officeShape1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.TextBox txtOldValue;
        private System.Windows.Forms.TextBox txtNewValue;
        private System.Windows.Forms.Label lblOldValue;
        private System.Windows.Forms.Label lblNewValue;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.TextBox txtRowKey;
        private System.Windows.Forms.Label lblRowKey;
        private System.Windows.Forms.TextBox txtApplication;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtAuditID;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblColumnName;
        private System.Windows.Forms.Label lblTableName;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblAuditID;
        private Telerik.WinControls.UI.RadButton btnPrintPriview;
        private Telerik.WinControls.UI.RadButton btnExcel;
        private Telerik.WinControls.UI.RadButton rbtnExportToCsv;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnMoreDateTimeFilters;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}
