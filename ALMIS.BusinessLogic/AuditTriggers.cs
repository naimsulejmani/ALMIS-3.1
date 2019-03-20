using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BE = ALMIS.BusinessEntities.AuditTriggers;
using DAO = ALMIS.DataAccess.AuditTriggers;

namespace ALMIS.BusinessLogic
{
    public class AuditTriggers
    {
        public static List<BE> FindBy(string tableSchema,string tableName)
        {
            return DAO.SelectBy(tableSchema,tableName);
        }

        public static void ChangeTriggersStatus(BE auditTriggers)
        {
             DAO.ChangeTriggersStatus(auditTriggers);
        }
        public static void DeleteTrigger(string triggerName)
        {
            DAO.DeleteTrigger(triggerName);
        }


    }
}
