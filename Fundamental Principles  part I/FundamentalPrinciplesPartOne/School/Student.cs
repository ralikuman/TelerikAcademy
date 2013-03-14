using System.Collections.Generic;
namespace School
{
    public class Student : Person, ICommentable
    {
        // * Students have name and unique class number.
       //fields
        private int classNumber;
        private List<string> comments;

        //properties
        public int ClassNumber
        {
            get 
            {
                return this.classNumber;
            }
            set 
            {
                this.classNumber = value;
            }
        }

        public string[] Comments
        {
            get
            {
                return this.comments.ToArray();
            }
        }

        //constructor 
        public Student(string name) : base(name)
        {
        }

        public Student(string name, int classNumber)
            : this(name, classNumber, null)
        {
            this.classNumber = classNumber;
            this.comments = new List<string>();
        }

        public Student(string name, int classNumber, List<string> comments)
            : base(name)
        {
            this.classNumber = classNumber;
            this.comments = new List<string>();
        }

        //methods
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
