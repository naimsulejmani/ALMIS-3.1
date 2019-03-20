using System;
namespace ALMIS.BusinessEntities
{
    public class AuditLog
    {
        public int AuditLogID { get; set; }
        public int TableID { get; set; }
        public int RowsAffected { get; set; }
        public char Event { get; set; }
        public DateTime PostedDateTime { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public string ApplicationName { get; set; }

        public AuditLog()
        {
            //default konstruktor
        }

        public AuditLog(int auditLogID, int tableID, int rowsAffected, char events,
                        DateTime postedDateTime, string userName, string hostName, string applicationName)
        {
            AuditLogID = auditLogID;
            TableID = tableID;
            RowsAffected = rowsAffected;
            Event = events;
            PostedDateTime = postedDateTime;
            UserName = userName;
            HostName = hostName;
            ApplicationName = applicationName;
        }
    }
}
