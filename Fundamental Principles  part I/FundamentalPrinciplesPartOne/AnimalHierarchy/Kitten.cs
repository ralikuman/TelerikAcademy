namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        //Kittens can be only female
        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {
        }
    }
}
