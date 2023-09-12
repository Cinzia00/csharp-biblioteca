using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Password { get; set; }
        public int Phone { get; set; }




        public Utente(string lastName, string name, string email, int password, int phone)
        {
            LastName = lastName;
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
        }

        public string fullName()
        {
            return $"{this.LastName}  {this.Name}";
        }

    }
}
