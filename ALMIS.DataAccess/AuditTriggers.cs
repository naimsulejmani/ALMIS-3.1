using System;
using System.Collections.Generic;
using System.Data;
using BE = ALMIS.BusinessEntities.AuditTriggers;
namespace ALMIS.DataAccess
{
    public class AuditTriggers : DataAccessObject
    {
        #region private variables

        private const string TableSchema = "TableSchema";
        private const string TableName = "TableName";
        private const string TriggerName = "TriggerName";
        private const string Disabled = "IsDisabled";

        #endregion

        #region Selects
        public static List<BE> SelectBy(string tableSchema,string tableName)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("EXEC Almis.usp_GetAuditTriggerForTable @tableSchema,@tableName");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "tableSchema", tableSchema);
                AddParameter(command, "tableName", tableName);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }
                }
                catch(Exception ex)
                {
                    string m = ex.Message;
                    return result;
                }
            }
            return result;
        }
        #endregion


        #region Inserts,Updates,Deletes
        public static void DeleteTrigger(string triggerName)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("EXEC Almis.usp_AuditDropTriggers @triggerName");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "triggerName", triggerName);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
// ReSharper disable EmptyGeneralCatchClause
                catch
// ReSharper restore EmptyGeneralCatchClause
                {
                    // throw new Exception("Gabim ne fshierje ne trigerit");
                }
            }
        }

        public static void ChangeTriggersStatus(BE auditTriggers)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("EXEC Almis.usp_AuditEnableDisableTrigger @tableSchema,@tableName,@triggerName,@disabled");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "tableSchema", auditTriggers.TableSchema);
                AddParameter(command, "tableName", auditTriggers.TableName);
                AddParameter(command, "triggerName", auditTriggers.TriggerName);
                AddParameter(command, "disabled", auditTriggers.Disabled ? "DISABLE" : "ENABLE");
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
// ReSharper disable EmptyGeneralCatchClause
                catch
// ReSharper restore EmptyGeneralCatchClause
                {
           
                }
            }
        }
        #endregion

        #region Conversations
        private static BE ToObject(IDataReader reader)
        {
            var result = new BE();
            if (reader[TableSchema] != DBNull.Value)
                result.TableSchema = (string)reader[TableSchema];
            if (reader[TableName] != DBNull.Value)
                result.TableName = (string)reader[TableName];
            if (reader[TriggerName] != DBNull.Value)
                result.TriggerName = (string)reader[TriggerName];
            if (reader[Disabled] != DBNull.Value)
                result.Disabled = (bool)reader[Disabled];
            return result;
        }
        #endregion
    }
}


