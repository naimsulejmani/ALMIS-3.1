
namespace ALMIS.BusinessEntities
{
    public class AuditColumns
    {
        public int TableID { get; set; }
        public int ColumnID { get; set; }
        public string ColumnName { get; set; }
        public bool AuditColumn { get; set; }
        public int KeyColumn { get; set; }
        public string DataType { get; set; }

        public AuditColumns()
        {
            //default konstruktor
        }

        public AuditColumns(int tableID, int columnID, string columnName, bool auditColumn, int keyColumn, string dataType)
        {
            TableID = tableID;
            ColumnID = columnID;
            ColumnName = columnName;
            AuditColumn = auditColumn;
            KeyColumn = keyColumn;
            DataType = dataType;
        }
    }
}
