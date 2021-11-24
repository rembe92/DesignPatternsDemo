namespace DesignPatternsDemo.FactoryMethod
{
    //deal with the problem of creating objects without having to specify the exact class of the object that will be created
    //source: https://www.youtube.com/watch?v=EcFVTgRHJLM&t=498s&ab_channel=ChristopherOkhravi
    internal class Client
    {
        public void Demo()
        {
            IAnimalFactory animalFactory = new RandomAnimalFactory();
            var animal = animalFactory.CreateAnimal();
        }
    }
}
