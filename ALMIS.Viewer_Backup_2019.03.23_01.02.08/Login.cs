using System;
using System.Configuration;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BE = ALMIS.BusinessEntities.AuditUsers;
using BL = ALMIS.BusinessLogic.AuditUsers;

namespace ALMIS.Viewer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connect();
        }

        void Connect()
        {
            string language = cbLanguage.Text.Split('=')[1];
            if (language != "") LoadLanguages(language);

            var pwdByte = PasswordHash(txtPassword.Text.Trim());
            //  var pwdStrHash = Encoding.Unicode.GetString(pwdByte);
            var objUser = BL.FindBy(txtUsername.Text, pwdByte);
            if (objUser != null && objUser.Username != null)
            {
                //string hex = BitConverter.ToString(pwdByte);
                //hex = hex.Replace("-", "");
                //txtPassword.Text = hex;
                //txtUsername.Text = hex;
                var almisViewer = new AlmisViewer();
                Hide();
                almisViewer.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show(@"Useri nuk ka qasje ne ALMIS Viewer");
            }
        }
        private byte[] PasswordHash(string password)
        {
            byte[] source = Encoding.Unicode.GetBytes(password);
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] result = sha.ComputeHash(source);

            return result;
        }

        void LoadLanguages(string languageCode)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings["language"].Value = languageCode;
            config.Save(ConfigurationSaveMode.Modified);
            var ci = new CultureInfo(languageCode);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            switch (config.AppSettings.Settings["language"].Value)
            {
                case "sq":
                    cbLanguage.SelectedIndex = 0;
                    //LoadLanguages("sq");
                    break;
                case "en-US":
                    cbLanguage.SelectedIndex = 1;
                    //LoadLanguages("en-US");
                    break;
                default:
                    cbLanguage.SelectedIndex = -1;
                    break;
            }
            LoginLanguage(config.AppSettings.Settings["language"].Value);
        }

        private void LoginLanguage(string language)
        {
            if (language == "sq")
            {
                lblUsername.Text = @"Përdoruesi:";
                lblPassword.Text = @"Fjalëkalimi:";
                btnLogin.Text = @"Qasu";
                btnCancel.Text = @"Anulo";
                lblLanguage.Text = @"Gjuha";
                Text = @"Qasu";
            }
            else
            {
                lblUsername.Text = @"Username:";
                lblPassword.Text = @"Password:";
                btnLogin.Text = @"Login";
                btnCancel.Text = @"Cancel";
                lblLanguage.Text = @"Language";
                Text = @"Login";
            }
        }
        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string language = cbLanguage.Text.Split('=')[1];
            LoginLanguage(language);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Connect();
            }
        }

    }
}
