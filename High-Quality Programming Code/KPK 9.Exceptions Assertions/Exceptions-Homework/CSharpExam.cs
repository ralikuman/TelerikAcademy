using System;

public class CSharpExam : Exam
{ 
    private const int MIN_SCORE = 0;
    private const int MAX_SCORE = 100;

    public int Score { get; private set; }

    public CSharpExam(int score)
    {
        if (score < 0)
        {
            throw new ArgumentOutOfRangeException(
               "score",
               string.Format("Score have to be pozitive. Your input is {0}.", score)); 
        }

        this.Score = score;
    }

    public override ExamResult GetExamResult()
    {
        if (this.Score < MIN_SCORE || this.Score > MAX_SCORE)
        {
            throw new ArgumentOutOfRangeException(
               "score",
               string.Format("Score have to be between ({0}, {1}). Your score is {2}", MIN_SCORE, MAX_SCORE, this.Score)); 
        }
        else
        {
            return new ExamResult(this.Score, MIN_SCORE, MAX_SCORE, "Exam results calculated by score.");
        }
    }
}
