namespace DesignPatternsDemo.FactoryMethod
{
    internal class RandomAnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal()
        {
            var rnd = new Random();
            var i = rnd.Next(0,2);
            if (i == 0)
                return new Dog();
            if (i == 1)
                return new Cat();
            if (i == 2)
                return new Duck();

            return new Cat();
        }
    }
}
