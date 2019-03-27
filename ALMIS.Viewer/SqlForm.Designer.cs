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
            this.rbtnSave = new Telerik.WinControls.UI.RadButton();
            this.rbtnCancel = new Telerik.WinControls.UI.RadButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(115, 110);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(195, 21);
            this.cbDatabases.TabIndex = 34;
            // 
            // btnGetDatabase
            // 
            this.btnGetDatabase.Image = ((System.Drawing.Image)(resources.GetObject("btnGetDatabase.Image")));
            this.btnGetDatabase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetDatabase.Location = new System.Drawing.Point(317, 108);
            this.btnGetDatabase.Name = "btnGetDatabase";
            this.btnGetDatabase.Size = new System.Drawing.Size(21, 23);
            this.btnGetDatabase.TabIndex = 33;
            this.btnGetDatabase.UseVisualStyleBackColor = true;
            // 
            // rbtnSave
            // 
            this.rbtnSave.Location = new System.Drawing.Point(3, 163);
            this.rbtnSave.Name = "rbtnSave";
            this.rbtnSave.Size = new System.Drawing.Size(129, 24);
            this.rbtnSave.TabIndex = 23;
            this.rbtnSave.Text = "Save";
            this.rbtnSave.Click += new System.EventHandler(this.rbtnSave_Click);
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.Location = new System.Drawing.Point(218, 163);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(119, 24);
            this.rbtnCancel.TabIndex = 24;
            this.rbtnCancel.Text = "Cancel";
            this.rbtnCancel.Click += new System.EventHandler(this.rbtnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(115, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 20);
            this.txtPassword.TabIndex = 21;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(115, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(222, 20);
            this.txtUsername.TabIndex = 20;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(115, 26);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(222, 20);
            this.txtServerName.TabIndex = 18;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(0, 86);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 13);
            this.lblPassword.TabIndex = 32;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(0, 56);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(65, 13);
            this.lblUserName.TabIndex = 31;
            this.lblUserName.Text = "User Name:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDatabase.Location = new System.Drawing.Point(0, 116);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(58, 13);
            this.lblDatabase.TabIndex = 29;
            this.lblDatabase.Text = "Database:";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblServerName.Location = new System.Drawing.Point(0, 25);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(73, 13);
            this.lblServerName.TabIndex = 28;
            this.lblServerName.Text = "Server Name:";
            // 
            // SqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 195);
            this.Controls.Add(this.cbDatabases);
            this.Controls.Add(this.btnGetDatabase);
            this.Controls.Add(this.rbtnSave);
            this.Controls.Add(this.rbtnCancel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblServerName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SqlForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Change SQL Login";
            ((System.ComponentModel.ISupportInitialize)(this.rbtnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Button btnGetDatabase;
        private Telerik.WinControls.UI.RadButton rbtnSave;
        private Telerik.WinControls.UI.RadButton rbtnCancel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblServerName;
    }
}
