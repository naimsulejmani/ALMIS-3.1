using System;
using ALMIS.BusinessEntities.Constants;
using DAO = ALMIS.DataAccess.DataConnection;

namespace ALMIS.BusinessLogic
{
    public class DataConnection
    {
        public static AdoDotNetDataProvider DataProvider
        {
            get { return DAO.DataProvider; }
            set { DAO.DataProvider = value; }
        }

        public static String DefaultConnectionString
        {
            get { return DAO.ConnectionString; }
            set { DAO.ConnectionString = value; }
        }

        public static String ConnectionString2
        {
            get { return DAO.ConnectionString; }
            set { DAO.ConnectionString = value; }
        }

        public static bool CanConnect()
        {
            var connection = DAO.Connection();

            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                string m = ex.Message;
                return false;
            }


        }
    }
}
