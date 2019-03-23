using System;
using System.Data;
using System.Windows.Forms;
using BL = ALMIS.BusinessLogic.General;

namespace ALMIS.Viewer.App_Code.UI
{
    public partial class FrmGeneralList : Form
    {
        public FrmGeneralList()
        {
            InitializeComponent();
        }

        public string FilterText { get; set; }
        public string Title { get; set; }
        public int Index { get; set; }
        public EnumGeneralList SelectedEnumrator { get; set; }
        public string TableName { get; set; }
        public string ColumName { get; set; }
        public string HostName { get; set; }
        public string ApplicationName { get; set; }
        public string RowKey { get; set; }
        public string UserName { get; set; }


        private void frmGeneralList_Load(object sender, EventArgs e)
        {
            Text = Title;
            SelectEnumGeneralList();
        }

        private void SelectEnumGeneralList()
        {
            switch (SelectedEnumrator)
            {
                case EnumGeneralList.Application:
                    SelectApplications();
                    break;
                case EnumGeneralList.Column:
                    SelectColumns();
                    break;
                case EnumGeneralList.RowKey:
                    SelectRowKeys();
                    break;
                case EnumGeneralList.Table:
                    SelectTables();
                    break;
                case EnumGeneralList.UserName:
                    SelectUserNames();
                    break;
                case EnumGeneralList.Workstation:
                    SelectWorkstations();
                    break;
            }
        }

        private void SelectWorkstations()
        {
            var hostNameList = BL.FindHostNames(FilterText);
            dgvGeneralList.DataSource = hostNameList;
        }

        private void SelectUserNames()
        {
            var userNameList = BL.FindUserNames(FilterText);
            dgvGeneralList.DataSource = userNameList;
        }

        private void SelectRowKeys()
        {
            var rowKeysList = BL.FindRowKeys(FilterText);
            dgvGeneralList.DataSource = rowKeysList;
        }

        private void SelectTables()
        {
            var tableList = BL.FindTables(FilterText);
            dgvGeneralList.DataSource = tableList;
        }

        private void SelectColumns()
        {
            var columnList = BL.FindColumns(FilterText);
            dgvGeneralList.DataSource = columnList;
        }

        private void SelectApplications()
        {
            var applicationList = BL.FindApplications(FilterText);
            dgvGeneralList.DataSource = applicationList;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectRecord();


        }

        private void dgvGeneralList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        private void dgvGeneralList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
            //btnOK_Click(new Button() { DialogResult = DialogResult.OK }, new EventArgs());
            SelectRecord();
            DialogResult = DialogResult.OK;

        }

        private void SelectRecord()
        {
            switch (SelectedEnumrator)
            {
                case EnumGeneralList.Table:
                    TableName = GetSelectedGridRecord;
                    break;
                case EnumGeneralList.Application:
                    ApplicationName = GetSelectedGridRecord;
                    break;
                case EnumGeneralList.Column:
                    ColumName = GetSelectedGridRecord;
                    break;
                case EnumGeneralList.RowKey:
                    RowKey = GetSelectedGridRecord;
                    break;
                case EnumGeneralList.UserName:
                    UserName = GetSelectedGridRecord;
                    break;
                case EnumGeneralList.Workstation:
                    HostName = GetSelectedGridRecord;
                    break;
                default:
                    Close();
                    break;
            }
            Close();

        }

        public string GetSelectedGridRecord => dgvGeneralList.Rows[Index].Cells[0].Value.ToString();
    }
}
