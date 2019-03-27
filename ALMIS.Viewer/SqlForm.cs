using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace ALMIS.Viewer
{
    public partial class SqlForm : Telerik.WinControls.UI.RadForm
    {
        public SqlForm()
        {
            InitializeComponent();
            loadConfiguration();
        }
        private Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
//        private static string _connectionString =ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        private void loadConfiguration()
        {


            txtServerName.Text = config.AppSettings.Settings["server"].Value;
            txtUsername.Text = config.AppSettings.Settings["user"].Value;
            txtPassword.Text = config.AppSettings.Settings["password"].Value;
            cbDatabases.Text = config.AppSettings.Settings["database"].Value;

        }

        private void rbtnSave_Click(object sender, EventArgs e)
        {
            if (txtServerName.Text.Trim() == "" || cbDatabases.Text.Trim() == "" || txtUsername.Text.Trim() == "" ||
                txtPassword.Text.Trim() == "")
            {
                return;
            }

            try
            {
                config.AppSettings.Settings["server"].Value = txtServerName.Text;
                config.AppSettings.Settings["user"].Value = txtUsername.Text;
                config.AppSettings.Settings["password"].Value = txtPassword.Text;
                config.AppSettings.Settings["database"].Value = cbDatabases.Text;

                config.ConnectionStrings.ConnectionStrings["cstr"].ConnectionString = GenerateConnectionString(txtServerName.Text, txtUsername.Text, txtUsername.Text, txtPassword.Text);
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("U ruajt ndryshimi");
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Deshtoi ryajtja e ndryshimit");
            }
        }

        private void rbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string GenerateConnectionString(string serverName, string database, string user, string password)
        {
            return $"Server={serverName};Database={database};Persist Security Info=True;User ID={user};Password={password};MultipleActiveResultSets=True";
        }
    }
}
