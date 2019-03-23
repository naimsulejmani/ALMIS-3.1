using System;
using System.Windows.Forms;
using ALMIS.Manager.App_Code;
using BL = ALMIS.BusinessLogic;

namespace ALMIS.Manager
{
    public partial class AlmisMessageBox : Telerik.WinControls.UI.RadForm
    {
        public AlmisMessageBox()
        {
            InitializeComponent();
        }

        public string Caption { get; set; }
        public string Message { get; set; }
        public string AgreeMessage { get; set; }
        public bool ShowNoButton { get; set; }
        public bool ShowAgreeMessage { get; set; }
        // ReSharper disable InconsistentNaming
        public bool IAgree { get; set; }
        // ReSharper restore InconsistentNaming

        private void rbtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbtnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbIAgree_CheckedChanged(object sender, EventArgs e)
        {
            IAgree = chbIAgree.Checked;
        }

        private void AlmisMessageBox_Load(object sender, EventArgs e)
        {
            rbtnNo.Visible = ShowNoButton;
            chbIAgree.Visible = ShowAgreeMessage;
            chbIAgree.Text = AgreeMessage;
            lblConfirmMessage.Text = Message;
            Text = Caption;
        }
    }
}
