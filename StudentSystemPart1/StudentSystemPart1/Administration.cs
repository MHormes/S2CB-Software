using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystemPart1
{
    public class Administration
    {
        List<Person> personList;
        

        public Administration()
        {
            personList = new List<Person>();
        }

        public bool AlreadyExcists(int pcn)
        {
            foreach(Person p in personList)
            {
                if(p.GetPcn() == pcn)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddPerson(Person p)
        {
            personList.Add(p);
        }

        public Person GetPerson(int pcn)
        {
            foreach(Person p in personList)
            {
                if(p.GetPcn() == pcn)
                {
                    return p;
                }
            }
            return null;
        }

        public Person[] GetPerson()
        {
            return this.personList.ToArray();
        }
    }
}
