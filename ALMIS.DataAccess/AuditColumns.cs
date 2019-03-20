using System;
using System.Collections.Generic;
using System.Data;
using BE = ALMIS.BusinessEntities.AuditColumns;

namespace ALMIS.DataAccess
{
    public class AuditColumns : DataAccessObject
    {
        #region private variabes

        private const string TableID = "TableID";
        private const string ColumnID = "ColumnID";
        private const string ColumnName = "ColumnName";
        private const string AuditColumn = "AuditColumn";
        private const string KeyColumn = "KeyColumn";
        private const string AlmisAuditColumn = "Almis.AuditColumns";
        private const string DataType = "DATA_TYPE";
        #endregion

        #region Selects

        public static List<BE> SelectAll()
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                const string sqlQuery = "SELECT * FROM " + AlmisAuditColumn;
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
                catch
                {
                    return result;
                }
            }
            return result;
        }

        public static BE SelectBy(string columnName)
        {
            var result = new BE();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@columnName", AlmisAuditColumn, ColumnName);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "columnName", columnName);
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

        public static List<BE> SelectColumnByTableName(string tableName)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                const string sqlQuery = "EXEC Almis.usp_GetColumnForTable @tableName";
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "tableName", tableName);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        result.Add(ToObjectShort(reader));
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
            if (reader[TableID] != DBNull.Value)
                result.TableID = int.Parse(reader[TableID].ToString());
            if (reader[ColumnID] != DBNull.Value)
                result.ColumnID = int.Parse(reader[ColumnID].ToString());
            if (reader[ColumnName] != DBNull.Value)
                result.ColumnName = reader[ColumnName].ToString();
            if (reader[AuditColumn] != DBNull.Value)
                result.AuditColumn = bool.Parse(reader[AuditColumn].ToString());
            if (reader[KeyColumn] != DBNull.Value)
                result.KeyColumn = char.Parse(reader[KeyColumn].ToString());

            return result;
        }

        private static BE ToObjectShort(IDataReader reader)
        {
            var result = new BE();
            if (reader[ColumnName] != DBNull.Value)
                result.ColumnName = reader[ColumnName].ToString();
            if (reader[AuditColumn] != DBNull.Value)
                result.AuditColumn = (bool)reader[AuditColumn];
            if (reader[DataType] != DBNull.Value)
                result.DataType = (string)reader[DataType];
            return result;
        }

        #endregion

        public static bool ChangeColumnsState(BE columns, string tableName,string tableSchema)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                try
                {
                    String sqlQuery =
                        string.Format(
                            "UPDATE {0} SET {1} = (CASE {1} WHEN 1 THEN 0 ELSE 1 END) WHERE  TableID IN (SELECT TOP 1 at.{2}" +
                            " FROM   Almis.AuditTables at WHERE  at.TableName = @tableName and at.TableSchema=@tableSchema) AND {3} = @columnName",
                            AlmisAuditColumn, AuditColumn, TableID, ColumnName);
                    IDbCommand command = DataConnection.Command(connection, sqlQuery);
                    //                AddParameter(command, "auditColumn", columns.AuditColumn);
                    AddParameter(command, "tableName", tableName);
                    AddParameter(command, "tableSchema", tableSchema);
                    AddParameter(command, "columnName", columns.ColumnName);
                    connection.Open();
                    command.ExecuteNonQuery();
                    sqlQuery =
                        string.Format(
                            "SELECT ac.{3} FROM {0} ac WHERE ac.{1} IN (SELECT at.{1} FROM Almis.AuditTables at WHERE  at.TableName = @tableName and at.TableSchema=@tableSchema) and {2}=@columnName",
                            AlmisAuditColumn, TableID, ColumnName, AuditColumn);
                    command = DataConnection.Command(connection, sqlQuery);
                    //                AddParameter(command, "auditColumn", columns.AuditColumn);
                    AddParameter(command, "tableName", tableName);
                    AddParameter(command, "tableSchema", tableSchema);
                    AddParameter(command, "columnName", columns.ColumnName);
                    IDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var audiColumn = (bool)reader[AuditColumn];
                        return audiColumn;
                    }
                    return false;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool ChangeAllColumnState(bool state)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                var sqlQuery = String.Format("UPDATE {0} SET {1} = @state", AlmisAuditColumn, AuditColumn);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "state", state);
                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    string m = ex.Message;
                    return m == "";
                }
            }
        }
    }
}
