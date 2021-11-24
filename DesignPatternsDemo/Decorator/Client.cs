namespace DesignPatternsDemo.Decorator
{
    internal class Client
    {
        //Adds behavior to a partical object, without modifying it
        //Decorators should have other behaviors and should not be too similar to each other
        //source: https://www.youtube.com/watch?v=GCraGHx6gso&ab_channel=ChristopherOkhravi
        public void Demo()
        {
            var expresso = new Expresso();
            var expressoCaramel = new CaramelDecorator(expresso);
        }
    }
}
