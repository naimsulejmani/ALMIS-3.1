using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BE = ALMIS.BusinessEntities.AuditUsers;
using DAO = ALMIS.DataAccess.AuditUsers;

namespace ALMIS.BusinessLogic
{
    public class AuditUsers
    {
        public static List<BE> FindAll()
        {
            return DAO.SelectAll();
        }
        public static BE FindBy(object username)
        {
            return DAO.SelectBy(username);
        }
        public static BE FindBy(object username, object password)
        {
            return DAO.SelectBy(username, password);
        }
        public static int Inserts(BE auditUsers)
        {
            return DAO.Insert(auditUsers);
        }
        public static int Update(BE auditUsers)
        {
            return DAO.Update(auditUsers);
        }
        public static int UpdatePassword(object username, object password)
        {
            return DAO.UpdatePassword(username, password);
        }
        public static bool Delete(string username)
        {
            return DAO.Delete(username);
        }
    }
}
