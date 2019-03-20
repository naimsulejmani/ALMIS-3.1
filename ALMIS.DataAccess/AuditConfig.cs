using System;
using System.Collections.Generic;
using System.Data;
using BE = ALMIS.BusinessEntities.AuditConfig;

namespace ALMIS.DataAccess
{
    public class AuditConfig : DataAccessObject
    {
        #region private variables

        private const string Name = "Name";
        private const string Value = "Value";
        private const string AlmisAuditConfig = "Almis.AuditConfig";

        #endregion

        #region Methods

        public static List<BE> SelectAll()
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                const string sqlQyery = "SELECT * FROM " + AlmisAuditConfig;
                IDbCommand command = DataConnection.Command(connection, sqlQyery);
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

        public static BE SelectBy(string name)
        {
            var result = new BE();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("SELECT * FROM {0} WHERE {1}=@name", AlmisAuditConfig, Name);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "name", name);
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

        #region Conversation

        private static BE ToObject(IDataReader reader)
        {
            var result = new BE();
            if (reader[Name] != DBNull.Value)
                result.Name = reader[Name].ToString();
            if (reader[Value] != DBNull.Value)
                result.Value = reader[Value].ToString();
            return result;
        }

        #endregion
    }
}
