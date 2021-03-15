using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsAndInterfaces
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public User( string name, string email)
        {
            Id = -1;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Id + " " + Name + " " + Email;
        }
    }
}
