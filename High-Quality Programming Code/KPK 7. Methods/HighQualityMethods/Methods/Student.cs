// <copyright file="Student.cs" company="Telerik Academy">
// Copyright (c) 2013 Telerik Academy. All rights reserved.
// </copyright>

namespace Methods
{
    using System;

    /// <summary>
    /// Class Student represent student information.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Get first name of student as unicode characters.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Get last name of student as unicode characters.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Get other additional information of student as unicode characters.
        /// </summary>
        public string OtherInfo { get; set; }

        /// <summary>
        /// Find is student is bigger than other student.
        /// </summary>
        /// <param name="other">other info</param>
        /// <returns>Return boolean</returns>
        public bool IsOlderThan(Student other)
        {
            string firstStudentBirthDate = this.OtherInfo.Substring(this.OtherInfo.Length - 10);
            DateTime firstBirthDate = DateTime.Parse(firstStudentBirthDate);

            string secondStudentBirthDate = other.OtherInfo.Substring(other.OtherInfo.Length - 10);
            DateTime secondBirthDate = DateTime.Parse(secondStudentBirthDate);

            bool isOlder = firstBirthDate < secondBirthDate;

            return isOlder;
        }
    }
}
