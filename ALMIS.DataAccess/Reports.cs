using System;
using System.Collections.Generic;
using System.Data;
using BE = ALMIS.BusinessEntities.Reports;
using Field = ALMIS.BusinessEntities.Constants.ReportsFields;
namespace ALMIS.DataAccess
{
    public class Reports : DataAccessObject
    {
        #region private variables

        private const string AuditLogID = "AuditLogID";
        private const string TableName = "TableName";
        private const string TableSchema = "TableSchema";
        private const string ColumnName = "ColumnName";
        private const string Event = "Event";
        private const string PostedDateTime = "PostedDateTime";
        public const string UserName = "UserName";
        public const string HostName = "HostName";
        public const string ApplicationName = "ApplicationName";
        public const string AlmisViewAuditLog = "Almis.vw_AuditLog";
        public const string OldValue = "OldValue";
        public const string NewValue = "NewValue";
        public const string RowKey = "RowKey";

        #endregion

        #region Methods

        public static List<BE> SelectAll()
        {
            var result = new List<BE>();

            using (IDbConnection connection = DataConnection.Connection())
            {
                const string sqlQuery = "SELECT * FROM " + AlmisViewAuditLog;
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                connection.Open();
                IDataReader reader = command.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    result.Add(ToObject(reader));
                }
            }
            return result;
        }

        public static BE SelectBy(int auditLogID)
        {
            var result = new BE();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@auditLogID", AlmisViewAuditLog, AuditLogID);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "auditLogID", auditLogID);
                connection.Open();
                IDataReader reader = command.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    result = ToObject(reader);
                }
            }
            return result;
        }

        public static List<BE> SelectBy(BE reports, DateTime before, DateTime after, object maximum)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery =
                    String.Format(
                        "EXEC Almis.usp_GetAuditLogBy @tableName,@columnName,@userName,@hostName,@applicationName,@rowKey,@event,@before,@after,@maximum");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "tableName", reports.TableName != "" ? reports.TableName : null);
                AddParameter(command, "columnName", reports.ColumnName != "" ? reports.ColumnName : null);
                AddParameter(command, "userName", reports.UserName != "" ? reports.UserName : null);
                AddParameter(command, "hostName", reports.HostName != "" ? reports.HostName : null);
                AddParameter(command, "applicationName", reports.ApplicationName != "" ? reports.ApplicationName : null);
                AddParameter(command, "rowKey", reports.RowKey != "" ? reports.RowKey : null);
                AddParameter(command, "event", reports.Event != "" ? reports.Event : null);
                AddParameter(command, "before", before);
                AddParameter(command, "after", after);
                AddParameter(command, "maximum", maximum);
                connection.Open();
                IDataReader reader = command.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    result.Add(ToObject(reader));
                }
            }
            return result;
        }
        #endregion

        #region Select by Param

        public static List<BE> SelectBy(Field fieldName, object value)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@value", AlmisViewAuditLog, fieldName.ToString());
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "value", value);
                IDataReader reader = command.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    result.Add(ToObject(reader));
                }
            }
            return result;
        }

        public static List<BE> SelectBy(Field fieldName1, object value1, Field fieldName2, object value2)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@value1 AND {2}=@value2", AlmisViewAuditLog, fieldName1.ToString(), fieldName2.ToString());
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "value1", value1);
                AddParameter(command, "value2", value2);
                IDataReader reader = command.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    result.Add(ToObject(reader));
                }
            }
            return result;
        }

        public static List<BE> SelectBy(Field fieldName1, object value1, Field fieldName2, object value2, Field fieldName3, object value3)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@value1 AND {2}=@value2 and {3}=@value3", AlmisViewAuditLog, fieldName1.ToString(), fieldName2.ToString(), fieldName3.ToString());
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "value1", value1);
                AddParameter(command, "value2", value2);
                AddParameter(command, "value3", value3);
                IDataReader reader = command.ExecuteReader();
                while (reader != null && reader.Read())
                {
                    result.Add(ToObject(reader));
                }
            }
            return result;
        }

        #endregion

        #region Conversation

        private static BE ToObject(IDataReader reader)
        {
            var result = new BE();

            if (reader[AuditLogID] != DBNull.Value)
                result.AuditLogID = (int)reader[AuditLogID];
            if (reader[TableName] != DBNull.Value)
                result.TableName = (string)reader[TableName];
            if (reader[ColumnName] != DBNull.Value)
                result.ColumnName = (string)reader[ColumnName];
            if (reader[Event] != DBNull.Value)
                result.Event = (string)reader[Event];
            if (reader[PostedDateTime] != DBNull.Value)
                result.PostedDateTime = DateTime.Parse(reader[PostedDateTime].ToString());
            if (reader[UserName] != DBNull.Value)
                result.UserName = reader[UserName].ToString();
            if (reader[HostName] != DBNull.Value)
                result.HostName = reader[HostName].ToString();
            if (reader[ApplicationName] != DBNull.Value)
                result.ApplicationName = reader[ApplicationName].ToString();
            if (reader[RowKey] != DBNull.Value)
                result.RowKey = (string)reader[RowKey];
            if (reader[OldValue] != DBNull.Value)
                result.OldValue = (string)reader[OldValue];
            if (reader[NewValue] != DBNull.Value)
                result.NewValue = (string)reader[NewValue];
            return result;
        }

        #endregion
    }
}
