
namespace ALMIS.BusinessEntities
{
    public class AuditTriggers
    {
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string TriggerName { get; set; }
        public bool Disabled { get; set; }

        public AuditTriggers()
        {
            //default konstruktori
        }

        public AuditTriggers(string tableSchema, string tableName, string triggerName, bool disabled)
        {
            TableSchema = tableSchema;
            TableName = tableName;
            TriggerName = triggerName;
            Disabled = disabled;
        }
    }
}
