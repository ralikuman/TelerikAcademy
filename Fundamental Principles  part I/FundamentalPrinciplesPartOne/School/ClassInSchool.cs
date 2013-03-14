using System;
using System.Collections.Generic;

namespace School
{
    public class ClassInSchool : School, ICommentable
    {
        //fields
        private string classIdentifier;
        private List<Teacher> teachers;
        private List<Student> students;
        private List<string> comments;

        //properties
        public string ClassIdentifier
        {
            get
            {
                return this.classIdentifier;
            }

            private set
            {
                if (value.Length <= 1)
                {
                    throw new ArgumentException("The unique text identifier must be large than one symbol!");
                }
                this.classIdentifier = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                this.teachers = value;
            }
        }

        public string[] Comments
        {
            get
            {
                return this.comments.ToArray();
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }

        //constructors
        public ClassInSchool(string classIdentifier, List<Teacher> teachers)
            : this(null, classIdentifier, teachers, null, null)
        { }

        public ClassInSchool(string nameOfSchool, string classIdentifier, List<Teacher> teachers, List<Student> students, List<string> comments)
            : base(nameOfSchool)
        {
            this.classIdentifier = classIdentifier;
            this.teachers = teachers;
            this.students = students;
            this.comments = new List<string>();
        }

        //methods
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        public void AddTeacher(string name, Discipline[] disciplines)
        {
            Teacher teacher = new Teacher(name, disciplines);
            teachers.Add(teacher);
        }

        public void RemoveTeacher(string name, Discipline[] disciplines)
        {
            Teacher teacher = new Teacher(name, disciplines);
            teachers.Remove(teacher);
        }

        public void AddStudent(string name, int classNumber, List<string> comments)
        {
            Student strudent = new Student(name, classNumber, comments);
            students.Remove(strudent);
        }

        public void RemoveStudent(string name, int classNumber)
        {
            Student strudent = new Student(name, classNumber);
            students.Remove(strudent);
        }
    }
}
