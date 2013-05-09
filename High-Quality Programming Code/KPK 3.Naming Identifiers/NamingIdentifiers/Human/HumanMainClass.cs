namespace Human
{
    using System;
    using System.Linq;

    public class HumanMainClass
    {
        public static void Main()
        {
            Human man = new Human();
            CreateHuman(10);
            Console.WriteLine("{0} {1}", man.FullName, man.Gender);
        }

        public static void CreateHuman(int magicAge)
        {
            Human human = new Human();
            human.Age = magicAge;

            if (magicAge % 2 == 0)
            {
                human.FullName = "The Boy";
                human.Gender = Gender.Male;
            }
            else
            {
                human.FullName = "The Girl";
                human.Gender = Gender.Female;
            }
        }
    }
}
