using System;

namespace СРМ_Солюшнс_Task
{
    public class User
    {
        
        
        public Guid Id { get; set; }

        public string GivenName { get; set; }

        public string Surname { get; set; }

        public string MiddleName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string PasswordHash
        {
            get;
            set;
        }

        public static string Hash(string str)
        {
            return str;
        }

        public static string UnHash(string hasStr)
        {
            return hasStr;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n===========\n", GivenName, Surname, MiddleName, Email,
                Phone);
        }
    }
}