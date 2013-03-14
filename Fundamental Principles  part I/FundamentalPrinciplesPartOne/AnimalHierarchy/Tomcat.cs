namespace AnimalHierarchy
{
    class Tomcat : Cat
    {
        //tomcats can be only male. 
        public Tomcat(string name, int age)
            : base(name, age, Sex.Male)
        {
        }
    }
}
