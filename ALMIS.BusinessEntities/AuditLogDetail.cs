using System;

namespace ALMIS.BusinessEntities
{
    public class AuditLogDetail : AuditLog
    {
        //public int AuditLogID { get; set; }
        public string RowKey { get; set; }
        public int ColumnID { get; set; }
        public char Status { get; set; }
        public String OldValue { get; set; }
        public String NewValue { get; set; }

        public AuditLogDetail()
        {
            //default konstruktor
        }

        public AuditLogDetail(int auditLogID, string rowKey, int columnID, char status,
                              String oldValue, String newValue)
        {
            AuditLogID = auditLogID;
            RowKey = rowKey;
            ColumnID = columnID;
            Status = status;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
