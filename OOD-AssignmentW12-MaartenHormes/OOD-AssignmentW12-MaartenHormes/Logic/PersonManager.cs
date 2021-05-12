using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OOD_AssignmentW12_MaartenHormes
{
    public class PersonManager
    {
        private List<IPerson> people;

        public PersonManager()
        {
            this.people = new List<IPerson>();
        }

        public Exception AddNewPerson(bool isStudent, string name, string pcn, string email)
        {
            try
            {
                ValidateUserInput(pcn, email);
                if (GetPerson(Convert.ToInt32(pcn)) != null)
                {
                    throw new PcnTakenException(pcn);
                }
                if (isStudent)
                {
                    IPerson newStudent = new Student(name, Convert.ToInt32(pcn), email);
                    people.Add(newStudent);
                }
                else
                {
                    IPerson newTeacher = new Teacher(name, Convert.ToInt32(pcn), email);
                    people.Add(newTeacher);
                }
                return null;
            }
            catch (IncorrectPCNInputException pcnInputEx)
            {
                return pcnInputEx;
            }
            catch (IncorrectEmailException emailEx)
            {
                return emailEx;
            }
            catch (PcnTakenException pcnEx)
            {
                return pcnEx;
            }
            catch(Exception ex)
            {
                return ex;
            }
        }

        public Exception UpdatePerson(IPerson person, string name, string pcn, string email)
        {
            try
            {
                IPerson personToUpdate = person;
                ValidateUserInput(pcn, email);
                if(person.PCN != Convert.ToInt32(pcn))
                {
                    if (GetPerson(Convert.ToInt32(pcn)) != null)
                    {
                        throw new PcnTakenException(pcn);
                    }
                }
                personToUpdate.Name = name;
                personToUpdate.PCN = Convert.ToInt32(pcn);
                personToUpdate.Email = email;
                return null;
            }
            catch (IncorrectPCNInputException pcnInputEx)
            {
                return pcnInputEx;
            }
            catch (IncorrectEmailException emailEx)
            {
                return emailEx;
            }
            catch (PcnTakenException pcnEx)
            {
                return pcnEx;
            }
            catch (Exception ex)
            {
                return ex;
            }
            
        }

        public bool DeletePerson(IPerson person)
        {
            if (people.Contains(person))
            {
                people.Remove(person);
                return true;
            }
            return false;
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

        private void ValidateUserInput(string pcn, string email)
        {
            if(!Regex.IsMatch(pcn, @"^[0-9]{6}$"))
            {
                throw new IncorrectPCNInputException(pcn);
            }
            if (!Regex.IsMatch(email, @"^[A-z0-9._-]+@[A-z0-9._-]+.[a-z]+$"))
            {
                throw new IncorrectEmailException(email);
            }
            
            
        }
    }
}
