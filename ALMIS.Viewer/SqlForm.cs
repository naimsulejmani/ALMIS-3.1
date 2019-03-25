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

        private void loadConfiguration()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            cbAuthentication.Text = "SQL Server Authentication";
            txtServerName.Text = config.AppSettings.Settings["server"].Value;
            txtUsername.Text = config.AppSettings.Settings["user"].Value;
            txtPassword.Text = config.AppSettings.Settings["password"].Value;
            cbDatabases.Text = config.AppSettings.Settings["database"].Value;

        }
    }
}
