using System;
using System.Collections.Generic;
using System.Data;
using DAO = ALMIS.DataAccess.General;

namespace ALMIS.BusinessLogic
{
    public class General
    {
        public static DataTable FindTables(string tableName)
        {
            return DAO.SelectTables(tableName);
        }

        public static List<string> FindTableList()
        {
            return DAO.SelectTableList();
        }

        public static DataTable FindColumns(string columnName)
        {
            return DAO.SelectColumns(columnName);
        }

        public static int ArchiveAuditLog(DateTime archiveDate)
        {
            return DAO.ArchiveAuditLog(archiveDate);
        }

        public static int DeleteAuditLog(DateTime deleteDate)
        {
            return DAO.DeleteAuditLog(deleteDate);
        }
        public static DataTable FindTriggersBy(string tableName)
        {
            return DAO.SelectTriggersBy(tableName);
        }

        public static DataTable FindUserNames(string userName)
        {
            return DAO.SelectUserNames(userName);
        }

        public static DataTable FindRowKeys(string rowKey)
        {
            return DAO.SelectRowKeys(rowKey);
        }

        public static DataTable FindApplications(string applicationName)
        {
            return DAO.SelectApplications(applicationName);
        }

        public static DataTable FindHostNames(string hostName)
        {
            return DAO.SelectHostNames(hostName);
        }
        public static bool UninstallAuditing()
        {
            return DAO.UninstallAuditing();
        }

        public static void InstallPrerequirements(object script)
        {
            DAO.InstallPrerequirements(script);
        }
        public static void CreateTriggerFor(string tableName, string triggerType)
        {
            DAO.CreateTriggerFor(tableName, triggerType);
        }
        public static void RebuildTriggerFor(string tableSchema,string tableName, string triggerType, bool isCreated)
        {
            DAO.RebuildTriggerFor(tableSchema,tableName, triggerType, isCreated);
        }

        public static List<string> GetDatabases()
        {
            return DAO.GetDatabases();
        }
    }
}
