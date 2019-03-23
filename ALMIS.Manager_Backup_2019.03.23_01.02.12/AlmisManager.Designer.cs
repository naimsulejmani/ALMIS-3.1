namespace ALMIS.Manager
{
    partial class AlmisManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlmisManager));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.cbDatabase = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.rmiContents = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiDisconnect = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiExit = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.rpvAlmisManager = new Telerik.WinControls.UI.RadPageView();
            this.rpvPrerequirements = new Telerik.WinControls.UI.RadPageViewPage();
            this.lblPrerequirementsMsg = new System.Windows.Forms.Label();
            this.rbtnInstallPrerequirements = new Telerik.WinControls.UI.RadButton();
            this.rgbDatabase = new Telerik.WinControls.UI.RadGroupBox();
            this.lblInfoForAuditTables = new System.Windows.Forms.Label();
            this.rpvAuditSetup = new Telerik.WinControls.UI.RadPageViewPage();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableSchema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditTable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AuditInserts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AuditUpdates = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AuditDeletes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rbtnRestoreToDefault = new Telerik.WinControls.UI.RadButton();
            this.radPageView2 = new Telerik.WinControls.UI.RadPageView();
            this.rpvColumns = new Telerik.WinControls.UI.RadPageViewPage();
            this.dgvColumns = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuditColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbAllColumns = new System.Windows.Forms.CheckBox();
            this.lblColumnsInfo = new System.Windows.Forms.Label();
            this.rpvTriggers = new Telerik.WinControls.UI.RadPageViewPage();
            this.dgvTriggers = new System.Windows.Forms.DataGridView();
            this.TableSchema1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TriggerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTriggerInfo2 = new System.Windows.Forms.Label();
            this.lblTriggerInfo1 = new System.Windows.Forms.Label();
            this.chbAuditAllDeleted = new System.Windows.Forms.CheckBox();
            this.chbAuditAllUpdated = new System.Windows.Forms.CheckBox();
            this.chbAuditAllInserted = new System.Windows.Forms.CheckBox();
            this.chbAuditAll = new System.Windows.Forms.CheckBox();
            this.rpvBuildTriggers = new Telerik.WinControls.UI.RadPageViewPage();
            this.rbtnRebuildAuditTriggers = new Telerik.WinControls.UI.RadButton();
            this.lblCreateAuditingInfo = new System.Windows.Forms.Label();
            this.rgbBuildTriggersFor = new Telerik.WinControls.UI.RadGroupBox();
            this.rmcbSelectTable = new Telerik.WinControls.UI.RadDropDownList();
            this.rrbAllTables = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbSingelTable = new Telerik.WinControls.UI.RadRadioButton();
            this.rpvArchiveLog = new Telerik.WinControls.UI.RadPageViewPage();
            this.rbtnDeleteAuditLog = new Telerik.WinControls.UI.RadButton();
            this.rgbDeleteAuditLog = new Telerik.WinControls.UI.RadGroupBox();
            this.lblDeletedDate = new System.Windows.Forms.Label();
            this.lblDeleteAuditLog = new System.Windows.Forms.Label();
            this.rbYearDelete = new System.Windows.Forms.RadioButton();
            this.rbMonthDelete = new System.Windows.Forms.RadioButton();
            this.nudDelete = new System.Windows.Forms.NumericUpDown();
            this.rtpTimeDelete = new Telerik.WinControls.UI.RadTimePicker();
            this.rdtpDateDelete = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rrbIntervalDelete = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbDateDelete = new Telerik.WinControls.UI.RadRadioButton();
            this.rbtnArchiveAuditLogData = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblArchivedDate = new System.Windows.Forms.Label();
            this.lblArchiveAuditLog = new System.Windows.Forms.Label();
            this.rbYearArchive = new System.Windows.Forms.RadioButton();
            this.rbMonthArchive = new System.Windows.Forms.RadioButton();
            this.nupArchive = new System.Windows.Forms.NumericUpDown();
            this.rtpArchiveTime = new Telerik.WinControls.UI.RadTimePicker();
            this.rdtpArchiveDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rrbIntervalArchive = new Telerik.WinControls.UI.RadRadioButton();
            this.rrbDateArchive = new Telerik.WinControls.UI.RadRadioButton();
            this.rpvUninstallAudit = new Telerik.WinControls.UI.RadPageViewPage();
            this.rbtnUninstallAuditing = new Telerik.WinControls.UI.RadButton();
            this.lblUninstallInfo = new System.Windows.Forms.Label();
            this.rpvUsers = new Telerik.WinControls.UI.RadPageViewPage();
            this.chbChangePassword = new System.Windows.Forms.CheckBox();
            this.lblPasswordInfo = new System.Windows.Forms.Label();
            this.rbtnDelete = new Telerik.WinControls.UI.RadButton();
            this.rbtnEdit = new Telerik.WinControls.UI.RadButton();
            this.dgvAuditUsers = new System.Windows.Forms.DataGridView();
            this.gvUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvCanAccess = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.rbtnReset = new Telerik.WinControls.UI.RadButton();
            this.rbtnSearchPerson = new Telerik.WinControls.UI.RadButton();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rbtnConfirm = new Telerik.WinControls.UI.RadButton();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chbAccessAlmisViewer = new System.Windows.Forms.CheckBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.rmiFile = new Telerik.WinControls.UI.RadMenuItem();
            this.rmiHelp = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.rgvAuditUsers = new Telerik.WinControls.UI.MasterGridViewTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpvAlmisManager)).BeginInit();
            this.rpvAlmisManager.SuspendLayout();
            this.rpvPrerequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnInstallPrerequirements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDatabase)).BeginInit();
            this.rgbDatabase.SuspendLayout();
            this.rpvAuditSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnRestoreToDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView2)).BeginInit();
            this.radPageView2.SuspendLayout();
            this.rpvColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).BeginInit();
            this.rpvTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriggers)).BeginInit();
            this.rpvBuildTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnRebuildAuditTriggers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbBuildTriggersFor)).BeginInit();
            this.rgbBuildTriggersFor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rmcbSelectTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbAllTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbSingelTable)).BeginInit();
            this.rpvArchiveLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnDeleteAuditLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDeleteAuditLog)).BeginInit();
            this.rgbDeleteAuditLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpTimeDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpDateDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbIntervalDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbDateDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnArchiveAuditLogData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpArchiveTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpArchiveDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbIntervalArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbDateArchive)).BeginInit();
            this.rpvUninstallAudit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnUninstallAuditing)).BeginInit();
            this.rpvUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSearchPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAuditUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDatabase
            // 
            resources.ApplyResources(this.cbDatabase, "cbDatabase");
            // 
            // cbDatabase.NestedRadGridView
            // 
            resources.ApplyResources(this.cbDatabase.EditorControl, "cbDatabase.NestedRadGridView");
            this.cbDatabase.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.cbDatabase.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // 
            // 
            this.cbDatabase.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.cbDatabase.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.cbDatabase.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.cbDatabase.EditorControl.MasterTemplate.Caption = resources.GetString("cbDatabase.EditorControl.MasterTemplate.Caption");
            this.cbDatabase.EditorControl.MasterTemplate.EnableGrouping = false;
            this.cbDatabase.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.cbDatabase.EditorControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.cbDatabase.EditorControl.Name = "NestedRadGridView";
            this.cbDatabase.EditorControl.ReadOnly = true;
            // 
            // 
            // 
            this.cbDatabase.EditorControl.RootElement.AccessibleDescription = null;
            this.cbDatabase.EditorControl.RootElement.AccessibleName = null;
            this.cbDatabase.EditorControl.ShowGroupPanel = false;
            this.cbDatabase.Name = "cbDatabase";
            // 
            // 
            // 
            this.cbDatabase.RootElement.AccessibleDescription = null;
            this.cbDatabase.RootElement.AccessibleName = null;
            this.cbDatabase.TabStop = false;
            // 
            // rmiContents
            // 
            this.rmiContents.AccessibleDescription = "Contents";
            resources.ApplyResources(this.rmiContents, "rmiContents");
            this.rmiContents.Name = "rmiContents";
            this.rmiContents.Click += new System.EventHandler(this.rmiContents_Click);
            // 
            // rmiDisconnect
            // 
            this.rmiDisconnect.AccessibleDescription = "Disconnect";
            resources.ApplyResources(this.rmiDisconnect, "rmiDisconnect");
            this.rmiDisconnect.Name = "rmiDisconnect";
            this.rmiDisconnect.Click += new System.EventHandler(this.rmiDisconnect_Click);
            // 
            // rmiExit
            // 
            this.rmiExit.AccessibleDescription = "Exit";
            resources.ApplyResources(this.rmiExit, "rmiExit");
            this.rmiExit.Name = "rmiExit";
            this.rmiExit.Click += new System.EventHandler(this.rmiExit_Click);
            // 
            // rmiAbout
            // 
            this.rmiAbout.AccessibleDescription = "About";
            resources.ApplyResources(this.rmiAbout, "rmiAbout");
            this.rmiAbout.Name = "rmiAbout";
            this.rmiAbout.Click += new System.EventHandler(this.rmiAbout_Click);
            // 
            // rpvAlmisManager
            // 
            resources.ApplyResources(this.rpvAlmisManager, "rpvAlmisManager");
            this.rpvAlmisManager.Controls.Add(this.rpvPrerequirements);
            this.rpvAlmisManager.Controls.Add(this.rpvAuditSetup);
            this.rpvAlmisManager.Controls.Add(this.rpvBuildTriggers);
            this.rpvAlmisManager.Controls.Add(this.rpvArchiveLog);
            this.rpvAlmisManager.Controls.Add(this.rpvUninstallAudit);
            this.rpvAlmisManager.Controls.Add(this.rpvUsers);
            this.rpvAlmisManager.Name = "rpvAlmisManager";
            // 
            // 
            // 
            this.rpvAlmisManager.RootElement.AccessibleDescription = null;
            this.rpvAlmisManager.RootElement.AccessibleName = null;
            this.rpvAlmisManager.SelectedPage = this.rpvPrerequirements;
            this.rpvAlmisManager.ViewMode = Telerik.WinControls.UI.PageViewMode.Backstage;
            this.rpvAlmisManager.SelectedPageChanged += new System.EventHandler(this.rpvAlmisManager_SelectedPageChanged);
            ((Telerik.WinControls.UI.StripViewItemContainer)(this.rpvAlmisManager.GetChildAt(0).GetChildAt(0))).MinSize = new System.Drawing.Size(100, 0);
            // 
            // rpvPrerequirements
            // 
            resources.ApplyResources(this.rpvPrerequirements, "rpvPrerequirements");
            this.rpvPrerequirements.Controls.Add(this.lblPrerequirementsMsg);
            this.rpvPrerequirements.Controls.Add(this.rbtnInstallPrerequirements);
            this.rpvPrerequirements.Controls.Add(this.rgbDatabase);
            this.rpvPrerequirements.Controls.Add(this.lblInfoForAuditTables);
            this.rpvPrerequirements.Image = ((System.Drawing.Image)(resources.GetObject("rpvPrerequirements.Image")));
            this.rpvPrerequirements.ItemSize = new System.Drawing.SizeF(212F, 74F);
            this.rpvPrerequirements.Name = "rpvPrerequirements";
            // 
            // lblPrerequirementsMsg
            // 
            resources.ApplyResources(this.lblPrerequirementsMsg, "lblPrerequirementsMsg");
            this.lblPrerequirementsMsg.Name = "lblPrerequirementsMsg";
            // 
            // rbtnInstallPrerequirements
            // 
            resources.ApplyResources(this.rbtnInstallPrerequirements, "rbtnInstallPrerequirements");
            this.rbtnInstallPrerequirements.Name = "rbtnInstallPrerequirements";
            // 
            // 
            // 
            this.rbtnInstallPrerequirements.RootElement.AccessibleDescription = null;
            this.rbtnInstallPrerequirements.RootElement.AccessibleName = null;
            this.rbtnInstallPrerequirements.Click += new System.EventHandler(this.rbtnInstallPrerequirements_Click);
            // 
            // rgbDatabase
            // 
            resources.ApplyResources(this.rgbDatabase, "rgbDatabase");
            this.rgbDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbDatabase.Controls.Add(this.cbDatabase);
            this.rgbDatabase.Name = "rgbDatabase";
            // 
            // 
            // 
            this.rgbDatabase.RootElement.AccessibleDescription = null;
            this.rgbDatabase.RootElement.AccessibleName = null;
            // 
            // lblInfoForAuditTables
            // 
            resources.ApplyResources(this.lblInfoForAuditTables, "lblInfoForAuditTables");
            this.lblInfoForAuditTables.Name = "lblInfoForAuditTables";
            // 
            // rpvAuditSetup
            // 
            resources.ApplyResources(this.rpvAuditSetup, "rpvAuditSetup");
            this.rpvAuditSetup.Controls.Add(this.dgvTables);
            this.rpvAuditSetup.Controls.Add(this.rbtnRestoreToDefault);
            this.rpvAuditSetup.Controls.Add(this.radPageView2);
            this.rpvAuditSetup.Controls.Add(this.chbAuditAllDeleted);
            this.rpvAuditSetup.Controls.Add(this.chbAuditAllUpdated);
            this.rpvAuditSetup.Controls.Add(this.chbAuditAllInserted);
            this.rpvAuditSetup.Controls.Add(this.chbAuditAll);
            this.rpvAuditSetup.Image = ((System.Drawing.Image)(resources.GetObject("rpvAuditSetup.Image")));
            this.rpvAuditSetup.ItemSize = new System.Drawing.SizeF(212F, 74F);
            this.rpvAuditSetup.Name = "rpvAuditSetup";
            // 
            // dgvTables
            // 
            resources.ApplyResources(this.dgvTables, "dgvTables");
            this.dgvTables.AllowUserToAddRows = false;
            this.dgvTables.AllowUserToDeleteRows = false;
            this.dgvTables.AllowUserToResizeColumns = false;
            this.dgvTables.AllowUserToResizeRows = false;
            this.dgvTables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTables.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableName,
            this.TableSchema,
            this.AuditTable,
            this.AuditInserts,
            this.AuditUpdates,
            this.AuditDeletes});
            this.dgvTables.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTables.MultiSelect = false;
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTables_CellClick);
            this.dgvTables.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvTables_KeyDown);
            // 
            // TableName
            // 
            this.TableName.DataPropertyName = "TableName";
            resources.ApplyResources(this.TableName, "TableName");
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            // 
            // TableSchema
            // 
            this.TableSchema.DataPropertyName = "TableSchema";
            resources.ApplyResources(this.TableSchema, "TableSchema");
            this.TableSchema.Name = "TableSchema";
            this.TableSchema.ReadOnly = true;
            // 
            // AuditTable
            // 
            this.AuditTable.DataPropertyName = "AuditTable";
            resources.ApplyResources(this.AuditTable, "AuditTable");
            this.AuditTable.Name = "AuditTable";
            this.AuditTable.ReadOnly = true;
            // 
            // AuditInserts
            // 
            this.AuditInserts.DataPropertyName = "AuditInserts";
            resources.ApplyResources(this.AuditInserts, "AuditInserts");
            this.AuditInserts.Name = "AuditInserts";
            this.AuditInserts.ReadOnly = true;
            // 
            // AuditUpdates
            // 
            this.AuditUpdates.DataPropertyName = "AuditUpdates";
            resources.ApplyResources(this.AuditUpdates, "AuditUpdates");
            this.AuditUpdates.Name = "AuditUpdates";
            this.AuditUpdates.ReadOnly = true;
            // 
            // AuditDeletes
            // 
            this.AuditDeletes.DataPropertyName = "AuditDeletes";
            resources.ApplyResources(this.AuditDeletes, "AuditDeletes");
            this.AuditDeletes.Name = "AuditDeletes";
            this.AuditDeletes.ReadOnly = true;
            // 
            // rbtnRestoreToDefault
            // 
            resources.ApplyResources(this.rbtnRestoreToDefault, "rbtnRestoreToDefault");
            this.rbtnRestoreToDefault.Name = "rbtnRestoreToDefault";
            // 
            // 
            // 
            this.rbtnRestoreToDefault.RootElement.AccessibleDescription = null;
            this.rbtnRestoreToDefault.RootElement.AccessibleName = null;
            this.rbtnRestoreToDefault.Click += new System.EventHandler(this.rbtnRestoreToDefault_Click);
            // 
            // radPageView2
            // 
            resources.ApplyResources(this.radPageView2, "radPageView2");
            this.radPageView2.Controls.Add(this.rpvColumns);
            this.radPageView2.Controls.Add(this.rpvTriggers);
            this.radPageView2.Name = "radPageView2";
            // 
            // 
            // 
            this.radPageView2.RootElement.AccessibleDescription = null;
            this.radPageView2.RootElement.AccessibleName = null;
            this.radPageView2.SelectedPage = this.rpvColumns;
            this.radPageView2.SelectedPageChanged += new System.EventHandler(this.radPageView2_SelectedPageChanged);
            // 
            // rpvColumns
            // 
            resources.ApplyResources(this.rpvColumns, "rpvColumns");
            this.rpvColumns.Controls.Add(this.dgvColumns);
            this.rpvColumns.Controls.Add(this.chbAllColumns);
            this.rpvColumns.Controls.Add(this.lblColumnsInfo);
            this.rpvColumns.ItemSize = new System.Drawing.SizeF(55F, 28F);
            this.rpvColumns.Name = "rpvColumns";
            // 
            // dgvColumns
            // 
            resources.ApplyResources(this.dgvColumns, "dgvColumns");
            this.dgvColumns.AllowUserToAddRows = false;
            this.dgvColumns.AllowUserToDeleteRows = false;
            this.dgvColumns.AllowUserToResizeColumns = false;
            this.dgvColumns.AllowUserToResizeRows = false;
            this.dgvColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvColumns.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.AuditColumn,
            this.DataType});
            this.dgvColumns.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvColumns.MultiSelect = false;
            this.dgvColumns.Name = "dgvColumns";
            this.dgvColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvColumns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColumns_CellClick);
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "ColumnName";
            resources.ApplyResources(this.ColumnName, "ColumnName");
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // AuditColumn
            // 
            this.AuditColumn.DataPropertyName = "AuditColumn";
            resources.ApplyResources(this.AuditColumn, "AuditColumn");
            this.AuditColumn.Name = "AuditColumn";
            this.AuditColumn.ReadOnly = true;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            resources.ApplyResources(this.DataType, "DataType");
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            // 
            // chbAllColumns
            // 
            resources.ApplyResources(this.chbAllColumns, "chbAllColumns");
            this.chbAllColumns.Name = "chbAllColumns";
            this.chbAllColumns.UseVisualStyleBackColor = true;
            this.chbAllColumns.CheckedChanged += new System.EventHandler(this.chbAllColumns_CheckedChanged);
            // 
            // lblColumnsInfo
            // 
            resources.ApplyResources(this.lblColumnsInfo, "lblColumnsInfo");
            this.lblColumnsInfo.Name = "lblColumnsInfo";
            // 
            // rpvTriggers
            // 
            resources.ApplyResources(this.rpvTriggers, "rpvTriggers");
            this.rpvTriggers.Controls.Add(this.dgvTriggers);
            this.rpvTriggers.Controls.Add(this.lblTriggerInfo2);
            this.rpvTriggers.Controls.Add(this.lblTriggerInfo1);
            this.rpvTriggers.ItemSize = new System.Drawing.SizeF(55F, 28F);
            this.rpvTriggers.Name = "rpvTriggers";
            // 
            // dgvTriggers
            // 
            resources.ApplyResources(this.dgvTriggers, "dgvTriggers");
            this.dgvTriggers.AllowUserToAddRows = false;
            this.dgvTriggers.AllowUserToDeleteRows = false;
            this.dgvTriggers.AllowUserToResizeColumns = false;
            this.dgvTriggers.AllowUserToResizeRows = false;
            this.dgvTriggers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTriggers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTriggers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTriggers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableSchema1,
            this.Table_Name,
            this.TriggerName,
            this.Disabled});
            this.dgvTriggers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTriggers.MultiSelect = false;
            this.dgvTriggers.Name = "dgvTriggers";
            this.dgvTriggers.ReadOnly = true;
            this.dgvTriggers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTriggers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTriggers_CellClick);
            // 
            // TableSchema1
            // 
            this.TableSchema1.DataPropertyName = "TableSchema";
            resources.ApplyResources(this.TableSchema1, "TableSchema1");
            this.TableSchema1.Name = "TableSchema1";
            this.TableSchema1.ReadOnly = true;
            // 
            // Table_Name
            // 
            this.Table_Name.DataPropertyName = "TableName";
            resources.ApplyResources(this.Table_Name, "Table_Name");
            this.Table_Name.Name = "Table_Name";
            this.Table_Name.ReadOnly = true;
            // 
            // TriggerName
            // 
            this.TriggerName.DataPropertyName = "TriggerName";
            resources.ApplyResources(this.TriggerName, "TriggerName");
            this.TriggerName.Name = "TriggerName";
            this.TriggerName.ReadOnly = true;
            // 
            // Disabled
            // 
            this.Disabled.DataPropertyName = "Disabled";
            resources.ApplyResources(this.Disabled, "Disabled");
            this.Disabled.Name = "Disabled";
            this.Disabled.ReadOnly = true;
            // 
            // lblTriggerInfo2
            // 
            resources.ApplyResources(this.lblTriggerInfo2, "lblTriggerInfo2");
            this.lblTriggerInfo2.Name = "lblTriggerInfo2";
            // 
            // lblTriggerInfo1
            // 
            resources.ApplyResources(this.lblTriggerInfo1, "lblTriggerInfo1");
            this.lblTriggerInfo1.Name = "lblTriggerInfo1";
            // 
            // chbAuditAllDeleted
            // 
            resources.ApplyResources(this.chbAuditAllDeleted, "chbAuditAllDeleted");
            this.chbAuditAllDeleted.Name = "chbAuditAllDeleted";
            this.chbAuditAllDeleted.UseVisualStyleBackColor = true;
            this.chbAuditAllDeleted.CheckedChanged += new System.EventHandler(this.chbAuditAllDeleted_CheckedChanged);
            // 
            // chbAuditAllUpdated
            // 
            resources.ApplyResources(this.chbAuditAllUpdated, "chbAuditAllUpdated");
            this.chbAuditAllUpdated.Name = "chbAuditAllUpdated";
            this.chbAuditAllUpdated.UseVisualStyleBackColor = true;
            this.chbAuditAllUpdated.CheckedChanged += new System.EventHandler(this.chbAuditAllUpdated_CheckedChanged);
            // 
            // chbAuditAllInserted
            // 
            resources.ApplyResources(this.chbAuditAllInserted, "chbAuditAllInserted");
            this.chbAuditAllInserted.Name = "chbAuditAllInserted";
            this.chbAuditAllInserted.UseVisualStyleBackColor = true;
            this.chbAuditAllInserted.CheckedChanged += new System.EventHandler(this.chbAuditAllInserted_CheckedChanged);
            // 
            // chbAuditAll
            // 
            resources.ApplyResources(this.chbAuditAll, "chbAuditAll");
            this.chbAuditAll.Name = "chbAuditAll";
            this.chbAuditAll.UseVisualStyleBackColor = true;
            this.chbAuditAll.CheckedChanged += new System.EventHandler(this.chbAuditAll_CheckedChanged);
            // 
            // rpvBuildTriggers
            // 
            resources.ApplyResources(this.rpvBuildTriggers, "rpvBuildTriggers");
            this.rpvBuildTriggers.Controls.Add(this.rbtnRebuildAuditTriggers);
            this.rpvBuildTriggers.Controls.Add(this.lblCreateAuditingInfo);
            this.rpvBuildTriggers.Controls.Add(this.rgbBuildTriggersFor);
            this.rpvBuildTriggers.Image = ((System.Drawing.Image)(resources.GetObject("rpvBuildTriggers.Image")));
            this.rpvBuildTriggers.ItemSize = new System.Drawing.SizeF(212F, 74F);
            this.rpvBuildTriggers.Name = "rpvBuildTriggers";
            // 
            // rbtnRebuildAuditTriggers
            // 
            resources.ApplyResources(this.rbtnRebuildAuditTriggers, "rbtnRebuildAuditTriggers");
            this.rbtnRebuildAuditTriggers.Name = "rbtnRebuildAuditTriggers";
            // 
            // 
            // 
            this.rbtnRebuildAuditTriggers.RootElement.AccessibleDescription = null;
            this.rbtnRebuildAuditTriggers.RootElement.AccessibleName = null;
            this.rbtnRebuildAuditTriggers.Click += new System.EventHandler(this.rbtnRebuildAuditTriggers_Click);
            // 
            // lblCreateAuditingInfo
            // 
            resources.ApplyResources(this.lblCreateAuditingInfo, "lblCreateAuditingInfo");
            this.lblCreateAuditingInfo.Name = "lblCreateAuditingInfo";
            // 
            // rgbBuildTriggersFor
            // 
            resources.ApplyResources(this.rgbBuildTriggersFor, "rgbBuildTriggersFor");
            this.rgbBuildTriggersFor.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbBuildTriggersFor.Controls.Add(this.rmcbSelectTable);
            this.rgbBuildTriggersFor.Controls.Add(this.rrbAllTables);
            this.rgbBuildTriggersFor.Controls.Add(this.rrbSingelTable);
            this.rgbBuildTriggersFor.Name = "rgbBuildTriggersFor";
            // 
            // 
            // 
            this.rgbBuildTriggersFor.RootElement.AccessibleDescription = null;
            this.rgbBuildTriggersFor.RootElement.AccessibleName = null;
            // 
            // rmcbSelectTable
            // 
            resources.ApplyResources(this.rmcbSelectTable, "rmcbSelectTable");
            this.rmcbSelectTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            radListDataItem1.Tag = "TableName";
            radListDataItem1.Text = "TableName";
            resources.ApplyResources(radListDataItem1, "radListDataItem1");
            this.rmcbSelectTable.Items.Add(radListDataItem1);
            this.rmcbSelectTable.Name = "rmcbSelectTable";
            // 
            // 
            // 
            this.rmcbSelectTable.RootElement.AccessibleDescription = null;
            this.rmcbSelectTable.RootElement.AccessibleName = null;
            this.rmcbSelectTable.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rmcbSelectTable_SelectedIndexChanged);
            this.rmcbSelectTable.Click += new System.EventHandler(this.rmcbSelectTable_Click);
            // 
            // rrbAllTables
            // 
            resources.ApplyResources(this.rrbAllTables, "rrbAllTables");
            this.rrbAllTables.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rrbAllTables.Name = "rrbAllTables";
            // 
            // 
            // 
            this.rrbAllTables.RootElement.AccessibleDescription = null;
            this.rrbAllTables.RootElement.AccessibleName = null;
            this.rrbAllTables.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // rrbSingelTable
            // 
            resources.ApplyResources(this.rrbSingelTable, "rrbSingelTable");
            this.rrbSingelTable.Name = "rrbSingelTable";
            // 
            // 
            // 
            this.rrbSingelTable.RootElement.AccessibleDescription = null;
            this.rrbSingelTable.RootElement.AccessibleName = null;
            // 
            // rpvArchiveLog
            // 
            resources.ApplyResources(this.rpvArchiveLog, "rpvArchiveLog");
            this.rpvArchiveLog.Controls.Add(this.rbtnDeleteAuditLog);
            this.rpvArchiveLog.Controls.Add(this.rgbDeleteAuditLog);
            this.rpvArchiveLog.Controls.Add(this.rbtnArchiveAuditLogData);
            this.rpvArchiveLog.Controls.Add(this.radGroupBox1);
            this.rpvArchiveLog.Image = ((System.Drawing.Image)(resources.GetObject("rpvArchiveLog.Image")));
            this.rpvArchiveLog.ItemSize = new System.Drawing.SizeF(212F, 74F);
            this.rpvArchiveLog.Name = "rpvArchiveLog";
            // 
            // rbtnDeleteAuditLog
            // 
            resources.ApplyResources(this.rbtnDeleteAuditLog, "rbtnDeleteAuditLog");
            this.rbtnDeleteAuditLog.Name = "rbtnDeleteAuditLog";
            // 
            // 
            // 
            this.rbtnDeleteAuditLog.RootElement.AccessibleDescription = null;
            this.rbtnDeleteAuditLog.RootElement.AccessibleName = null;
            this.rbtnDeleteAuditLog.Click += new System.EventHandler(this.rbtnDeleteAuditLog_Click);
            // 
            // rgbDeleteAuditLog
            // 
            resources.ApplyResources(this.rgbDeleteAuditLog, "rgbDeleteAuditLog");
            this.rgbDeleteAuditLog.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.rgbDeleteAuditLog.Controls.Add(this.lblDeletedDate);
            this.rgbDeleteAuditLog.Controls.Add(this.lblDeleteAuditLog);
            this.rgbDeleteAuditLog.Controls.Add(this.rbYearDelete);
            this.rgbDeleteAuditLog.Controls.Add(this.rbMonthDelete);
            this.rgbDeleteAuditLog.Controls.Add(this.nudDelete);
            this.rgbDeleteAuditLog.Controls.Add(this.rtpTimeDelete);
            this.rgbDeleteAuditLog.Controls.Add(this.rdtpDateDelete);
            this.rgbDeleteAuditLog.Controls.Add(this.rrbIntervalDelete);
            this.rgbDeleteAuditLog.Controls.Add(this.rrbDateDelete);
            this.rgbDeleteAuditLog.Name = "rgbDeleteAuditLog";
            // 
            // 
            // 
            this.rgbDeleteAuditLog.RootElement.AccessibleDescription = null;
            this.rgbDeleteAuditLog.RootElement.AccessibleName = null;
            // 
            // lblDeletedDate
            // 
            resources.ApplyResources(this.lblDeletedDate, "lblDeletedDate");
            this.lblDeletedDate.Name = "lblDeletedDate";
            // 
            // lblDeleteAuditLog
            // 
            resources.ApplyResources(this.lblDeleteAuditLog, "lblDeleteAuditLog");
            this.lblDeleteAuditLog.Name = "lblDeleteAuditLog";
            // 
            // rbYearDelete
            // 
            resources.ApplyResources(this.rbYearDelete, "rbYearDelete");
            this.rbYearDelete.Name = "rbYearDelete";
            this.rbYearDelete.TabStop = true;
            this.rbYearDelete.UseVisualStyleBackColor = true;
            this.rbYearDelete.CheckedChanged += new System.EventHandler(this.rbYearDelete_CheckedChanged);
            // 
            // rbMonthDelete
            // 
            resources.ApplyResources(this.rbMonthDelete, "rbMonthDelete");
            this.rbMonthDelete.Checked = true;
            this.rbMonthDelete.Name = "rbMonthDelete";
            this.rbMonthDelete.TabStop = true;
            this.rbMonthDelete.UseVisualStyleBackColor = true;
            this.rbMonthDelete.CheckedChanged += new System.EventHandler(this.rbMonthDelete_CheckedChanged);
            // 
            // nudDelete
            // 
            resources.ApplyResources(this.nudDelete, "nudDelete");
            this.nudDelete.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudDelete.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelete.Name = "nudDelete";
            this.nudDelete.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelete.ValueChanged += new System.EventHandler(this.nudDelete_ValueChanged);
            // 
            // rtpTimeDelete
            // 
            resources.ApplyResources(this.rtpTimeDelete, "rtpTimeDelete");
            this.rtpTimeDelete.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.rtpTimeDelete.MinValue = new System.DateTime(((long)(0)));
            this.rtpTimeDelete.Name = "rtpTimeDelete";
            // 
            // 
            // 
            this.rtpTimeDelete.RootElement.AccessibleDescription = null;
            this.rtpTimeDelete.RootElement.AccessibleName = null;
            this.rtpTimeDelete.TabStop = false;
            this.rtpTimeDelete.Value = new System.DateTime(2013, 5, 12, 23, 10, 19, 0);
            // 
            // rdtpDateDelete
            // 
            resources.ApplyResources(this.rdtpDateDelete, "rdtpDateDelete");
            this.rdtpDateDelete.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtpDateDelete.Name = "rdtpDateDelete";
            // 
            // 
            // 
            this.rdtpDateDelete.RootElement.AccessibleDescription = null;
            this.rdtpDateDelete.RootElement.AccessibleName = null;
            this.rdtpDateDelete.TabStop = false;
            this.rdtpDateDelete.Value = new System.DateTime(2013, 5, 12, 23, 10, 8, 700);
            // 
            // rrbIntervalDelete
            // 
            resources.ApplyResources(this.rrbIntervalDelete, "rrbIntervalDelete");
            this.rrbIntervalDelete.Name = "rrbIntervalDelete";
            // 
            // 
            // 
            this.rrbIntervalDelete.RootElement.AccessibleDescription = null;
            this.rrbIntervalDelete.RootElement.AccessibleName = null;
            this.rrbIntervalDelete.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbIntervalDelete_ToggleStateChanged);
            // 
            // rrbDateDelete
            // 
            resources.ApplyResources(this.rrbDateDelete, "rrbDateDelete");
            this.rrbDateDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rrbDateDelete.Name = "rrbDateDelete";
            // 
            // 
            // 
            this.rrbDateDelete.RootElement.AccessibleDescription = null;
            this.rrbDateDelete.RootElement.AccessibleName = null;
            this.rrbDateDelete.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rrbDateDelete.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbDateDelete_ToggleStateChanged);
            // 
            // rbtnArchiveAuditLogData
            // 
            resources.ApplyResources(this.rbtnArchiveAuditLogData, "rbtnArchiveAuditLogData");
            this.rbtnArchiveAuditLogData.Name = "rbtnArchiveAuditLogData";
            // 
            // 
            // 
            this.rbtnArchiveAuditLogData.RootElement.AccessibleDescription = null;
            this.rbtnArchiveAuditLogData.RootElement.AccessibleName = null;
            this.rbtnArchiveAuditLogData.Click += new System.EventHandler(this.rbtnArchiveAuditLogData_Click);
            // 
            // radGroupBox1
            // 
            resources.ApplyResources(this.radGroupBox1, "radGroupBox1");
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblArchivedDate);
            this.radGroupBox1.Controls.Add(this.lblArchiveAuditLog);
            this.radGroupBox1.Controls.Add(this.rbYearArchive);
            this.radGroupBox1.Controls.Add(this.rbMonthArchive);
            this.radGroupBox1.Controls.Add(this.nupArchive);
            this.radGroupBox1.Controls.Add(this.rtpArchiveTime);
            this.radGroupBox1.Controls.Add(this.rdtpArchiveDate);
            this.radGroupBox1.Controls.Add(this.rrbIntervalArchive);
            this.radGroupBox1.Controls.Add(this.rrbDateArchive);
            this.radGroupBox1.Name = "radGroupBox1";
            // 
            // 
            // 
            this.radGroupBox1.RootElement.AccessibleDescription = null;
            this.radGroupBox1.RootElement.AccessibleName = null;
            // 
            // lblArchivedDate
            // 
            resources.ApplyResources(this.lblArchivedDate, "lblArchivedDate");
            this.lblArchivedDate.Name = "lblArchivedDate";
            // 
            // lblArchiveAuditLog
            // 
            resources.ApplyResources(this.lblArchiveAuditLog, "lblArchiveAuditLog");
            this.lblArchiveAuditLog.Name = "lblArchiveAuditLog";
            // 
            // rbYearArchive
            // 
            resources.ApplyResources(this.rbYearArchive, "rbYearArchive");
            this.rbYearArchive.Name = "rbYearArchive";
            this.rbYearArchive.UseVisualStyleBackColor = true;
            this.rbYearArchive.CheckedChanged += new System.EventHandler(this.rbYearArchive_CheckedChanged);
            // 
            // rbMonthArchive
            // 
            resources.ApplyResources(this.rbMonthArchive, "rbMonthArchive");
            this.rbMonthArchive.Checked = true;
            this.rbMonthArchive.Name = "rbMonthArchive";
            this.rbMonthArchive.TabStop = true;
            this.rbMonthArchive.UseVisualStyleBackColor = true;
            this.rbMonthArchive.CheckedChanged += new System.EventHandler(this.rbMonthArchive_CheckedChanged);
            // 
            // nupArchive
            // 
            resources.ApplyResources(this.nupArchive, "nupArchive");
            this.nupArchive.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nupArchive.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupArchive.Name = "nupArchive";
            this.nupArchive.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupArchive.ValueChanged += new System.EventHandler(this.nupArchive_ValueChanged);
            // 
            // rtpArchiveTime
            // 
            resources.ApplyResources(this.rtpArchiveTime, "rtpArchiveTime");
            this.rtpArchiveTime.MaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 0);
            this.rtpArchiveTime.MinValue = new System.DateTime(((long)(0)));
            this.rtpArchiveTime.Name = "rtpArchiveTime";
            // 
            // 
            // 
            this.rtpArchiveTime.RootElement.AccessibleDescription = null;
            this.rtpArchiveTime.RootElement.AccessibleName = null;
            this.rtpArchiveTime.TabStop = false;
            this.rtpArchiveTime.Value = new System.DateTime(2013, 5, 12, 23, 10, 19, 0);
            // 
            // rdtpArchiveDate
            // 
            resources.ApplyResources(this.rdtpArchiveDate, "rdtpArchiveDate");
            this.rdtpArchiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rdtpArchiveDate.Name = "rdtpArchiveDate";
            // 
            // 
            // 
            this.rdtpArchiveDate.RootElement.AccessibleDescription = null;
            this.rdtpArchiveDate.RootElement.AccessibleName = null;
            this.rdtpArchiveDate.TabStop = false;
            this.rdtpArchiveDate.Value = new System.DateTime(2013, 5, 12, 23, 10, 8, 700);
            this.rdtpArchiveDate.ValueChanged += new System.EventHandler(this.rdtpArchiveDate_ValueChanged);
            // 
            // rrbIntervalArchive
            // 
            resources.ApplyResources(this.rrbIntervalArchive, "rrbIntervalArchive");
            this.rrbIntervalArchive.Name = "rrbIntervalArchive";
            // 
            // 
            // 
            this.rrbIntervalArchive.RootElement.AccessibleDescription = null;
            this.rrbIntervalArchive.RootElement.AccessibleName = null;
            this.rrbIntervalArchive.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbIntervalArchive_ToggleStateChanged);
            // 
            // rrbDateArchive
            // 
            resources.ApplyResources(this.rrbDateArchive, "rrbDateArchive");
            this.rrbDateArchive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rrbDateArchive.Name = "rrbDateArchive";
            // 
            // 
            // 
            this.rrbDateArchive.RootElement.AccessibleDescription = null;
            this.rrbDateArchive.RootElement.AccessibleName = null;
            this.rrbDateArchive.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rrbDateArchive.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rrbDateArchive_ToggleStateChanged);
            // 
            // rpvUninstallAudit
            // 
            resources.ApplyResources(this.rpvUninstallAudit, "rpvUninstallAudit");
            this.rpvUninstallAudit.Controls.Add(this.rbtnUninstallAuditing);
            this.rpvUninstallAudit.Controls.Add(this.lblUninstallInfo);
            this.rpvUninstallAudit.Image = ((System.Drawing.Image)(resources.GetObject("rpvUninstallAudit.Image")));
            this.rpvUninstallAudit.ItemSize = new System.Drawing.SizeF(212F, 74F);
            this.rpvUninstallAudit.Name = "rpvUninstallAudit";
            // 
            // rbtnUninstallAuditing
            // 
            resources.ApplyResources(this.rbtnUninstallAuditing, "rbtnUninstallAuditing");
            this.rbtnUninstallAuditing.Name = "rbtnUninstallAuditing";
            // 
            // 
            // 
            this.rbtnUninstallAuditing.RootElement.AccessibleDescription = null;
            this.rbtnUninstallAuditing.RootElement.AccessibleName = null;
            this.rbtnUninstallAuditing.Click += new System.EventHandler(this.rbtnUninstallAuditing_Click);
            // 
            // lblUninstallInfo
            // 
            resources.ApplyResources(this.lblUninstallInfo, "lblUninstallInfo");
            this.lblUninstallInfo.Name = "lblUninstallInfo";
            // 
            // rpvUsers
            // 
            resources.ApplyResources(this.rpvUsers, "rpvUsers");
            this.rpvUsers.Controls.Add(this.chbChangePassword);
            this.rpvUsers.Controls.Add(this.lblPasswordInfo);
            this.rpvUsers.Controls.Add(this.rbtnDelete);
            this.rpvUsers.Controls.Add(this.rbtnEdit);
            this.rpvUsers.Controls.Add(this.dgvAuditUsers);
            this.rpvUsers.Controls.Add(this.txtPassword2);
            this.rpvUsers.Controls.Add(this.lblRePassword);
            this.rpvUsers.Controls.Add(this.rbtnReset);
            this.rpvUsers.Controls.Add(this.rbtnSearchPerson);
            this.rpvUsers.Controls.Add(this.txtPassword1);
            this.rpvUsers.Controls.Add(this.lblPassword);
            this.rpvUsers.Controls.Add(this.rbtnConfirm);
            this.rpvUsers.Controls.Add(this.txtSurname);
            this.rpvUsers.Controls.Add(this.txtName);
            this.rpvUsers.Controls.Add(this.txtUsername);
            this.rpvUsers.Controls.Add(this.chbAccessAlmisViewer);
            this.rpvUsers.Controls.Add(this.lblSurname);
            this.rpvUsers.Controls.Add(this.lblName);
            this.rpvUsers.Controls.Add(this.lblUserName);
            this.rpvUsers.Image = ((System.Drawing.Image)(resources.GetObject("rpvUsers.Image")));
            this.rpvUsers.ItemSize = new System.Drawing.SizeF(212F, 74F);
            this.rpvUsers.Name = "rpvUsers";
            // 
            // chbChangePassword
            // 
            resources.ApplyResources(this.chbChangePassword, "chbChangePassword");
            this.chbChangePassword.Name = "chbChangePassword";
            this.chbChangePassword.UseVisualStyleBackColor = true;
            this.chbChangePassword.CheckedChanged += new System.EventHandler(this.chbChangePassword_CheckedChanged);
            // 
            // lblPasswordInfo
            // 
            resources.ApplyResources(this.lblPasswordInfo, "lblPasswordInfo");
            this.lblPasswordInfo.Name = "lblPasswordInfo";
            // 
            // rbtnDelete
            // 
            resources.ApplyResources(this.rbtnDelete, "rbtnDelete");
            this.rbtnDelete.Name = "rbtnDelete";
            // 
            // 
            // 
            this.rbtnDelete.RootElement.AccessibleDescription = null;
            this.rbtnDelete.RootElement.AccessibleName = null;
            this.rbtnDelete.Click += new System.EventHandler(this.rbtnDelete_Click);
            // 
            // rbtnEdit
            // 
            resources.ApplyResources(this.rbtnEdit, "rbtnEdit");
            this.rbtnEdit.Name = "rbtnEdit";
            // 
            // 
            // 
            this.rbtnEdit.RootElement.AccessibleDescription = null;
            this.rbtnEdit.RootElement.AccessibleName = null;
            this.rbtnEdit.Click += new System.EventHandler(this.rbtnEdit_Click);
            // 
            // dgvAuditUsers
            // 
            resources.ApplyResources(this.dgvAuditUsers, "dgvAuditUsers");
            this.dgvAuditUsers.AllowUserToAddRows = false;
            this.dgvAuditUsers.AllowUserToDeleteRows = false;
            this.dgvAuditUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditUsers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAuditUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gvUsername,
            this.gvName,
            this.gvSurname,
            this.gvCanAccess});
            this.dgvAuditUsers.Name = "dgvAuditUsers";
            this.dgvAuditUsers.ReadOnly = true;
            this.dgvAuditUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditUsers_CellClick);
            this.dgvAuditUsers.DoubleClick += new System.EventHandler(this.dgvAuditUsers_DoubleClick);
            // 
            // gvUsername
            // 
            this.gvUsername.DataPropertyName = "Username";
            resources.ApplyResources(this.gvUsername, "gvUsername");
            this.gvUsername.Name = "gvUsername";
            this.gvUsername.ReadOnly = true;
            // 
            // gvName
            // 
            this.gvName.DataPropertyName = "Name";
            resources.ApplyResources(this.gvName, "gvName");
            this.gvName.Name = "gvName";
            this.gvName.ReadOnly = true;
            // 
            // gvSurname
            // 
            this.gvSurname.DataPropertyName = "Surname";
            resources.ApplyResources(this.gvSurname, "gvSurname");
            this.gvSurname.Name = "gvSurname";
            this.gvSurname.ReadOnly = true;
            // 
            // gvCanAccess
            // 
            this.gvCanAccess.DataPropertyName = "CanAccess";
            resources.ApplyResources(this.gvCanAccess, "gvCanAccess");
            this.gvCanAccess.Name = "gvCanAccess";
            this.gvCanAccess.ReadOnly = true;
            // 
            // txtPassword2
            // 
            resources.ApplyResources(this.txtPassword2, "txtPassword2");
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.ReadOnly = true;
            this.txtPassword2.UseSystemPasswordChar = true;
            // 
            // lblRePassword
            // 
            resources.ApplyResources(this.lblRePassword, "lblRePassword");
            this.lblRePassword.Name = "lblRePassword";
            // 
            // rbtnReset
            // 
            resources.ApplyResources(this.rbtnReset, "rbtnReset");
            this.rbtnReset.Name = "rbtnReset";
            // 
            // 
            // 
            this.rbtnReset.RootElement.AccessibleDescription = null;
            this.rbtnReset.RootElement.AccessibleName = null;
            this.rbtnReset.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // rbtnSearchPerson
            // 
            resources.ApplyResources(this.rbtnSearchPerson, "rbtnSearchPerson");
            this.rbtnSearchPerson.Name = "rbtnSearchPerson";
            // 
            // 
            // 
            this.rbtnSearchPerson.RootElement.AccessibleDescription = null;
            this.rbtnSearchPerson.RootElement.AccessibleName = null;
            this.rbtnSearchPerson.Click += new System.EventHandler(this.rbtnSearchPerson_Click);
            // 
            // txtPassword1
            // 
            resources.ApplyResources(this.txtPassword1, "txtPassword1");
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.ReadOnly = true;
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // rbtnConfirm
            // 
            resources.ApplyResources(this.rbtnConfirm, "rbtnConfirm");
            this.rbtnConfirm.Name = "rbtnConfirm";
            // 
            // 
            // 
            this.rbtnConfirm.RootElement.AccessibleDescription = null;
            this.rbtnConfirm.RootElement.AccessibleName = null;
            this.rbtnConfirm.Click += new System.EventHandler(this.rbtnConfirm_Click);
            // 
            // txtSurname
            // 
            resources.ApplyResources(this.txtSurname, "txtSurname");
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // chbAccessAlmisViewer
            // 
            resources.ApplyResources(this.chbAccessAlmisViewer, "chbAccessAlmisViewer");
            this.chbAccessAlmisViewer.Name = "chbAccessAlmisViewer";
            this.chbAccessAlmisViewer.UseVisualStyleBackColor = true;
            // 
            // lblSurname
            // 
            resources.ApplyResources(this.lblSurname, "lblSurname");
            this.lblSurname.Name = "lblSurname";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // rmiFile
            // 
            this.rmiFile.AccessibleDescription = "File";
            resources.ApplyResources(this.rmiFile, "rmiFile");
            this.rmiFile.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.rmiDisconnect,
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
            // radMenu1
            // 
            resources.ApplyResources(this.radMenu1, "radMenu1");
            chordModifier1.AltModifier = false;
            chordModifier1.ControlModifier = false;
            chordModifier1.ShiftModifier = false;
            chord1.ChordModifier = chordModifier1;
            chord1.Keys = "F1";
            inputBinding1.Chord = chord1;
            clickCommand1.ContextType = null;
            clickCommand1.ImageList = null;
            clickCommand1.Name = "ActionCommand";
            clickCommand1.OwnerType = typeof(Telerik.WinControls.RadItem);
            clickCommand1.Text = "This command rises the Click event of a selected RadItem instance.";
            clickCommand1.Type = "";
            inputBinding1.Command = clickCommand1;
            inputBinding1.CommandContext = this.rmiContents;
            chordModifier2.AltModifier = false;
            chordModifier2.ControlModifier = true;
            chordModifier2.ShiftModifier = false;
            chord2.ChordModifier = chordModifier2;
            chord2.Keys = "Ctrl+L";
            inputBinding2.Chord = chord2;
            inputBinding2.Command = clickCommand1;
            inputBinding2.CommandContext = this.rmiDisconnect;
            chordModifier3.AltModifier = true;
            chordModifier3.ControlModifier = false;
            chordModifier3.ShiftModifier = false;
            chord3.ChordModifier = chordModifier3;
            chord3.Keys = "Alt+X";
            inputBinding3.Chord = chord3;
            inputBinding3.Command = clickCommand1;
            inputBinding3.CommandContext = this.rmiExit;
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
            this.radMenu1.Name = "radMenu1";
            // 
            // rgvAuditUsers
            // 
            this.rgvAuditUsers.AllowRowResize = false;
            this.rgvAuditUsers.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            resources.ApplyResources(this.rgvAuditUsers, "rgvAuditUsers");
            this.rgvAuditUsers.ViewDefinition = tableViewDefinition2;
            // 
            // AlmisManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.rpvAlmisManager);
            this.Name = "AlmisManager";
            // 
            // 
            // 
            this.RootElement.AccessibleDescription = null;
            this.RootElement.AccessibleName = null;
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "ControlDefault";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AlmisManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpvAlmisManager)).EndInit();
            this.rpvAlmisManager.ResumeLayout(false);
            this.rpvPrerequirements.ResumeLayout(false);
            this.rpvPrerequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnInstallPrerequirements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDatabase)).EndInit();
            this.rgbDatabase.ResumeLayout(false);
            this.rpvAuditSetup.ResumeLayout(false);
            this.rpvAuditSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnRestoreToDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView2)).EndInit();
            this.radPageView2.ResumeLayout(false);
            this.rpvColumns.ResumeLayout(false);
            this.rpvColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumns)).EndInit();
            this.rpvTriggers.ResumeLayout(false);
            this.rpvTriggers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriggers)).EndInit();
            this.rpvBuildTriggers.ResumeLayout(false);
            this.rpvBuildTriggers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnRebuildAuditTriggers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbBuildTriggersFor)).EndInit();
            this.rgbBuildTriggersFor.ResumeLayout(false);
            this.rgbBuildTriggersFor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rmcbSelectTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbAllTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbSingelTable)).EndInit();
            this.rpvArchiveLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbtnDeleteAuditLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgbDeleteAuditLog)).EndInit();
            this.rgbDeleteAuditLog.ResumeLayout(false);
            this.rgbDeleteAuditLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpTimeDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpDateDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbIntervalDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbDateDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnArchiveAuditLogData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtpArchiveTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdtpArchiveDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbIntervalArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rrbDateArchive)).EndInit();
            this.rpvUninstallAudit.ResumeLayout(false);
            this.rpvUninstallAudit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnUninstallAuditing)).EndInit();
            this.rpvUsers.ResumeLayout(false);
            this.rpvUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSearchPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvAuditUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView rpvAlmisManager;
        private Telerik.WinControls.UI.RadPageViewPage rpvAuditSetup;
        private Telerik.WinControls.UI.RadPageViewPage rpvPrerequirements;
        private Telerik.WinControls.UI.RadPageViewPage rpvBuildTriggers;
        private Telerik.WinControls.UI.RadPageViewPage rpvArchiveLog;
        private Telerik.WinControls.UI.RadPageViewPage rpvUninstallAudit;
        private Telerik.WinControls.UI.RadMenuItem rmiHelp;
        private Telerik.WinControls.UI.RadMenuItem rmiContents;
        private Telerik.WinControls.UI.RadMenuItem rmiAbout;
        private Telerik.WinControls.UI.RadPageView radPageView2;
        private System.Windows.Forms.CheckBox chbAuditAllDeleted;
        private System.Windows.Forms.CheckBox chbAuditAllUpdated;
        private System.Windows.Forms.CheckBox chbAuditAllInserted;
        private System.Windows.Forms.CheckBox chbAuditAll;
        private Telerik.WinControls.UI.RadPageViewPage rpvColumns;
        private System.Windows.Forms.CheckBox chbAllColumns;
        private System.Windows.Forms.Label lblColumnsInfo;
        private Telerik.WinControls.UI.RadPageViewPage rpvTriggers;
        private System.Windows.Forms.Label lblTriggerInfo1;
        private System.Windows.Forms.Label lblTriggerInfo2;
        private System.Windows.Forms.Label lblInfoForAuditTables;
        private Telerik.WinControls.UI.RadButton rbtnInstallPrerequirements;
        private Telerik.WinControls.UI.RadGroupBox rgbDatabase;
        private Telerik.WinControls.UI.RadMultiColumnComboBox cbDatabase;
        private Telerik.WinControls.UI.RadGroupBox rgbBuildTriggersFor;
        private Telerik.WinControls.UI.RadRadioButton rrbAllTables;
        private Telerik.WinControls.UI.RadRadioButton rrbSingelTable;
        private Telerik.WinControls.UI.RadButton rbtnRebuildAuditTriggers;
        private System.Windows.Forms.Label lblCreateAuditingInfo;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.RadioButton rbYearArchive;
        private System.Windows.Forms.RadioButton rbMonthArchive;
        private System.Windows.Forms.NumericUpDown nupArchive;
        private Telerik.WinControls.UI.RadTimePicker rtpArchiveTime;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpArchiveDate;
        private Telerik.WinControls.UI.RadRadioButton rrbIntervalArchive;
        private Telerik.WinControls.UI.RadRadioButton rrbDateArchive;
        private System.Windows.Forms.Label lblArchiveAuditLog;
        private Telerik.WinControls.UI.RadButton rbtnArchiveAuditLogData;
        private System.Windows.Forms.Label lblUninstallInfo;
        private Telerik.WinControls.UI.RadButton rbtnUninstallAuditing;
        private Telerik.WinControls.UI.RadMenuItem rmiFile;
        private Telerik.WinControls.UI.RadMenuItem rmiDisconnect;
        private Telerik.WinControls.UI.RadMenuItem rmiExit;
        private Telerik.WinControls.UI.RadButton rbtnDeleteAuditLog;
        private Telerik.WinControls.UI.RadGroupBox rgbDeleteAuditLog;
        private System.Windows.Forms.Label lblDeleteAuditLog;
        private System.Windows.Forms.RadioButton rbYearDelete;
        private System.Windows.Forms.RadioButton rbMonthDelete;
        private System.Windows.Forms.NumericUpDown nudDelete;
        private Telerik.WinControls.UI.RadTimePicker rtpTimeDelete;
        private Telerik.WinControls.UI.RadDateTimePicker rdtpDateDelete;
        private Telerik.WinControls.UI.RadRadioButton rrbIntervalDelete;
        private Telerik.WinControls.UI.RadRadioButton rrbDateDelete;
        private Telerik.WinControls.UI.RadButton rbtnRestoreToDefault;
        private Telerik.WinControls.UI.RadPageViewPage rpvUsers;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label lblPassword;
        private Telerik.WinControls.UI.RadButton rbtnConfirm;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chbAccessAlmisViewer;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserName;
        private Telerik.WinControls.UI.RadButton rbtnSearchPerson;
        private Telerik.WinControls.UI.RadButton rbtnReset;
        private System.Windows.Forms.Label lblDeletedDate;
        private System.Windows.Forms.Label lblArchivedDate;
        private System.Windows.Forms.Label lblPrerequirementsMsg;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.DataGridView dgvColumns;
        private System.Windows.Forms.DataGridView dgvTriggers;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AuditColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private Telerik.WinControls.UI.RadDropDownList rmcbSelectTable;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblRePassword;
        private Telerik.WinControls.UI.MasterGridViewTemplate rgvAuditUsers;
        private System.Windows.Forms.DataGridView dgvAuditUsers;
        private Telerik.WinControls.UI.RadButton rbtnDelete;
        private Telerik.WinControls.UI.RadButton rbtnEdit;
        private System.Windows.Forms.Label lblPasswordInfo;
        private System.Windows.Forms.CheckBox chbChangePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableSchema;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AuditTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AuditInserts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AuditUpdates;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AuditDeletes;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableSchema1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn TriggerName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gvSurname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gvCanAccess;
    }
}
