using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class PersonManager
    {
        private List<IPerson> people;

        public PersonManager()
        {
            this.people = new List<IPerson>();
        }

        public Exception AddNewPerson(string name, int pcn, string email)
        {
            return null;
        }

        public IPerson GetPerson(int pcn)
        {
            foreach(IPerson p in people)
            {
                if(p.PCN == pcn)
                {
                    return p;
                }
            }
            return null;
        }

        public List<IPerson> GetPersons()
        {
            return this.people;
        }
    }
}
