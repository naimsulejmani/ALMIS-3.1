using System;
using System.Configuration;
using System.Globalization;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;
using ALMIS.Manager.App_Code;
using BL = ALMIS.BusinessLogic.DataConnection;
using BLL = ALMIS.BusinessLogic.General;

namespace ALMIS.Manager
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        public Login()
        {
            InitializeComponent();
        }

        void Connect()
        {
            if (cbAuthentication.Text != @"Windows Authentication")
                BL.DefaultConnectionString =
                    String.Format("Server={0};Database={1};User Id={2};Password={3};Trusted_Connection=False;",
                                  txtServerName.Text, cbDatabases.Text, txtUsername.Text, txtPassword.Text);
            else
                BL.DefaultConnectionString =
                    String.Format("Server={0};Database={1};Trusted_Connection=True;",
                                  txtServerName.Text, cbDatabases.Text);


            if (chbSaveServerOptions.Checked)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["server"].Value = txtServerName.Text;
                config.AppSettings.Settings["database"].Value = cbDatabases.Text;
                config.AppSettings.Settings["save"].Value = "1";
                config.AppSettings.Settings["language"].Value = rbAlbanian.Checked ? "sq" : "en-US";
                config.Save(ConfigurationSaveMode.Modified);
            }
            else
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                config.AppSettings.Settings["server"].Value = "";
                config.AppSettings.Settings["database"].Value = "";
                config.AppSettings.Settings["save"].Value = "0";
                config.Save(ConfigurationSaveMode.Modified);
            }

            if (BL.CanConnect())
            {
                CurrentSettings.Database = cbDatabases.Text;
                CurrentSettings.UseriAktiv = txtUsername.Text;
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                var languageCode = config.AppSettings.Settings["language"].Value;
                var ci = new CultureInfo(languageCode);
                Thread.CurrentThread.CurrentCulture = ci;
                Thread.CurrentThread.CurrentUICulture = ci;
                var almis = new AlmisManager();
                Hide();
                almis.Text = almis.Text + @" -> DB: " + cbDatabases.Text;
                almis.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(@"Nuk keni qasje ne databaze.
 Ju lutem kontaktoni administratoret e sistemit...");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            txtServerName.Text = config.AppSettings.Settings["server"].Value;
            cbDatabases.Text = config.AppSettings.Settings["database"].Value;
            chbSaveServerOptions.Checked = config.AppSettings.Settings["save"].Value == "1";
            if (config.AppSettings.Settings["language"].Value == "sq")
            {
                rbAlbanian.Checked = true;
                LoginLanguages("alb");
            }
            else
            {
                rbEnglish.Checked = true;
                LoginLanguages("eng");
            }
            var windowsIdentity = WindowsIdentity.GetCurrent();
            if (windowsIdentity != null) txtUsername.Text = windowsIdentity.Name;
        }

        private void cbAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAuthentication.Text == @"SQL Server Authentication")
            {
                txtUsername.ReadOnly = false;
                txtPassword.ReadOnly = false;
                txtUsername.Text = "";
                txtUsername.Focus();
            }
            else
            {
                var windowsIdentity = WindowsIdentity.GetCurrent();
                if (windowsIdentity != null) txtUsername.Text = windowsIdentity.Name;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
            }
        }

        private void rbtnConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            LoginLanguages("eng");
        }

        private void LoginLanguages(string language)
        {
            if (language == "alb")
            {
                lblLanguage.Text = @"Gjuha:";
                lblServerName.Text = @"Emri Serverit:";
                lblDatabase.Text = @"Databaza:";
                lblAuthentication.Text = @"Authentikimi:";
                lblPassword.Text = @"Fjalekalimi:";
                lblUserName.Text = @"Perdoruesi:";
                rbAlbanian.Text = @"Shqip";
                rbEnglish.Text = @"Anglisht";
                rbtnCancel.Text = @"Anulo";
                rbtnConnect.Text = @"Konektohu";
                chbSaveServerOptions.Text = @"Ruaj opsionet e serverit";
            }
            else
            {
                lblLanguage.Text = @"Language:";
                lblServerName.Text = @"Server Name:";
                lblDatabase.Text = @"Database:";
                lblAuthentication.Text = @"Authentication:";
                lblPassword.Text = @"Password:";
                lblUserName.Text = @"Username:";
                rbAlbanian.Text = @"Albanian";
                rbEnglish.Text = @"English";
                rbtnCancel.Text = @"Cancel";
                rbtnConnect.Text = @"Connect";
                chbSaveServerOptions.Text = @"Save Server Options";
            }
        }

        private void rbAlbanian_CheckedChanged(object sender, EventArgs e)
        {
            LoginLanguages("alb");
        }

        private void rbtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGetDatabase_Click(object sender, EventArgs e)
        {
            GetDatabases();

        }

        void GetDatabases()
        {
            cbDatabases.DataSource = null;
            cbDatabases.Refresh();

            if (cbAuthentication.Text != @"Windows Authentication")
            {
                BL.DefaultConnectionString =
                    String.Format("Server={0};Database=master;User Id={1};Password={2};Trusted_Connection=False;",
                                  txtServerName.Text, txtUsername.Text, txtPassword.Text);
            }
            else
            {
                BL.DefaultConnectionString =
                    String.Format("Server={0};Database={1};Trusted_Connection=True;",
                                  txtServerName.Text, cbDatabases.Text);
            }

            if (BL.CanConnect())
            {
                cbDatabases.DataSource = BLL.GetDatabases();
                cbDatabases.Refresh();
            }
        }

        private void cbDatabases_Click(object sender, EventArgs e)
        {
            if (cbDatabases.DataSource == null)
            {
                GetDatabases();
            }

        }
    }
}
