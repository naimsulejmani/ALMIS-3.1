using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BE = ALMIS.BusinessEntities.AuditConfig;
using DAO = ALMIS.DataAccess.AuditConfig;
namespace ALMIS.BusinessLogic
{
    public class AuditConfig
    {
        public static List<BE> FindAll()
        {
            return DAO.SelectAll();
        }
    }
}
