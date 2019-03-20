using System;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using ALMIS.BusinessEntities.Constants;

namespace ALMIS.DataAccess
{
    public class DataConnection
    {
        #region variables

        private static string _connectionString =
            ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        #endregion

        #region Properties

        public static AdoDotNetDataProvider DataProvider { get; set; }

        public static String ConnectionString
        {
            get
            {
                return _connectionString != ""
                           ? _connectionString
                           : ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
            }
            set { _connectionString = value; }
        }

        #endregion

        #region Metods

        public static IDbConnection Connection()
        {
            switch (DataProvider)
            {
                case AdoDotNetDataProvider.OleDb:
                    return new OleDbConnection(ConnectionString);
                case AdoDotNetDataProvider.Odbc:
                    return new OdbcConnection(ConnectionString);
                default:
                    return new SqlConnection(ConnectionString);
            }
        }

        public static IDbCommand Command()
        {
            return Command(null, null, CommandType.Text);
        }

        public static IDbCommand Command(IDbConnection connection, string commandText)
        {
            return Command(connection, commandText, CommandType.Text);
        }

        public static IDbCommand Command(IDbConnection connection, string commandText, CommandType commandType)
        {
            IDbCommand command;
            switch (DataProvider)
            {
                case AdoDotNetDataProvider.OleDb:
                    command = new OleDbCommand();
                    break;
                case AdoDotNetDataProvider.Odbc:
                    command = new OdbcCommand();
                    break;
                default:
                    command = new SqlCommand();
                    break;
            }
            command.Connection = connection;
            command.CommandType = commandType;
            command.CommandText = commandText;
            return command;
        }

        #endregion
    }
}
