namespace ALMIS.Manager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblServerName = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblAuthentication = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cbAuthentication = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.rbtnCancel = new Telerik.WinControls.UI.RadButton();
            this.chbSaveServerOptions = new System.Windows.Forms.CheckBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.rbtnConnect = new Telerik.WinControls.UI.RadButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbAlbanian = new System.Windows.Forms.RadioButton();
            this.btnGetDatabase = new System.Windows.Forms.Button();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            resources.ApplyResources(this.lblServerName, "lblServerName");
            this.lblServerName.Name = "lblServerName";
            // 
            // lblDatabase
            // 
            resources.ApplyResources(this.lblDatabase, "lblDatabase");
            this.lblDatabase.Name = "lblDatabase";
            // 
            // lblAuthentication
            // 
            resources.ApplyResources(this.lblAuthentication, "lblAuthentication");
            this.lblAuthentication.Name = "lblAuthentication";
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // cbAuthentication
            // 
            this.cbAuthentication.FormattingEnabled = true;
            this.cbAuthentication.Items.AddRange(new object[] {
            resources.GetString("cbAuthentication.Items"),
            resources.GetString("cbAuthentication.Items1")});
            resources.ApplyResources(this.cbAuthentication, "cbAuthentication");
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.SelectedIndexChanged += new System.EventHandler(this.cbAuthentication_SelectedIndexChanged);
            // 
            // lblPassword
            // 
            resources.ApplyResources(this.lblPassword, "lblPassword");
            this.lblPassword.Name = "lblPassword";
            // 
            // txtServerName
            // 
            resources.ApplyResources(this.txtServerName, "txtServerName");
            this.txtServerName.Name = "txtServerName";
            // 
            // txtUsername
            // 
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // rbtnCancel
            // 
            resources.ApplyResources(this.rbtnCancel, "rbtnCancel");
            this.rbtnCancel.Name = "rbtnCancel";
            // 
            // 
            // 
            this.rbtnCancel.RootElement.AccessibleDescription = resources.GetString("rbtnCancel.RootElement.AccessibleDescription");
            this.rbtnCancel.RootElement.AccessibleName = resources.GetString("rbtnCancel.RootElement.AccessibleName");
            this.rbtnCancel.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("rbtnCancel.RootElement.Alignment")));
            this.rbtnCancel.RootElement.AngleTransform = ((float)(resources.GetObject("rbtnCancel.RootElement.AngleTransform")));
            this.rbtnCancel.RootElement.FlipText = ((bool)(resources.GetObject("rbtnCancel.RootElement.FlipText")));
            this.rbtnCancel.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("rbtnCancel.RootElement.Margin")));
            this.rbtnCancel.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("rbtnCancel.RootElement.Padding")));
            this.rbtnCancel.RootElement.Text = resources.GetString("rbtnCancel.RootElement.Text");
            this.rbtnCancel.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("rbtnCancel.RootElement.TextOrientation")));
            this.rbtnCancel.Click += new System.EventHandler(this.rbtnCancel_Click);
            // 
            // chbSaveServerOptions
            // 
            resources.ApplyResources(this.chbSaveServerOptions, "chbSaveServerOptions");
            this.chbSaveServerOptions.Name = "chbSaveServerOptions";
            this.chbSaveServerOptions.UseVisualStyleBackColor = true;
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.Name = "lblLanguage";
            // 
            // rbtnConnect
            // 
            resources.ApplyResources(this.rbtnConnect, "rbtnConnect");
            this.rbtnConnect.Name = "rbtnConnect";
            this.rbtnConnect.Click += new System.EventHandler(this.rbtnConnect_Click);
            // 
            // rbEnglish
            // 
            resources.ApplyResources(this.rbEnglish, "rbEnglish");
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.TabStop = true;
            this.rbEnglish.UseVisualStyleBackColor = true;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // rbAlbanian
            // 
            resources.ApplyResources(this.rbAlbanian, "rbAlbanian");
            this.rbAlbanian.Name = "rbAlbanian";
            this.rbAlbanian.TabStop = true;
            this.rbAlbanian.UseVisualStyleBackColor = true;
            this.rbAlbanian.CheckedChanged += new System.EventHandler(this.rbAlbanian_CheckedChanged);
            // 
            // btnGetDatabase
            // 
            resources.ApplyResources(this.btnGetDatabase, "btnGetDatabase");
            this.btnGetDatabase.Name = "btnGetDatabase";
            this.btnGetDatabase.UseVisualStyleBackColor = true;
            this.btnGetDatabase.Click += new System.EventHandler(this.btnGetDatabase_Click);
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            resources.ApplyResources(this.cbDatabases, "cbDatabases");
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Click += new System.EventHandler(this.cbDatabases_Click);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.btnGetDatabase);
            this.Controls.Add(this.rbAlbanian);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.rbtnConnect);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.chbSaveServerOptions);
            this.Controls.Add(this.rbtnCancel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cbAuthentication);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblAuthentication);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblServerName);
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.AccessibleDescription = resources.GetString("Login.RootElement.AccessibleDescription");
            this.RootElement.AccessibleName = resources.GetString("Login.RootElement.AccessibleName");
            this.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("Login.RootElement.Alignment")));
            this.RootElement.AngleTransform = ((float)(resources.GetObject("Login.RootElement.AngleTransform")));
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.FlipText = ((bool)(resources.GetObject("Login.RootElement.FlipText")));
            this.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("Login.RootElement.Margin")));
            this.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("Login.RootElement.Padding")));
            this.RootElement.Text = resources.GetString("Login.RootElement.Text");
            this.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("Login.RootElement.TextOrientation")));
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblAuthentication;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cbAuthentication;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private Telerik.WinControls.UI.RadButton rbtnCancel;
        private System.Windows.Forms.CheckBox chbSaveServerOptions;
        private System.Windows.Forms.Label lblLanguage;
        private Telerik.WinControls.UI.RadButton rbtnConnect;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbAlbanian;
        private System.Windows.Forms.Button btnGetDatabase;
        private System.Windows.Forms.ComboBox cbDatabases;
    }
}
