namespace School
{
    public class School
    {
       //fields
        private string nameOfSchool;

        //properties
        public string NameOfSchool
        {
            get { return this.nameOfSchool; }

            set 
            {
                this.nameOfSchool = value; 
            }
        }

        //constructor 
        public School() { }

        public School(string name)
        {
            this.nameOfSchool = name;
        }
    }
}
