using System;
using System.Collections.Generic;
using System.Data;
using BE = ALMIS.BusinessEntities.AuditLog;
using Field = ALMIS.BusinessEntities.Constants.AuditLogFields;

namespace ALMIS.DataAccess
{
    public class AuditLog : DataAccessObject
    {
        #region private variables

        private const string AuditLogID = "AuditLogID";
        private const string TableID = "TableID";
        private const string RowsAffected = "RowsAffected";
        private const string Event = "Event";
        private const string PostedDateTime = "PostedDateTime";
        public const string UserName = "UserName";
        public const string HostName = "HostName";
        public const string ApplicationName = "ApplicationName";
        public const string AlmisAuditLog = "Almis.AuditLog";
        public const string AlmisAuditLogArchive = "Almis.AuditLogArchive";

        #endregion

        #region Methods

        public static List<BE> SelectAll()
        {
            var result = new List<BE>();

            using (IDbConnection connection = DataConnection.Connection())
            {
                const string sqlQuery = "SELECT * FROM " + AlmisAuditLog;
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }
                }
                catch
                {
                    return result;
                }
            }
            return result;
        }

        public static List<BE> SelectAll(object top)
        {
            var result = new List<BE>();

            using (IDbConnection connection = DataConnection.Connection())
            {
                string sqlQuery = String.Format("SELECT TOP {0} * FROM {1}", top, AlmisAuditLog);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }
                }
                catch
                {
                    return result;
                }
            }
            return result;
        }


        public static List<BE> SelectAllFromAuditLogArchive(object top)
        {
            var result = new List<BE>();

            using (IDbConnection connection = DataConnection.Connection())
            {
                string sqlQuery = String.Format("SELECT TOP {0} * FROM {1}", top, AlmisAuditLogArchive);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }
                }
                catch
                {
                    return result;
                }
            }
            return result;
        }

        public static BE SelectBy(int auditLogID)
        {
            var result = new BE();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@auditLogID", AlmisAuditLog, AuditLogID);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "auditLogID", auditLogID);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result = ToObject(reader);
                    }
                }
                catch
                {
                    return result;
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
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@value", AlmisAuditLog, fieldName.ToString());
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "value", value);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }
                }
                catch
                {
                    return result;
                }
            }
            return result;
        }

        public static List<BE> SelectBy(Field fieldName1, object value1, Field fieldName2, object value2)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@value1 AND {2}=@value2", AlmisAuditLog, fieldName1.ToString(), fieldName2.ToString());
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "value1", value1);
                AddParameter(command, "value2", value2);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }
                }
                catch
                {
                    return result;
                }
            }
            return result;
        }

        public static List<BE> SelectBy(Field fieldName1, object value1, Field fieldName2, object value2, Field fieldName3, object value3)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@value1 AND {2}=@value2 and {3}=@value3", AlmisAuditLog, fieldName1.ToString(), fieldName2.ToString(), fieldName3.ToString());
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "value1", value1);
                AddParameter(command, "value2", value2);
                AddParameter(command, "value3", value3);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }
                }
                catch
                {
                    return result;
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
                result.AuditLogID = int.Parse(reader[AuditLogID].ToString());
            if (reader[TableID] != DBNull.Value)
                result.TableID = int.Parse(reader[TableID].ToString());
            if (reader[RowsAffected] != DBNull.Value)
                result.RowsAffected = int.Parse(reader[RowsAffected].ToString());
            if (reader[Event] != DBNull.Value)
                result.Event = char.Parse(reader[Event].ToString());
            if (reader[PostedDateTime] != DBNull.Value)
                result.PostedDateTime = DateTime.Parse(reader[PostedDateTime].ToString());
            if (reader[UserName] != DBNull.Value)
                result.UserName = reader[UserName].ToString();
            if (reader[HostName] != DBNull.Value)
                result.HostName = reader[HostName].ToString();
            if (reader[ApplicationName] != DBNull.Value)
                result.ApplicationName = reader[ApplicationName].ToString();

            return result;
        }

        #endregion
    }
}
