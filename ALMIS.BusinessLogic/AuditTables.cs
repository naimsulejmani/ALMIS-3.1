using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BE = ALMIS.BusinessEntities.AuditTables;
using DAO = ALMIS.DataAccess.AuditTables;
namespace ALMIS.BusinessLogic
{
    public class AuditTables
    {
        public static List<BE> FindAll()
        {
            return DAO.SelectAll();
        }

        public static BE FindBy(string tableName)
        {
            return DAO.SelectBy(tableName);
        }

        public static bool Update(BE auditTables)
        {
            if (auditTables != null)
                return DAO.Update(auditTables);
            return false;
        }
    }
}
