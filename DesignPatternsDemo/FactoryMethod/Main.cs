namespace DesignPatternsDemo.FactoryMethod
{
    //source: https://www.youtube.com/watch?v=EcFVTgRHJLM&t=498s&ab_channel=ChristopherOkhravi
    internal class Main
    {
        public void Demo()
        {
            IAnimalFactory animalFactory = new RandomAnimalFactory();
            var animal = animalFactory.CreateAnimal();
        }
    }
}
