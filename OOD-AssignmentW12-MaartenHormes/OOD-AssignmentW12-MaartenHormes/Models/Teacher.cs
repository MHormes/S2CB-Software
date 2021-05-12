using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class Teacher : IPerson
    {
        public string Name { get; set; }
        public int PCN { get; set; }
        public string Email { get; set; }
        public List<Tuple<string, int>> SeatNumbers { get; set; }
        public List<Tuple<string, string>> Password { get; set; }

        public Teacher(string name, int pcn, string email)
        {
            this.Name = name;
            this.PCN = pcn;
            this.Email = email;
        }

        public override string ToString()
        {
            return $"Teacher. Name:{Name}, pcn{PCN}, email:{Email}";
        }
    }

}
