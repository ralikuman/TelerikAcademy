using System;
using System.Collections.Generic;
using System.Linq;

namespace Humans
{
    public abstract class Human
    {
        /*Define abstract class Human with first name and last name. */
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        //constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}