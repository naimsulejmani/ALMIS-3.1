using System;

namespace ALMIS.BusinessEntities
{
    public class AuditLogAutoKeys
    {
        public string TableName { get; set; }
        public int KeyValue { get; set; }

        public AuditLogAutoKeys()
        {
            //default konstrutor
        }

        public AuditLogAutoKeys(string tableName, int keyValue)
        {
            TableName = tableName;
            KeyValue = keyValue;
        }

        public override string ToString()
        {
            return String.Format("{0}={1}", TableName, KeyValue);
        }
    }
}
