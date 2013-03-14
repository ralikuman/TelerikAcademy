using System;

namespace AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
        }

        public void MakeSound()
        {
            Console.WriteLine("kwa - kwa - kwa");
        }
    }
}
