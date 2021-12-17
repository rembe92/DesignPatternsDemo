namespace DesignPatternsDemo.Behavial.NullObjectPattern
{
    public static class Client
    {
        //source https://en.wikipedia.org/wiki/Null_object_pattern
        public static void Demo()
        {
            IAnimal dog = new Dog();
            dog.MakeSound(); // outputs "Woof!"

            /* Instead of using C# null, use the Animal.Null instance.
             * This example is simplistic but conveys the idea that if the Animal.Null instance is used then the program
             * will never experience a .NET System.NullReferenceException at runtime, unlike if C# null were used.
             */
            IAnimal unknown = Animal.Null;  //<< replaces: IAnimal unknown = null;
            unknown.MakeSound(); // outputs nothing

        }
    }
}
