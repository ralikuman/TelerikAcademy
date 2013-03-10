using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    //properties
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public byte Age { get; private set; }

    //constructors
    public Student(string firstName, string secondName)
        : this(firstName, secondName, 0)
    {
        this.FirstName = firstName;
        this.LastName = secondName;
        this.Age = 0;
    }

    public Student(string firstName, string secondName, byte age)
    {
        this.FirstName = firstName;
        this.LastName = secondName;
        this.Age = age;
    }

    //methods
    public override string ToString()
    {
        return String.Format("{0} {1} - {2} years", this.FirstName, this.LastName, this.Age);
    }

    //whose first name is before its last name alphabetically
    public static void SelectFirstNameBeforeLastAlphabet(Student[] students)
    {
        //use substring of first char of both names and compare it
        var printStudents =
        from stud in students
        where (char.Parse(stud.FirstName.Substring(0, 1)) < char.Parse(stud.LastName.Substring(0, 1)))
        select stud;

        Console.WriteLine();
        Console.WriteLine("Selected Names (first before last): ");
        foreach (var item in printStudents)
        {
            Console.WriteLine(item.ToString());
        }
    }

    //whose last name is before its  first name alphabetically
    public static void SelectLastNameBeforeFirstAlphabet(Student[] students)
    {
        //use  Compare(B, A): -1
        var printStudents =
        from stud in students
        where (stud.LastName.CompareTo(stud.FirstName) == -1)
        select stud;

        Console.WriteLine();
        Console.WriteLine("Selected Names(last before first): ");
        foreach (var item in printStudents)
        {
            Console.WriteLine(item.ToString());
        }
    }

    //ex.4
    public static void SelectNameByAge(Student[] students)
    {
        byte ageMin = 18;
        byte ageMax = 24;

        var printStudents =
        from stud in students
        where (stud.Age >= ageMin && stud.Age <= ageMax)
        select stud;

        Console.WriteLine();
        Console.WriteLine("Selected Names by age: ");
        foreach (var item in printStudents)
        {
            Console.WriteLine(item.ToString());
        }
    }

    //ex.5  b)
    public static void OrderByDescendingLinq(Student[] students)
    {
        var printStudents =
        from stud in students
        orderby stud.FirstName descending, stud.LastName descending
        select stud;

        Console.WriteLine();
        Console.WriteLine("ex.5 b) Sort by first and then last name with LINQ");
        foreach (var item in printStudents)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

