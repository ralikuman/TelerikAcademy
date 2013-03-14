using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    public class Student : Human
    {
        /* Define new class Student which is derived from Human and has new field – grade. */
        public Grades Grade { get; private set; }

        //constructor
        public Student(string fName, string lName, Grades grade)
            : base(fName, lName)
        {
            this.Grade = grade;
        }

        //method to sort them by grade in ascending order
        public static List<Student> SortByGrade(List<Student> students)
        {
            var sortedStudents =
            from student in students
            orderby student.Grade ascending
            select student;

            List<Student> sortedStudentsList = new List<Student>(students.Capacity);
            foreach (var item in sortedStudents)
            {
                sortedStudentsList.Add(item);
            }
            return sortedStudentsList;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}