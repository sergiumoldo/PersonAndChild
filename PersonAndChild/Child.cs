using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndChild
{
    internal class Child : Person
    {

        public Child(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        
        public int Age {
                        get { return this.Age; }
                        set
                        {
                            if (value > 15)
                            {
                                throw new ArgumentException("Age should be between 0 and 15 for a child.");
                            }
                            Age = value;
                        }
        } 

    }
}
