﻿namespace CSharpCodeFormatting.Events
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Event : IComparable
    {
        // Use order of definitions from lecture Code Formatting
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            private set
            {
                this.date = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                this.title = value;
            }
        }

        public string Location
        {
            get
            {
                return this.location;
            }

            private set
            {
                this.location = value;
            }
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            int byDate = this.Date.CompareTo(other.date);
            int byTitle = this.Title.CompareTo(other.title);
            int byLocation = this.Location.CompareTo(other.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            toString.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.Title);
            if (this.Location != null && this.Location != string.Empty)
            {
                toString.Append(" | " + this.Location);
            }

            return toString.ToString();
        }
    }
}