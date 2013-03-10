using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FindStudentsExample
{
    /*3.	Write a method that from a given array of students finds all students 
     * whose first name is before its last name alphabetically. Use LINQ query operators.
      
     * 4.   Write a LINQ query that finds the first name and last name of all students with age between 18 and 24
     
     * 5.	Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. 
     * Rewrite the same with LINQ. */

    /*3.4.5.FindStudents - означава че в 1 проект са решенията на зад 3, 4 и 5 */

    static void Main()
    {
        Student[] students = {  new Student("Petar", "Petrov", 18),
                                new Student("Test", "Petrov", 24),
                                new Student("Petar", "Ivanov", 67),
                                new Student("Maxim", "Angelov", 34),
                                new Student("Angel", "Maxim", 19),                         				
				                new Student("Ivan", "Ivanov"),
				                new Student("Peter", "Stoianov"),
				                new Student("Ani", "Milrnova")
                             };

        Console.WriteLine("Print all names of students");
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }

        //ex.3 a)  
        //first name is before its last name alphabetically
        Student.SelectFirstNameBeforeLastAlphabet(students);

        //ex.3 b)  
        //last name is before its first name alphabetically
        Student.SelectLastNameBeforeFirstAlphabet(students);

        //ex.4  
        Student.SelectNameByAge(students);

        //ex.5 a) lambda
        Console.WriteLine();
        Console.WriteLine("ex.5 a) Sort by first and then last name with lambda");
        var sortByLambda = students.OrderByDescending(s => s.FirstName).ThenByDescending(x => x.LastName);
        foreach (var stud in sortByLambda)
        {
            Console.WriteLine(stud.ToString());
        }

        //ex.5 b) with linq
        Student.OrderByDescendingLinq(students);
    }
}
