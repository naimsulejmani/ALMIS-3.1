namespace ALMIS.Manager
{
    partial class AlmisMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlmisMessageBox));
            this.chbIAgree = new System.Windows.Forms.CheckBox();
            this.lblConfirmMessage = new System.Windows.Forms.Label();
            this.rbtnYes = new Telerik.WinControls.UI.RadButton();
            this.rbtnNo = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // chbIAgree
            // 
            resources.ApplyResources(this.chbIAgree, "chbIAgree");
            this.chbIAgree.Name = "chbIAgree";
            this.chbIAgree.UseVisualStyleBackColor = true;
            this.chbIAgree.CheckedChanged += new System.EventHandler(this.chbIAgree_CheckedChanged);
            // 
            // lblConfirmMessage
            // 
            resources.ApplyResources(this.lblConfirmMessage, "lblConfirmMessage");
            this.lblConfirmMessage.Name = "lblConfirmMessage";
            // 
            // rbtnYes
            // 
            resources.ApplyResources(this.rbtnYes, "rbtnYes");
            this.rbtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.rbtnYes.Name = "rbtnYes";
            // 
            // 
            // 
            this.rbtnYes.RootElement.AccessibleDescription = resources.GetString("rbtnYes.RootElement.AccessibleDescription");
            this.rbtnYes.RootElement.AccessibleName = resources.GetString("rbtnYes.RootElement.AccessibleName");
            this.rbtnYes.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("rbtnYes.RootElement.Alignment")));
            this.rbtnYes.RootElement.AngleTransform = ((float)(resources.GetObject("rbtnYes.RootElement.AngleTransform")));
            this.rbtnYes.RootElement.FlipText = ((bool)(resources.GetObject("rbtnYes.RootElement.FlipText")));
            this.rbtnYes.RootElement.KeyTip = resources.GetString("rbtnYes.RootElement.KeyTip");
            this.rbtnYes.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("rbtnYes.RootElement.Margin")));
            this.rbtnYes.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("rbtnYes.RootElement.Padding")));
            this.rbtnYes.RootElement.Text = resources.GetString("rbtnYes.RootElement.Text");
            this.rbtnYes.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("rbtnYes.RootElement.TextOrientation")));
            this.rbtnYes.RootElement.ToolTipText = resources.GetString("rbtnYes.RootElement.ToolTipText");
            this.rbtnYes.Click += new System.EventHandler(this.rbtnOK_Click);
            // 
            // rbtnNo
            // 
            resources.ApplyResources(this.rbtnNo, "rbtnNo");
            this.rbtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.rbtnNo.Name = "rbtnNo";
            // 
            // 
            // 
            this.rbtnNo.RootElement.AccessibleDescription = resources.GetString("rbtnNo.RootElement.AccessibleDescription");
            this.rbtnNo.RootElement.AccessibleName = resources.GetString("rbtnNo.RootElement.AccessibleName");
            this.rbtnNo.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("rbtnNo.RootElement.Alignment")));
            this.rbtnNo.RootElement.AngleTransform = ((float)(resources.GetObject("rbtnNo.RootElement.AngleTransform")));
            this.rbtnNo.RootElement.FlipText = ((bool)(resources.GetObject("rbtnNo.RootElement.FlipText")));
            this.rbtnNo.RootElement.KeyTip = resources.GetString("rbtnNo.RootElement.KeyTip");
            this.rbtnNo.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("rbtnNo.RootElement.Margin")));
            this.rbtnNo.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("rbtnNo.RootElement.Padding")));
            this.rbtnNo.RootElement.Text = resources.GetString("rbtnNo.RootElement.Text");
            this.rbtnNo.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("rbtnNo.RootElement.TextOrientation")));
            this.rbtnNo.RootElement.ToolTipText = resources.GetString("rbtnNo.RootElement.ToolTipText");
            this.rbtnNo.Click += new System.EventHandler(this.rbtnNo_Click);
            // 
            // AlmisMessageBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.rbtnYes);
            this.Controls.Add(this.lblConfirmMessage);
            this.Controls.Add(this.chbIAgree);
            this.Name = "AlmisMessageBox";
            // 
            // 
            // 
            this.RootElement.AccessibleDescription = resources.GetString("AlmisMessageBox.RootElement.AccessibleDescription");
            this.RootElement.AccessibleName = resources.GetString("AlmisMessageBox.RootElement.AccessibleName");
            this.RootElement.Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("AlmisMessageBox.RootElement.Alignment")));
            this.RootElement.AngleTransform = ((float)(resources.GetObject("AlmisMessageBox.RootElement.AngleTransform")));
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.FlipText = ((bool)(resources.GetObject("AlmisMessageBox.RootElement.FlipText")));
            this.RootElement.KeyTip = resources.GetString("AlmisMessageBox.RootElement.KeyTip");
            this.RootElement.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("AlmisMessageBox.RootElement.Margin")));
            this.RootElement.Padding = ((System.Windows.Forms.Padding)(resources.GetObject("AlmisMessageBox.RootElement.Padding")));
            this.RootElement.Text = resources.GetString("AlmisMessageBox.RootElement.Text");
            this.RootElement.TextOrientation = ((System.Windows.Forms.Orientation)(resources.GetObject("AlmisMessageBox.RootElement.TextOrientation")));
            this.RootElement.ToolTipText = resources.GetString("AlmisMessageBox.RootElement.ToolTipText");
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.AlmisMessageBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rbtnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbtnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbIAgree;
        private System.Windows.Forms.Label lblConfirmMessage;
        private Telerik.WinControls.UI.RadButton rbtnYes;
        private Telerik.WinControls.UI.RadButton rbtnNo;
    }
}
