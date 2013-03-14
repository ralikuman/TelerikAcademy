using System;

namespace AnimalHierarchy
{
    class Cat : Animal, ISound
    {
        public Cat(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("may - may - marrrr");
        }
    }
}
