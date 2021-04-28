using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class Teacher : IPerson
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PCN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Tuple<string, int>> SeatNumbers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Tuple<string, string>> Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Teacher(string name, int pcn, string email)
        {
            this.Name = name;
            this.PCN = pcn;
            this.Email = email;
        }
    }

}
