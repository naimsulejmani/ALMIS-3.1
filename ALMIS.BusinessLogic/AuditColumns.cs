using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BE = ALMIS.BusinessEntities.AuditColumns;
using DAO = ALMIS.DataAccess.AuditColumns;

namespace ALMIS.BusinessLogic
{
    public class AuditColumns
    {
        public static List<BE> FindColumnByTableName(string tableName)
        {
            return DAO.SelectColumnByTableName(tableName);
        }

        public static bool ChangeColumnState(BE columns, string tableName, string tableSchema)
        {
            return DAO.ChangeColumnsState(columns, tableName, tableSchema);
        }
        public static bool ChangeAllColumnState(bool state)
        {
            return DAO.ChangeAllColumnState(state);
        }
    }
}
