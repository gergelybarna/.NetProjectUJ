using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace AutoWashingProject
{
    public class User
    {
        int id;
        string name, email, password, phone;

        public User(){}

        public User(string name, string email, string password, string phone)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
        }

        public User(int id, string name, string email, string password, string phone)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.phone = phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }

    }
}
