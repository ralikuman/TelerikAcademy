using System;

namespace AnimalHierarchy
{
    class Dog : Animal, ISound
    {
        public Dog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }
        public void MakeSound()
        {
            Console.WriteLine("bay - bay - bay");
        }
    }
}
