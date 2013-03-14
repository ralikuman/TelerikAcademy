using System.Collections.Generic;

namespace School
{
    public class Teacher : Person, ICommentable
    {
        private List<Discipline> disciplinesOfTeacher = new List<Discipline>();
        private List<string> comments;

        //properies
        public List<Discipline> DisciplinesOfTeacher
        {
            get
            {
                return this.disciplinesOfTeacher;
            }
            set
            {
                this.disciplinesOfTeacher = value;
            }
        }
        
        public string[] Comments
        {
            get
            {
                return this.comments.ToArray();
            }
        }


        //constructors
        public Teacher(string name, Discipline[] disciplinesOfTeacher)
            : base(name)
        {
            this.disciplinesOfTeacher = new List<Discipline>(disciplinesOfTeacher);
            this.comments = new List<string>();
        }

        //methods
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        public void AddDiscipline(string disciplineName,byte numberOfLectutes, byte numberOfExercises)
        {
            Discipline discipline = new Discipline(disciplineName, numberOfLectutes, numberOfExercises);
            disciplinesOfTeacher.Add(discipline);
        }

        public void RemoveDiscipline(string disciplineName)
        {
            Discipline discipline = new Discipline(disciplineName);
            disciplinesOfTeacher.Remove(discipline);
        }

    }
}
