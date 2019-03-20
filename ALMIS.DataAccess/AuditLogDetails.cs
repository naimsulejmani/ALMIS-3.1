using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using BE = ALMIS.BusinessEntities.AuditLogDetail;
using Constants = ALMIS.BusinessEntities.Constants.AuditLogDetailFields;

namespace ALMIS.DataAccess
{
    public class AuditLogDetails : DataAccessObject
    {
        #region private variables

        private const string AuditLogID = "AuditLogID";
        public const string AlmisAuditLogDetail = "Almis.AuditLogDetail";
        private const string RowKey = "RowKey";
        private const string ColumnID = "ColumnID";
        private const string Status = "Status";
        private const string OldValue = "OldValue";
        private const string NewValue = "NewValue";
        #endregion

        #region Methods
        public static List<BE> SelectAll()
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                const string sqlQuery = "SELECT * FROM " + AlmisAuditLogDetail;
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

        public static List<BE> SelectBy(int auditLogID)
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = string.Format("SELECT * FROM {0} where {1}=@auditLogID", AlmisAuditLogDetail, AuditLogID);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "auditLogID", auditLogID);
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
            if (reader[RowKey] != DBNull.Value)
                result.RowKey = reader[RowKey].ToString();
            if (reader[ColumnID] != DBNull.Value)
                result.ColumnID = int.Parse(reader[ColumnID].ToString());
            if (reader[Status] != DBNull.Value)
                result.Status = char.Parse(reader[Status].ToString());
            if (reader[OldValue] != DBNull.Value)
                result.OldValue = reader[OldValue].ToString();
            if (reader[NewValue] != DBNull.Value)
                result.NewValue = reader[NewValue].ToString();
            return result;
        }

        #endregion
    }
}
