using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class AnimalsExample
    {
        /*3.	Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
         * Dogs, frogs and cats are Animals. 
         * All animals can produce sound (specified by the ISound interface). 
         * Kittens and tomcats are cats. 
         * All animals are described by age, name and sex. 
         * Kittens can be only female and tomcats can be only male. 
         * Each animal produces a specific sound. 
         * Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).*/
        
        static void Main()
        {
            //create different animals
            Cat cat = new Cat("Catty", 3, Sex.Female);
            Dog dog = new Dog("Silvestar", 5, Sex.Male);
            Frog froggy = new Frog("Froggy", 1, Sex.Female);
            Kitten kitten = new Kitten("Kitty", 5);
            Kitten kittenCat = new Kitten("Kety", 3);
            Tomcat tomcat = new Tomcat("Tom", 6);

            //produces a specific sound
            Console.Write("Cat make sound: ");
            cat.MakeSound();

            Console.Write("Dog make sound: ");
            dog.MakeSound();

            Console.Write("Frog make sound: ");
            froggy.MakeSound();

            Console.WriteLine();
            //Create arrays of different kinds of animals
            Animal[] animals = { cat, dog, froggy, kitten, tomcat, kittenCat};
            foreach (var ani in animals)
            {
                Console.WriteLine(ani.ToString());     
            }
  
            //calculate the average age of all animals
            double agerageAgeOfAnimals = Animal.CalculateAverageAgeOfAnimals(animals);
            Console.WriteLine();
            Console.WriteLine("Average age of all animals is {0:F3}", agerageAgeOfAnimals);

            //calculate the average age of each kind of animal 
            Console.WriteLine("Average of each kind is: ");
            Animal.CalculateAverageAgeOfKind(animals);
        }
    }
}
