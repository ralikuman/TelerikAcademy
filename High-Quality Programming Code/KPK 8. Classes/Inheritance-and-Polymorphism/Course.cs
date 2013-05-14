namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Course
    {      
        public Course(string name) 
            : this(name, null, null)
        {
        }

        public Course(string courseName, string teacherName)
            : this(courseName, teacherName, null)
        {
        }
        
        public Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        public override string ToString()
        {
            StringBuilder courseInfo = new StringBuilder();

            if (this.TeacherName != null)
            {
                courseInfo.Append("; Teacher = ");
                courseInfo.Append(this.TeacherName);
            }

            courseInfo.Append("; Students = ");
            courseInfo.Append(this.GetStudentsAsString());

            return courseInfo.ToString();
        }

        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }    
    }
}