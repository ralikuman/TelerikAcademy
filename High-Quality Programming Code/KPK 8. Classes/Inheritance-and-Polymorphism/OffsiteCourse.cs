namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string name) : base(name)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName) : base(courseName, teacherName)
        {
            this.Town = null;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students) : base(courseName, teacherName, students)
        {
            this.Town = null;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            StringBuilder offsiteCourseInfo = new StringBuilder();
            offsiteCourseInfo.Append("OffsiteCourse { Name = ");
            offsiteCourseInfo.Append(this.Name);
            offsiteCourseInfo.Append(base.ToString());
            if (this.Town != null)
            {
                offsiteCourseInfo.Append("; Town = ");
                offsiteCourseInfo.Append(this.Town);
            }

            offsiteCourseInfo.Append(" }");
            return offsiteCourseInfo.ToString();
        }
    }
}
