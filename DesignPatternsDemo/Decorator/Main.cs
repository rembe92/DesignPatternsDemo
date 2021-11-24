namespace DesignPatternsDemo.Decorator
{
    internal class Main
    {
        public void Demo()
        {
            var expresso = new Expresso();
            var expressoCaramel = new CaramelDecorator(expresso);
        }
    }
}
