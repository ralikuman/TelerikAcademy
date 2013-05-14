namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        public LocalCourse(string name) : base(name)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
            this.Lab = null;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students) : base(courseName, teacherName, students)
        {
            this.Lab = null;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            StringBuilder localCourseInfo = new StringBuilder();
            localCourseInfo.Append("LocalCourse { Name = ");
            localCourseInfo.Append(this.Name);
            localCourseInfo.Append(base.ToString());
            if (this.Lab != null)
            {
                localCourseInfo.Append("; Lab = ");
                localCourseInfo.Append(this.Lab);
            }

            localCourseInfo.Append(" }");
            return localCourseInfo.ToString();
        }
    }
}
