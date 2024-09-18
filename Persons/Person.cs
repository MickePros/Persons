using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age { 
            get { return age; } 
            set {
                try
                {
                    if (value > 0)
                    {
                        age = value;
                    }
                    else
                    {
                        throw new ArgumentException("Age must be higher than 0");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            } 
        }
        public required string FName { 
            get { return fName; }
            set
            {
                try
                {
                    if (value.Length > 2 && value.Length < 10)
                    {
                        fName = value;
                    }
                    else
                    {
                        throw new ArgumentException("First name must be at least 2 letters, but no more than 10 letters");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public required string LName { 
            get { return lName; }
            set
            {
                try
                {
                    if (value.Length > 3 && value.Length < 15)
                    {
                        lName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Last name must be at least 3 letters, but no more than 15 letters");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public double Height { get { return height; } set { height = value; } }
        public double Weight { get { return weight; } set { weight = value; } }

    }
}
