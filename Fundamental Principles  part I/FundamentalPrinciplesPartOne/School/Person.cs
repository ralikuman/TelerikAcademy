using System;

namespace School
{
    public class Person
    {
        //fields
        private string name;

        //properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentException("The name of owner have to greatter than zero!");
                }
                foreach (char ch in value)
                {
                    if (!IsLetterAllowedInNames(ch))
                    {
                        throw new ArgumentException("Invalid name! Use only letters, space and hyphen");
                    }
                }
                this.name = value;
            }
        }
        private bool IsLetterAllowedInNames(char ch)
        {
            bool isAllowed =
                char.IsLetter(ch) || ch == '-' || ch == ' ';
            return isAllowed;
        }

        //constructor

        public Person()
        { }

        public Person(string name)
        {
            this.name = name;
        }
    }
}
