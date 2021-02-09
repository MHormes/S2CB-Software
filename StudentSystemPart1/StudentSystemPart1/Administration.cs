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
        List<Student> studentList;
        List<Teacher> teacherList;

        public Administration()
        {
            personList = new List<Person>();
            studentList = new List<Student>();
            teacherList = new List<Teacher>();
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
            foreach(Student s in studentList)
            {
                if(s.GetPcn() == pcn)
                {
                    return true;
                }
            }
            foreach(Teacher t in teacherList)
            {
                if(t.GetPcn() == pcn)
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

        public void AddStudent(Student s)
        {
            studentList.Add(s);
        }

        public void AddTeacher(Teacher t)
        {
            teacherList.Add(t);
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

        public Student GetStudent(int pcn)
        {
            foreach (Student s in studentList)
            {
                if (s.GetPcn() == pcn)
                {
                    return s;
                }
            }
            return null;
        }

        public Teacher GetTeacher(int pcn)
        {
            foreach(Teacher t in teacherList)
            {
                if (t.GetPcn() == pcn)
                {
                    return t;
                }
            }
            return null;
        }

        public Person[] GetPerson()
        {
            return this.personList.ToArray();
        }

        public Student[] GetStudents()
        {
            return this.studentList.ToArray();
        }

        public Teacher[] GetTeachers()
        {
            return this.teacherList.ToArray();
        }
    }
}
