namespace ALMIS.BusinessEntities
{
    public class AuditUsers
    {
        public string Username { get; set; }
        public bool CanAccess { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public object Password { get; set; }
        public AuditUsers()
        {
            //default konstruktor
        }

        public AuditUsers(string username, bool canAccess, string name, string surname, object password)
        {
            Username = username;
            CanAccess = canAccess;
            Name = name;
            Surname = surname;
            Password = password;
        }
    }
}

