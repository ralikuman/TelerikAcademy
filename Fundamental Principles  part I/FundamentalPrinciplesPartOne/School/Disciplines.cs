using System;
using System.Collections.Generic;

namespace School
{
    public class Discipline : ICommentable
    {
        //Disciplines have name, number of lectures and number of exercises.
        //properties
        private string disciplineName;
        private byte numberOfLectutes;
        private byte numberOfExercises;
        private List<string> comments;

        //properties
        public string DisciplineName
        {
            get
            {
                return this.disciplineName;
            }

            private set
            {
                if (value.Length <= 1)
                {
                    throw new ArgumentException("The name must be large than one symbol!");
                }
                this.disciplineName = value;
            }
        }

        public byte NumberOfLectutes
        {
            get
            {
                return this.numberOfLectutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The number of lecture must be larger than 0!");
                }
                this.numberOfLectutes = value;
            }
        }

        public byte NumberofExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The number of exercises must be 0 or pozitive number!");
                }
                this.numberOfExercises = value;
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
        public Discipline(string disciplineName)
            : this(null, disciplineName, 0, 0)
        { }

        public Discipline(string disciplineName, byte numberOfLectures)
            : this(null, disciplineName, numberOfLectures, 0)
        { }

        public Discipline(string disciplineName, byte numberOfLectures, byte numberOfExercises)
            : this(null, disciplineName, numberOfLectures, numberOfExercises)
        { }

        public Discipline(string nameOFSchool, string disciplineName, byte numberOfLectures, byte numberOfExercises)
        {
            this.disciplineName = disciplineName;
            this.numberOfLectutes = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this.comments = new List<string>();
        }

        //methods
        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }
    }
}
