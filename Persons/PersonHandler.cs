using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person pers = new Person() { Age = age, FName = fname, LName = lname, Height = height, Weight = weight };
            return pers;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFirstName(Person pers, string fname)
        {
            pers.FName = fname;
        }
        public void SetLastName(Person pers, string lname)
        {
            pers.LName = lname;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
    }
}
