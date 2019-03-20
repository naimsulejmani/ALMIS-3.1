using System;
using System.Collections.Generic;
using System.Data;
using BE = ALMIS.BusinessEntities.AuditTables;

namespace ALMIS.DataAccess
{
    public class AuditTables : DataAccessObject
    {
        #region private variables

        private const string TableId = "TableID";
        private const string TableSchema = "TableSchema";
        private const string TableName = "TableName";
        private const string AuditTable = "AuditTable";
        private const string AuditInserts = "AuditInserts";
        private const string AuditUpdates = "AuditUpdates";
        private const string AuditDeletes = "AuditDeletes";
        private const string AlmisAuditTables = "Almis.AuditTables";

        #endregion

        #region Methods
        //public static List<BE> SelectAll()
        //{
        //    var result = new List<BE>();
        //    using (IDbConnection connection = DataConnection.Connection())
        //    {
        //        const string sqlQuery = "EXEC dbo.usp_GetTablesAuditing";
        //        IDbCommand command = DataConnection.Command(connection, sqlQuery);
        //        connection.Open();
        //        IDataReader reader = command.ExecuteReader();
        //        while (reader != null && reader.Read())
        //        {
        //            result.Add(ToObject(reader));
        //        }
        //    }
        //    return result;
        //}
        public static List<BE> SelectAll()
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = "EXEC Almis.usp_GetTablesAuditing";
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(ToObject(reader));
                    }
                }
                catch (Exception ex)
                {
                    string m = ex.Message;
                    result = new List<BE>();
                }
            }
            return result;
        }

        public static BE SelectBy(string tableName)
        {
            var result = new BE();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@tableName", AlmisAuditTables, tableName);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader.Read())
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

        #region updates
        public static bool Update(BE auditTables)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery =
                    String.Format(
                        "UPDATE {0} SET {1}=@auditTable, {2}=@auditInsert,{3}=@auditUpdate,{4}=@auditDelete WHERE {5}=@tableName",
                        AlmisAuditTables, AuditTable, AuditInserts, AuditUpdates, AuditDeletes, TableName);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "auditTable", auditTables.AuditTable);
                AddParameter(command, "auditInsert", auditTables.AuditInserts);
                AddParameter(command, "auditUpdate", auditTables.AuditUpdates);
                AddParameter(command, "auditDelete", auditTables.AuditDeletes);
                AddParameter(command, "tableName", auditTables.TableName);
                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch
                {
                    return false;
                }

            }
        }
        #endregion

        #region ToObject

        private static BE ToObject(IDataReader reader)
        {
            var result = new BE();
            if (reader[TableId] != DBNull.Value)
                result.TableID = int.Parse(reader[TableId].ToString());
            if (reader[TableSchema] != DBNull.Value)
                result.TableSchema = reader[TableSchema].ToString();
            if (reader[TableName] != DBNull.Value)
                result.TableName = reader[TableName].ToString();
            //if (reader[AuditTable] != DBNull.Value && reader[AuditTable].ToString() != "0")
            //    result.AuditTable = true;
            //else result.AuditTable = false;
            if (reader[AuditInserts] != DBNull.Value && reader[AuditInserts].ToString() != "0")
                result.AuditInserts = true;
            else result.AuditInserts = false;
            if (reader[AuditUpdates] != DBNull.Value && reader[AuditUpdates].ToString() != "0")
                result.AuditUpdates = true;
            else result.AuditUpdates = false;
            if (reader[AuditDeletes] != DBNull.Value && reader[AuditDeletes].ToString() != "0")
                result.AuditDeletes = true;
            else result.AuditDeletes = false;
            result.AuditTable = result.AuditInserts | result.AuditDeletes | result.AuditUpdates;
            return result;
        }

        #endregion
    }
}
