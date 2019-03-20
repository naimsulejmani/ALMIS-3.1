
namespace ALMIS.BusinessEntities
{
    public class AuditTables
    {
        public int TableID { get; set; }
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public bool AuditTable { get; set; }
        public bool AuditInserts { get; set; }
        public bool AuditUpdates { get; set; }
        public bool AuditDeletes { get; set; }

        public AuditTables()
        {
            //default konstruktor
        }

        public AuditTables(int tableID, string tableSchema, string tableName, bool auditTable,
                           bool auditInserts, bool auditUpdates, bool auditDeletes)
        {
            TableSchema = tableSchema;
            TableID = tableID;
            TableName = tableName;
            AuditTable = auditTable;
            AuditInserts = auditInserts;
            AuditUpdates = auditUpdates;
            AuditDeletes = auditDeletes;
        }

    }
}
