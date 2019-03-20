
namespace ALMIS.BusinessEntities
{
    public class AuditConfig
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public AuditConfig()
        {
            //default konstruktor
        }

        public AuditConfig(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            return string.Format("{0}={1}", Name, Value);
        }
    }
}
