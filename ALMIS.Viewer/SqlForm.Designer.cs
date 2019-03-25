namespace ALMIS.Viewer
{
    partial class SqlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlForm));
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.btnGetDatabase = new System.Windows.Forms.Button();
            this.rbAlbanian = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbtnConnect = new Telerik.WinControls.UI.RadButton();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.chbSaveServerOptions = new System.Windows.Forms.CheckBox();
            this.rbtnCancel = new Telerik.WinControls.UI.RadButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbAuthentication = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAuthentication = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(115, 162);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(195, 21);
            this.cbDatabases.TabIndex = 34;
            // 
            // btnGetDatabase
            // 
            this.btnGetDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnGetDatabase.Image")));
            this.btnGetDatabase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetDatabase.Location = new System.Drawing.Point(317, 160);
            this.btnGetDatabase.Name = "btnGetDatabase";
            this.btnGetDatabase.Size = new System.Drawing.Size(21, 23);
            this.btnGetDatabase.TabIndex = 33;
            this.btnGetDatabase.UseVisualStyleBackColor = true;
            // 
            // rbAlbanian
            // 
            this.rbAlbanian.AutoSize = true;
            this.rbAlbanian.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbAlbanian.Location = new System.Drawing.Point(243, 16);
            this.rbAlbanian.Name = "rbAlbanian";
            this.rbAlbanian.Size = new System.Drawing.Size(71, 17);
            this.rbAlbanian.TabIndex = 26;
            this.rbAlbanian.TabStop = true;
            this.rbAlbanian.Text = "Albanian";
            this.rbAlbanian.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rbEnglish.Location = new System.Drawing.Point(115, 18);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(63, 17);
            this.rbEnglish.TabIndex = 25;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // rbtnConnect
            // 
            this.rbtnConnect.Location = new System.Drawing.Point(3, 229);
            this.rbtnConnect.Name = "rbtnConnect";
            this.rbtnConnect.Size = new System.Drawing.Size(129, 24);
            this.rbtnConnect.TabIndex = 23;
            this.rbtnConnect.Text = "Connect";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLanguage.Location = new System.Drawing.Point(0, 18);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(61, 13);
            this.lblLanguage.TabIndex = 27;
            this.lblLanguage.Text = "Language:";
            // 
            // chbSaveServerOptions
            // 
            this.chbSaveServerOptions.AutoSize = true;
            this.chbSaveServerOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chbSaveServerOptions.Location = new System.Drawing.Point(115, 195);
            this.chbSaveServerOptions.Name = "chbSaveServerOptions";
            this.chbSaveServerOptions.Size = new System.Drawing.Size(128, 17);
            this.chbSaveServerOptions.TabIndex = 22;
            this.chbSaveServerOptions.Text = "Save Server Options";
            this.chbSaveServerOptions.UseVisualStyleBackColor = true;
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.Location = new System.Drawing.Point(218, 229);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(119, 24);
            this.rbtnCancel.TabIndex = 24;
            this.rbtnCancel.Text = "Cancel";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 21;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 104);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(222, 20);
            this.txtUsername.TabIndex = 20;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(115, 45);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(222, 20);
            this.txtServerName.TabIndex = 18;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(0, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Password:";
            // 
            // cbAuthentication
            // 
            this.cbAuthentication.FormattingEnabled = true;
            this.cbAuthentication.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cbAuthentication.Location = new System.Drawing.Point(115, 74);
            this.cbAuthentication.Name = "cbAuthentication";
            this.cbAuthentication.Size = new System.Drawing.Size(222, 21);
            this.cbAuthentication.TabIndex = 19;
            this.cbAuthentication.Text = "Windows Authentication";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(0, 108);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 13);
            this.lblUserName.TabIndex = 31;
            this.lblUserName.Text = "User Name:";
            // 
            // lblAuthentication
            // 
            this.lblAuthentication.AutoSize = true;
            this.lblAuthentication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAuthentication.Location = new System.Drawing.Point(0, 78);
            this.lblAuthentication.Name = "lblAuthentication";
            this.lblAuthentication.Size = new System.Drawing.Size(87, 13);
            this.lblAuthentication.TabIndex = 30;
            this.lblAuthentication.Text = "Authentication:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatabase.Location = new System.Drawing.Point(0, 168);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(58, 13);
            this.lblDatabase.TabIndex = 29;
            this.lblDatabase.Text = "Database:";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblServerName.Location = new System.Drawing.Point(0, 48);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(73, 13);
            this.lblServerName.TabIndex = 28;
            this.lblServerName.Text = "Server Name:";
            // 
            // SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 259);
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
            this.Name = "SqlForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Change SQL Login";
            ((System.ComponentModel.ISupportInitialize)(this.rbtnConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Button btnGetDatabase;
        private System.Windows.Forms.RadioButton rbAlbanian;
        private System.Windows.Forms.RadioButton rbEnglish;
        private Telerik.WinControls.UI.RadButton rbtnConnect;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.CheckBox chbSaveServerOptions;
        private Telerik.WinControls.UI.RadButton rbtnCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cbAuthentication;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblAuthentication;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblServerName;
    }
}
