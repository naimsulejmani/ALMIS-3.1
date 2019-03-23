using System;
using System.Collections.Generic;
using System.Linq;
using BE = ALMIS.BusinessEntities;

namespace ALMIS.Manager.App_Code
{
    public class CurrentSettings
    {
        public static string PaLidhje = String.Empty;
        public static string Database = String.Empty;
        public static string UseriAktiv = String.Empty;
        public static List<string> ListaKolonave = null;
        public static List<BE.AuditTables> DefaultAuditTableList = null;
        public static List<BE.AuditTables> AuditDatabaseTableList = null;
        public static List<BE.AuditConfig> RuntimeConfigProperties = null;
        public static int GridRowSelected = 0;
        public static BE.AuditUsers AuditUser;
        public static string Validate(string name)
        {
            var result = RuntimeConfigProperties.FirstOrDefault(config => config.Name == name);
            return result != null ? result.Value : "";
        }
    }
}
