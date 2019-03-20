using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BE = ALMIS.BusinessEntities.Reports;
using Field = ALMIS.BusinessEntities.Constants.ReportsFields;
using DAO = ALMIS.DataAccess.Reports;

namespace ALMIS.BusinessLogic
{
    public class Reports
    {
        public static List<BE> FindAll()
        {
            return DAO.SelectAll();
        }

        public static BE FindBy(int auditLogID)
        {
            return DAO.SelectBy(auditLogID);
        }

        public static List<BE> FindBy(Field fieldName, object value)
        {
            return DAO.SelectBy(fieldName, value);
        }

        public static List<BE> FindBy(Field fieldName1, object value1, Field fieldName2, object value2)
        {
            return DAO.SelectBy(fieldName1, value1, fieldName2, value2);
        }
        public static List<BE> FindBy(Field fieldName1, object value1, Field fieldName2, object value2,
                                        Field fieldName3, object value3)
        {
            return DAO.SelectBy(fieldName1, value1, fieldName2, value2, fieldName3, value3);
        }

        public static List<BE> FindBy(BE reports, DateTime before, DateTime after, object maximum)
        {
            return DAO.SelectBy(reports, before, after, maximum);
        }
    }
}
