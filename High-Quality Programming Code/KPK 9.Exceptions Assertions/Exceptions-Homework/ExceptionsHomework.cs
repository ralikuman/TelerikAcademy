using System;
using System.Collections.Generic;

public class ExceptionsHomework
{
    public static void Main()
    {
        var substr = Utilities.Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Utilities.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Utilities.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Utilities.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(Utilities.ExtractEnding("I love C#", 2));
        Console.WriteLine(Utilities.ExtractEnding("Nakov", 4));
        Console.WriteLine(Utilities.ExtractEnding("beer", 4));
        ////Console.WriteLine(Utilities.ExtractEnding("Hi", 100));

        Console.WriteLine("23 is prime => {0}", Utilities.CheckPrime(23));
        Console.WriteLine("33 is prime => {0}", Utilities.CheckPrime(33));
        ////Console.WriteLine("23 is prime => {0}", Utilities.CheckPrime(-4));
        Console.WriteLine();

        Console.WriteLine("STUDENTS");
        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results of Peter = {0:p0}", peterAverageResult);

        List<Exam> katyExams = new List<Exam>() 
        { 
        };
        Student katy = new Student("Katy", "Ken", katyExams);
        double ketyAverageResult = katy.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results of Katy = {0:p0}", ketyAverageResult);
    }
}
