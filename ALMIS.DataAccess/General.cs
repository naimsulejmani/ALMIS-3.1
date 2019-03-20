using System;
using System.Collections.Generic;
using System.Data;

namespace ALMIS.DataAccess
{
    public class General : DataAccessObject
    {
        public static DataTable SelectTables(string tableName)
        {
            var result = new DataTable();
            using (IDbConnection connection = DataConnection.Connection())
            {
                var sqlQuery =
                    String.Format("SELECT TableName FROM Almis.AuditTables" +
                                  (string.IsNullOrEmpty(tableName) ? "" : " WHERE TableName like '%" + tableName + "%'"));
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    result.Load(reader);
                    //if (reader != null) result.Load(reader);
                    //if (reader != null)
                    //while (reader.Read())
                    //{
                    //    result.Add(reader[0].ToString());
                    //}
                    //while (reader != null && reader.Read())
                    //{
                    //    result.Add(reader[0].ToString());
                    //}
                    return result;
                }
                catch
                {
                    return null;
                }
            }
            // return new List<string>();
        }

        public static List<String> SelectTableList()
        {
            var result = new List<String>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT TableName FROM Almis.AuditTables");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    //result.Load(reader);
                    //if (reader != null) result.Load(reader);
                    //if (reader != null)
                    while (reader.Read())
                    {
                        result.Add(reader[0].ToString());
                    }
                    //while (reader != null && reader.Read())
                    //{
                    //    result.Add(reader[0].ToString());
                    //}
                    return result;
                }
                catch
                {
                    return null;
                }
            }
            // return new List<string>();
        }

        public static DataTable SelectColumns(string columnName)
        {
            var result = new DataTable();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT DISTINCT ColumnName FROM   Almis.AuditColumns " +
                                                (string.IsNullOrEmpty(columnName)
                                                    ? ""
                                                    : " WHERE ColumnName like '%" + columnName + "%'"));
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    //if (reader != null)
                    result.Load(reader);
                }
                catch
                {
                    return null;
                }
            }
            return result;
        }

        public static DataTable SelectUserNames(string userName)
        {
            var result = new DataTable();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT DISTINCT UserName FROM Almis.AuditLog"
                       +
                        (string.IsNullOrEmpty(userName)
                                                    ? ""
                                                    : " WHERE UserName like '%" + userName + "%'")
                    );
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    //if (reader != null)
                    result.Load(reader);
                }
                catch
                {
                    return null;
                }
            }
            return result;
        }
        public static DataTable SelectRowKeys(string rowKey)
        {
            var result = new DataTable();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT DISTINCT RowKey FROM Almis.AuditLogDetail"
                        +
                        (string.IsNullOrEmpty(rowKey)
                                                    ? ""
                                                    : " WHERE RowKey like '%" + rowKey + "%'")
                    );
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    //if (reader != null) 
                    result.Load(reader);
                }
                catch
                {
                    return null;
                }
            }
            return result;
        }

        public static DataTable SelectApplications(string applicationName)
        {
            var result = new DataTable();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT DISTINCT ApplicationName FROM Almis.AuditLog"
                    +
                        (string.IsNullOrEmpty(applicationName)
                                                    ? ""
                                                    : " WHERE ApplicationName like '%" + applicationName + "%'")
                    );
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    //if (reader != null) 
                    result.Load(reader);
                }
                catch
                {
                    return null;
                }
            }
            return result;
        }
        public static DataTable SelectHostNames(string hostName)
        {
            var result = new DataTable();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT DISTINCT HostName FROM Almis.AuditLog"+
                        (string.IsNullOrEmpty(hostName)
                                                    ? ""
                                                    : " WHERE HostName like '%" + hostName + "%'")
                    );
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    // if (reader != null) 
                    result.Load(reader);
                }
                catch
                {
                    return null;
                }
            }
            return result;
        }

        public static int ArchiveAuditLog(DateTime archiveDate)
        {
            var lista = AuditLog.SelectAll(1);
            if (lista.Count > 0)
                using (IDbConnection connection = DataConnection.Connection())
                {
                    String sqlQuery = String.Format("EXEC Almis.usp_ArchiveAuditLog @archiveDate");
                    IDbCommand command = DataConnection.Command(connection, sqlQuery);
                    AddParameter(command, "archiveDate", archiveDate);
                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                    catch
                    {
                        return -1;
                    }
                }
            return -999;
        }

        public static int DeleteAuditLog(DateTime deleteDate)
        {
            var lista = AuditLog.SelectAllFromAuditLogArchive(1);
            if (lista.Count > 0)
                using (IDbConnection connection = DataConnection.Connection())
                {
                    String sqlQuery = String.Format("EXEC Almis.usp_DeleteAuditLog @deleteDate");
                    IDbCommand command = DataConnection.Command(connection, sqlQuery);
                    AddParameter(command, "deleteDate", deleteDate);
                    try
                    {
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result;
                    }
                    catch
                    {
                        return -1;
                    }
                }
            return -999;
        }

        public static DataTable SelectTriggersBy(string tableName)
        {
            var result = new DataTable();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("EXEC Almis.usp_GetAuditTriggerForTable @tableName");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "tableName", tableName);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    //   if (reader != null) 
                    result.Load(reader);
                }
                catch
                {
                    return null;
                }
            }
            return result;
        }

        public static bool UninstallAuditing()
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("exec Almis.usp_UninstallAudit");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() < 0;
                }
                catch (Exception ex)
                {
                    string m = ex.Message;
                    return m == "";
                }
            }
        }

        public static bool InstallPrerequirements(object script)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("{0}", script);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    int i = command.ExecuteNonQuery();
                    return i <= 0;
                }
                catch (Exception ex)
                {
                    string m = ex.Message;
                    if (m != "")
                        return false;
                    throw new Exception(m);
                }

            }
        }

        public static void CreateTriggerFor(string tableName, string triggerType)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = "EXEC " + TriggerCreateTypeProcedure(triggerType);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "tableName", tableName);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public static void RebuildTriggerFor(string tableSchema,string tableName, string triggerType, bool isCreated)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("EXEC {0} @tableSchema, @tableName,@isCreated", TriggerDropTypeProcedure(triggerType));
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "tableSchema", tableSchema);
                AddParameter(command, "tableName", tableName);
                AddParameter(command, "isCreated", isCreated);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        private static string TriggerDropTypeProcedure(string triggerType)
        {
            var sqlQyery = "";
            switch (triggerType)
            {
                case "Ins":
                    sqlQyery = "Almis.usp_RebuildTriggersForInsert";
                    break;
                case "Upd":
                    sqlQyery = "Almis.usp_RebuildTriggersForUpdate";
                    break;
                case "Del":
                    sqlQyery = "Almis.usp_RebuildTriggersForDelete";
                    break;
            }
            return sqlQyery;
        }

        private static string TriggerCreateTypeProcedure(string triggerType)
        {
            string sqlQuery = "";
            switch (triggerType)
            {
                case "Ins":
                    sqlQuery += "Almis.usp_AuditCreateTriggerForInsertOnTable @tableName";
                    break;
                case "Upd":
                    sqlQuery += "Almis.usp_AuditCreateTriggerForUpdateOnTable @tableName";
                    break;
                case "Del":
                    sqlQuery += "Almis.usp_AuditCreateTriggerForDeleteOnTable @tableName";
                    break;
            }
            return sqlQuery;
        }


        public static List<string> GetDatabases()
        {
            var result = new List<string>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery =
                    String.Format(
                        "SELECT d.name FROM sys.databases d WHERE d.name NOT IN ('master','tempdb','model','msdb')");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(reader[0].ToString());
                    }
                    return result;
                }
                catch (Exception)
                {
                    return new List<string>();
                }
            }
        }
    }
}
