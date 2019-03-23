namespace ALMIS.Viewer
{
    partial class DateFilterForm
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
            this.nupFromWeek = new System.Windows.Forms.NumericUpDown();
            this.nupToWeek = new System.Windows.Forms.NumericUpDown();
            this.lblFromWeek = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblToWeek = new System.Windows.Forms.Label();
            this.lblYearFrom = new System.Windows.Forms.Label();
            this.nupToYear = new System.Windows.Forms.NumericUpDown();
            this.nupFromYear = new System.Windows.Forms.NumericUpDown();
            this.lblYearTo = new System.Windows.Forms.Label();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.lblDayOfWeek = new System.Windows.Forms.Label();
            this.lblCurrenDayOfWeekInfo = new System.Windows.Forms.Label();
            this.lblDayOfMonth = new System.Windows.Forms.Label();
            this.lblCUrrentDayOfMonthInfo = new System.Windows.Forms.Label();
            this.lblDayOfYear = new System.Windows.Forms.Label();
            this.lblDayOfYearInfo = new System.Windows.Forms.Label();
            this.lblCurrentWeek = new System.Windows.Forms.Label();
            this.lblCurrentWeekInfo = new System.Windows.Forms.Label();
            this.lblCurrentMonth = new System.Windows.Forms.Label();
            this.lblCurrentMonthInfo = new System.Windows.Forms.Label();
            this.lblCurrentYear = new System.Windows.Forms.Label();
            this.lblCurrentYearInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupFromWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFromYear)).BeginInit();
            this.gbFilters.SuspendLayout();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // nupFromWeek
            // 
            this.nupFromWeek.Location = new System.Drawing.Point(27, 107);
            this.nupFromWeek.Maximum = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.nupFromWeek.Name = "nupFromWeek";
            this.nupFromWeek.Size = new System.Drawing.Size(70, 22);
            this.nupFromWeek.TabIndex = 2;
            // 
            // nupToWeek
            // 
            this.nupToWeek.Location = new System.Drawing.Point(27, 151);
            this.nupToWeek.Maximum = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.nupToWeek.Name = "nupToWeek";
            this.nupToWeek.Size = new System.Drawing.Size(70, 22);
            this.nupToWeek.TabIndex = 3;
            // 
            // lblFromWeek
            // 
            this.lblFromWeek.AutoSize = true;
            this.lblFromWeek.Location = new System.Drawing.Point(19, 87);
            this.lblFromWeek.Name = "lblFromWeek";
            this.lblFromWeek.Size = new System.Drawing.Size(69, 13);
            this.lblFromWeek.TabIndex = 4;
            this.lblFromWeek.Text = "From Week:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.Location = new System.Drawing.Point(12, 211);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(190, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblToWeek
            // 
            this.lblToWeek.AutoSize = true;
            this.lblToWeek.Location = new System.Drawing.Point(19, 135);
            this.lblToWeek.Name = "lblToWeek";
            this.lblToWeek.Size = new System.Drawing.Size(54, 13);
            this.lblToWeek.TabIndex = 7;
            this.lblToWeek.Text = "To Week:";
            // 
            // lblYearFrom
            // 
            this.lblYearFrom.AutoSize = true;
            this.lblYearFrom.Location = new System.Drawing.Point(147, 87);
            this.lblYearFrom.Name = "lblYearFrom";
            this.lblYearFrom.Size = new System.Drawing.Size(62, 13);
            this.lblYearFrom.TabIndex = 10;
            this.lblYearFrom.Text = "From Year:";
            // 
            // nupToYear
            // 
            this.nupToYear.Location = new System.Drawing.Point(155, 151);
            this.nupToYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nupToYear.Name = "nupToYear";
            this.nupToYear.Size = new System.Drawing.Size(70, 22);
            this.nupToYear.TabIndex = 9;
            // 
            // nupFromYear
            // 
            this.nupFromYear.Location = new System.Drawing.Point(155, 107);
            this.nupFromYear.Maximum = new decimal(new int[] {
            2999,
            0,
            0,
            0});
            this.nupFromYear.Name = "nupFromYear";
            this.nupFromYear.Size = new System.Drawing.Size(70, 22);
            this.nupFromYear.TabIndex = 8;
            // 
            // lblYearTo
            // 
            this.lblYearTo.AutoSize = true;
            this.lblYearTo.Location = new System.Drawing.Point(147, 135);
            this.lblYearTo.Name = "lblYearTo";
            this.lblYearTo.Size = new System.Drawing.Size(47, 13);
            this.lblYearTo.TabIndex = 11;
            this.lblYearTo.Text = "To Year:";
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.lblFilterType);
            this.gbFilters.Controls.Add(this.rbMonth);
            this.gbFilters.Controls.Add(this.rbWeek);
            this.gbFilters.Controls.Add(this.lblToWeek);
            this.gbFilters.Controls.Add(this.lblYearTo);
            this.gbFilters.Controls.Add(this.lblYearFrom);
            this.gbFilters.Controls.Add(this.nupFromWeek);
            this.gbFilters.Controls.Add(this.nupToYear);
            this.gbFilters.Controls.Add(this.nupToWeek);
            this.gbFilters.Controls.Add(this.nupFromYear);
            this.gbFilters.Controls.Add(this.lblFromWeek);
            this.gbFilters.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbFilters.Location = new System.Drawing.Point(12, 12);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(253, 193);
            this.gbFilters.TabIndex = 12;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // lblFilterType
            // 
            this.lblFilterType.AutoSize = true;
            this.lblFilterType.Location = new System.Drawing.Point(24, 23);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(64, 13);
            this.lblFilterType.TabIndex = 14;
            this.lblFilterType.Text = "Filter Type:";
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(110, 44);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(61, 17);
            this.rbMonth.TabIndex = 13;
            this.rbMonth.Text = "Month";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbMonth_CheckedChanged);
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Checked = true;
            this.rbWeek.Location = new System.Drawing.Point(110, 21);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(54, 17);
            this.rbWeek.TabIndex = 12;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "Week";
            this.rbWeek.UseVisualStyleBackColor = true;
            this.rbWeek.CheckedChanged += new System.EventHandler(this.rbWeek_CheckedChanged);
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.lblDayOfWeek);
            this.gbInformation.Controls.Add(this.lblCurrenDayOfWeekInfo);
            this.gbInformation.Controls.Add(this.lblDayOfMonth);
            this.gbInformation.Controls.Add(this.lblCUrrentDayOfMonthInfo);
            this.gbInformation.Controls.Add(this.lblDayOfYear);
            this.gbInformation.Controls.Add(this.lblDayOfYearInfo);
            this.gbInformation.Controls.Add(this.lblCurrentWeek);
            this.gbInformation.Controls.Add(this.lblCurrentWeekInfo);
            this.gbInformation.Controls.Add(this.lblCurrentMonth);
            this.gbInformation.Controls.Add(this.lblCurrentMonthInfo);
            this.gbInformation.Controls.Add(this.lblCurrentYear);
            this.gbInformation.Controls.Add(this.lblCurrentYearInfo);
            this.gbInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbInformation.Location = new System.Drawing.Point(284, 12);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(206, 193);
            this.gbInformation.TabIndex = 13;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Information";
            // 
            // lblDayOfWeek
            // 
            this.lblDayOfWeek.AutoSize = true;
            this.lblDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lblDayOfWeek.Location = new System.Drawing.Point(146, 151);
            this.lblDayOfWeek.Name = "lblDayOfWeek";
            this.lblDayOfWeek.Size = new System.Drawing.Size(13, 13);
            this.lblDayOfWeek.TabIndex = 11;
            this.lblDayOfWeek.Text = "6";
            // 
            // lblCurrenDayOfWeekInfo
            // 
            this.lblCurrenDayOfWeekInfo.AutoSize = true;
            this.lblCurrenDayOfWeekInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCurrenDayOfWeekInfo.Location = new System.Drawing.Point(16, 151);
            this.lblCurrenDayOfWeekInfo.Name = "lblCurrenDayOfWeekInfo";
            this.lblCurrenDayOfWeekInfo.Size = new System.Drawing.Size(118, 13);
            this.lblCurrenDayOfWeekInfo.TabIndex = 10;
            this.lblCurrenDayOfWeekInfo.Text = "Current Day of Week:";
            // 
            // lblDayOfMonth
            // 
            this.lblDayOfMonth.AutoSize = true;
            this.lblDayOfMonth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lblDayOfMonth.Location = new System.Drawing.Point(146, 123);
            this.lblDayOfMonth.Name = "lblDayOfMonth";
            this.lblDayOfMonth.Size = new System.Drawing.Size(19, 13);
            this.lblDayOfMonth.TabIndex = 9;
            this.lblDayOfMonth.Text = "31";
            // 
            // lblCUrrentDayOfMonthInfo
            // 
            this.lblCUrrentDayOfMonthInfo.AutoSize = true;
            this.lblCUrrentDayOfMonthInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCUrrentDayOfMonthInfo.Location = new System.Drawing.Point(16, 123);
            this.lblCUrrentDayOfMonthInfo.Name = "lblCUrrentDayOfMonthInfo";
            this.lblCUrrentDayOfMonthInfo.Size = new System.Drawing.Size(125, 13);
            this.lblCUrrentDayOfMonthInfo.TabIndex = 8;
            this.lblCUrrentDayOfMonthInfo.Text = "Current Day of Month:";
            // 
            // lblDayOfYear
            // 
            this.lblDayOfYear.AutoSize = true;
            this.lblDayOfYear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lblDayOfYear.Location = new System.Drawing.Point(146, 97);
            this.lblDayOfYear.Name = "lblDayOfYear";
            this.lblDayOfYear.Size = new System.Drawing.Size(25, 13);
            this.lblDayOfYear.TabIndex = 7;
            this.lblDayOfYear.Text = "200";
            // 
            // lblDayOfYearInfo
            // 
            this.lblDayOfYearInfo.AutoSize = true;
            this.lblDayOfYearInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDayOfYearInfo.Location = new System.Drawing.Point(16, 97);
            this.lblDayOfYearInfo.Name = "lblDayOfYearInfo";
            this.lblDayOfYearInfo.Size = new System.Drawing.Size(111, 13);
            this.lblDayOfYearInfo.TabIndex = 6;
            this.lblDayOfYearInfo.Text = "Current Day of Year:";
            // 
            // lblCurrentWeek
            // 
            this.lblCurrentWeek.AutoSize = true;
            this.lblCurrentWeek.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lblCurrentWeek.Location = new System.Drawing.Point(146, 71);
            this.lblCurrentWeek.Name = "lblCurrentWeek";
            this.lblCurrentWeek.Size = new System.Drawing.Size(19, 13);
            this.lblCurrentWeek.TabIndex = 5;
            this.lblCurrentWeek.Text = "35";
            // 
            // lblCurrentWeekInfo
            // 
            this.lblCurrentWeekInfo.AutoSize = true;
            this.lblCurrentWeekInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCurrentWeekInfo.Location = new System.Drawing.Point(16, 71);
            this.lblCurrentWeekInfo.Name = "lblCurrentWeekInfo";
            this.lblCurrentWeekInfo.Size = new System.Drawing.Size(81, 13);
            this.lblCurrentWeekInfo.TabIndex = 4;
            this.lblCurrentWeekInfo.Text = "Current Week:";
            // 
            // lblCurrentMonth
            // 
            this.lblCurrentMonth.AutoSize = true;
            this.lblCurrentMonth.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lblCurrentMonth.Location = new System.Drawing.Point(146, 43);
            this.lblCurrentMonth.Name = "lblCurrentMonth";
            this.lblCurrentMonth.Size = new System.Drawing.Size(13, 13);
            this.lblCurrentMonth.TabIndex = 3;
            this.lblCurrentMonth.Text = "8";
            // 
            // lblCurrentMonthInfo
            // 
            this.lblCurrentMonthInfo.AutoSize = true;
            this.lblCurrentMonthInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCurrentMonthInfo.Location = new System.Drawing.Point(16, 48);
            this.lblCurrentMonthInfo.Name = "lblCurrentMonthInfo";
            this.lblCurrentMonthInfo.Size = new System.Drawing.Size(88, 13);
            this.lblCurrentMonthInfo.TabIndex = 2;
            this.lblCurrentMonthInfo.Text = "Current Month:";
            // 
            // lblCurrentYear
            // 
            this.lblCurrentYear.AutoSize = true;
            this.lblCurrentYear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
            this.lblCurrentYear.Location = new System.Drawing.Point(146, 18);
            this.lblCurrentYear.Name = "lblCurrentYear";
            this.lblCurrentYear.Size = new System.Drawing.Size(31, 13);
            this.lblCurrentYear.TabIndex = 1;
            this.lblCurrentYear.Text = "2013";
            // 
            // lblCurrentYearInfo
            // 
            this.lblCurrentYearInfo.AutoSize = true;
            this.lblCurrentYearInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCurrentYearInfo.Location = new System.Drawing.Point(16, 23);
            this.lblCurrentYearInfo.Name = "lblCurrentYearInfo";
            this.lblCurrentYearInfo.Size = new System.Drawing.Size(74, 13);
            this.lblCurrentYearInfo.TabIndex = 0;
            this.lblCurrentYearInfo.Text = "Current Year:";
            // 
            // DateFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 239);
            this.Controls.Add(this.gbInformation);
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "DateFilterForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "DateFilterForm";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.DateFilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupFromWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupFromYear)).EndInit();
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupFromWeek;
        private System.Windows.Forms.NumericUpDown nupToWeek;
        private System.Windows.Forms.Label lblFromWeek;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblToWeek;
        private System.Windows.Forms.Label lblYearFrom;
        private System.Windows.Forms.NumericUpDown nupToYear;
        private System.Windows.Forms.NumericUpDown nupFromYear;
        private System.Windows.Forms.Label lblYearTo;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Label lblDayOfWeek;
        private System.Windows.Forms.Label lblCurrenDayOfWeekInfo;
        private System.Windows.Forms.Label lblDayOfMonth;
        private System.Windows.Forms.Label lblCUrrentDayOfMonthInfo;
        private System.Windows.Forms.Label lblDayOfYear;
        private System.Windows.Forms.Label lblDayOfYearInfo;
        private System.Windows.Forms.Label lblCurrentWeek;
        private System.Windows.Forms.Label lblCurrentWeekInfo;
        private System.Windows.Forms.Label lblCurrentMonth;
        private System.Windows.Forms.Label lblCurrentMonthInfo;
        private System.Windows.Forms.Label lblCurrentYear;
        private System.Windows.Forms.Label lblCurrentYearInfo;
    }
}
