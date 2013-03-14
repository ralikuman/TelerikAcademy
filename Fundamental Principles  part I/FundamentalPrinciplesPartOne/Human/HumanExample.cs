using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Humans
{
    public class HumanExample
    {
        /*2.	Define abstract class Human with first name and last name. 
         * Define new class Student which is derived from Human and has new field – grade. 
         * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. 
         * Define the proper constructors and properties for this hierarchy. 
         * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). 
         * Initialize a list of 10 workers and sort them by money per hour in descending order. 
         * Merge the lists and sort them by first name and last name.*/
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            //Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
            List<Student> students = new List<Student>(10);
            students.Add(new Student("Ivan", "Ivanov", Grades.Master));
            students.Add(new Student("Telerik", "Petrov", Grades.Master));
            students.Add(new Student("Kardam", "Ivanov", Grades.Master));
            students.Add(new Student("Agata", "Ivanova", Grades.College));
            students.Add(new Student("Sevar", "Ivanova", Grades.Bachelor));
            students.Add(new Student("Omurtag", "Petrova", Grades.Bachelor));
            students.Add(new Student("Tervel", "Ivanov", Grades.Bachelor));
            students.Add(new Student("Krum", "Georgiev", Grades.College));
            students.Add(new Student("Malamir", "Georiev", Grades.College));
            students.Add(new Student("Kubrat", "Ivanov", Grades.Bachelor));

            Console.WriteLine("---ALL STUDENTS---");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("---SORTED STUDENTS---");
            List<Student> sortedStudents = new List<Student>();
            sortedStudents = Student.SortByGrade(students);
            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item.ToString());
            }

            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workers = new List<Worker>(10);
            workers.Add(new Worker("Anastasia", "Krumova", 245.60M, 6));
            workers.Add(new Worker("Kardam", "Krumov", 545.60M, 8));
            workers.Add(new Worker("Anna", "Krumova", 445.65M, 5));
            workers.Add(new Worker("Irina", "Georieva", 145.00M, 7));
            workers.Add(new Worker("Sevar", "Krumov", 245.60M, 6));
            workers.Add(new Worker("Agata", "Ivanova", 335.60M, 4));
            workers.Add(new Worker("Kardam", "Krumov", 123.50M, 3));
            workers.Add(new Worker("Malamir", "Kardamov", 245.60M, 8));
            workers.Add(new Worker("Elena", "Petrova", 633.0M, 8));
            workers.Add(new Worker("Kardam", "Ivanov", 346.30M, 4));

            Console.WriteLine();
            Console.WriteLine("---WORKERS---");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("---SORTED WORKERS---");
            List<Worker> sortedWorkers = new List<Worker>();
            sortedWorkers = Worker.SortByMoneyPerHour(workers);
            foreach (var item in sortedWorkers)
            {
                Console.WriteLine(item.ToString());
            }

            /*Merge the lists and sort them by first name and last name.*/
            List<Human> people = new List<Human>();
            people.AddRange(workers);
            people.AddRange(students);

            var sortPeople =
            from human in people
            orderby human.FirstName, human.LastName
            select human;

            Console.WriteLine();
            Console.WriteLine("---SORTED PEOPLE BY NAME---");
            foreach (var item in sortPeople)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
