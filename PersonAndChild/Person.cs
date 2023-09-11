using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are asked to model an application for storing data about people. You should be able to have a person and a child. The child is derived of the person.
//Your task is to model the application. The only constraints are:

//People should not be able to have negative age
//Children should not be able to have age more than 15.
//• Person – represents the base class by which all others are implemented •
//Child - represents a class which is derived by the Person.Validate each member by throwing an ArgumentException.

//Box

namespace PersonAndChild
{
    internal class Person
    {
        private int age;
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        internal int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                age = value;
            }

        }
    }
}
