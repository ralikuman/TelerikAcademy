using System;

public class ExamResult
{
    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException(
                "grade",
                string.Format("Grade have to be pozitive. Your input is {0}.", grade)); 
        }

        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException(
                "minGrade",
                string.Format("Minimal Grade have to be pozitive. Your input is {0}.", minGrade)); 
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException(
                "maxGrade",
                string.Format("Maximal grade can not be smaller/equal than minimal grade; minGrade = {0}, maxGrade = {1}.", minGrade, maxGrade)); 
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentNullException("comments", "Comments can not be null or empty string.");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}
