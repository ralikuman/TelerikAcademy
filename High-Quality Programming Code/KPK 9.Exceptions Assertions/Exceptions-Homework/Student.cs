using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public IList<Exam> Exams { get; set; }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (firstName == null || firstName == string.Empty)
        {
            throw new ArgumentNullException("firstName", "First name of student can not be null.");
        }

        if (lastName == null || lastName == string.Empty)
        {
            throw new ArgumentNullException("lastName", "Last name of student can not be null.");
        }

        if (exams == null)
        {
            throw new ArgumentNullException("exams", "List of exams can not be null");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> GetExamResults()
    {
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].GetExamResult());
        }

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        if (this.Exams.Count == 0)
        {
            return 0;
        }

        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = GetExamResults();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                          ((double)examResults[i].Grade - examResults[i].MinGrade) /
                          (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
