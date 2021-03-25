using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE = ALMIS.BusinessEntities.AuditUsers;

namespace ALMIS.DataAccess
{
    public class AuditUsers : DataAccessObject
    {
        #region private variables

        private const string Username = "Username";
        private const string Password = "Password";
        private const string CanAccess = "canAccess";
        private const string Name = "Name";
        private const string Surname = "Surname";
        private const string AlmisAuditUsers = "Almis.AuditUsers";
        #endregion

        #region Selects
        public static List<BE> SelectAll()
        {
            var result = new List<BE>();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("Select * FROM {0}", AlmisAuditUsers);
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



        public static BE SelectBy(object username)
        {
            var result = new BE();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery =
                    String.Format("EXEC Almis.usp_GetAuditUser @username");
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "username", username);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result = ToObject(reader);
                    }
                }
                catch (Exception ex)
                {
                    string m = ex.Message;
                    return result;
                }
            }
            return result;
        }

        public static BE SelectBy(object username, object password)
        {
            var result = new BE();
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery =
                    String.Format(
                        "SELECT * FROM {0} WHERE {1}=@username AND {2}=@password", AlmisAuditUsers, Username, Password);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "username", username);
                AddParameter(command, "password", password);
                try
                {
                    connection.Open();
                    IDataReader reader = command.ExecuteReader();
                    while (reader != null && reader.Read())
                    {
                        result = ToObject(reader);
                    }
                }
                catch(SqlException ex)
                {
                    return result;
                }
            }
            return result;
        }

        #endregion

        #region Inserts/Updates/Deletes
        //public static bool Inserts(BE auditUsers)
        //{
        //    bool result;
        //    using (IDbConnection connection = DataConnection.Connection())
        //    {
        //        String sqlQuery = String.Format("INSERT INTO {0} ({1},{2}) VALUES (@personID,@canAccess)",
        //                                        AlmisAuditUsers, PersonID, CanAccess);
        //        IDbCommand command = DataConnection.Command(connection, sqlQuery);
        //        AddParameter(command, "personID", auditUsers.PersonID);
        //        AddParameter(command, "CanAccess", auditUsers.CanAccess);
        //        try
        //        {
        //            connection.Open();
        //            result = command.ExecuteNonQuery() == 1;
        //        }
        //        catch
        //        {
        //            return false;
        //        }

        //    }
        //    return result;
        //}

        //public static bool Update(BE auditUsers)
        //{
        //    bool result;
        //    using (IDbConnection connection = DataConnection.Connection())
        //    {
        //        String sqlQuery = String.Format("UPDATE {0} SET {1}=@canAccess Where {2}=@personID",
        //                                        AlmisAuditUsers, CanAccess, PersonID);
        //        IDbCommand command = DataConnection.Command(connection, sqlQuery);
        //        AddParameter(command, "personID", auditUsers.PersonID);
        //        AddParameter(command, "CanAccess", auditUsers.CanAccess);
        //        try
        //        {
        //            connection.Open();
        //            result = command.ExecuteNonQuery() == 1;
        //        }
        //        catch
        //        {
        //            return false;
        //        }


        //    }
        //    return result;
        //}

        public static bool Delete(string username)
        {
            bool result;
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format("DELETE FROM {0} where {1}=@username",
                                                AlmisAuditUsers, Username);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "username", username);
                try
                {
                    connection.Open();
                    result = command.ExecuteNonQuery() == 1;
                }
                catch (Exception ex)
                {
                    string m = ex.Message;
                    return false;
                }

            }
            return result;
        }
        #endregion

        #region Isnerts,Update,Delete
        public static int Insert(BE users)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format(
                    "Insert Into {0} values (@PersonID,@Name,@Surname,@Password,@CanAccess)", AlmisAuditUsers);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "PersonID", users.Username);
                AddParameter(command, "Name", users.Name);
                AddParameter(command, "Surname", users.Surname);
                AddParameter(command, "Password", users.Password);
                AddParameter(command, "CanAccess", users.CanAccess);

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string m = ex.Message;
                    return -1;
                }
            }
        }

        public static int Update(BE users)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format(
                    "Update {0} SET {1}=@Name,{2}=@Surname,{3}=@CanAccess,{5}=@Password where {4}=@PersonID",
                    AlmisAuditUsers, Name,
                    Surname, CanAccess, Username, Password);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "PersonID", users.Username);
                AddParameter(command, "Name", users.Name);
                AddParameter(command, "Surname", users.Surname);
                AddParameter(command, "CanAccess", users.CanAccess);
                AddParameter(command, "Password", users.Password);
                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string m = ex.Message;
                    return -1;
                }
            }
        }

        public static int UpdatePassword(object username, object password)
        {
            using (IDbConnection connection = DataConnection.Connection())
            {
                String sqlQuery = String.Format(
                    "Update {0} SET {1}=@Password where {2}=@Username", AlmisAuditUsers, Password, Username);
                IDbCommand command = DataConnection.Command(connection, sqlQuery);
                AddParameter(command, "Username", username);
                AddParameter(command, "Password", password);
                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    return -1;
                }
            }

        }

        #endregion

        #region Conversation

        private static BE ToObject(IDataReader reader)
        {
            var result = new BE();
            if (reader[Username] != DBNull.Value)
                result.Username = (string)reader[Username];
            if (reader[CanAccess] != DBNull.Value)
                result.CanAccess = (bool)reader[CanAccess];
            if (reader[Name] != DBNull.Value)
                result.Name = (string)reader[Name];
            if (reader[Surname] != DBNull.Value)
                result.Surname = (string)reader[Surname];
            if (reader[Password] != DBNull.Value)
                result.Password = (byte[])reader[Password];
            return result;
        }

        #endregion
    }
}
