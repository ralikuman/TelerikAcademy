using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public abstract class Animal
    {
        // All animals are described by age, name and sex.
        private string name;
        private int age;
        private Sex sex;

        public string Name 
        {
            get { return this.name; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentException("the name can not be null");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(String.Format("the age can not be less than zero {0}", this.Age));
                }
                else
                {
                    this.age = value;
                }
            }
        }

        public Sex Sex
        {
            get { return this.sex; }
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Animal(string name, int age, Sex sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public static double CalculateAverageAgeOfAnimals(Animal[] animals)
        {
            int sumOfAge = 0;
            for (int i = 0; i < animals.Length; i++)
            {
                sumOfAge += animals[i].Age; 
            }
            double averageAge = (double)sumOfAge/animals.Length;
            return averageAge;
        }

        public static void CalculateAverageAgeOfKind(Animal[] animals)
        {
            //calculate the average age of each kind of animal
            var animalGroups =
                (from animal in animals
                 group animal by animal.GetType().Name into groups
                 select new
                 {
                     name = groups.Key,
                     average =
                         (from anim in groups
                          select anim.Age).Average()
                 });

            foreach (var item in animalGroups)
            {
                Console.WriteLine(item);
            }
        }
        public override string ToString()
        {
            return String.Format("Name: {0} " + "\t" + "Age: {1}" + "\t" + "Sex:{2}", this.Name, this.Age, this.Sex);
        }
    }
}
