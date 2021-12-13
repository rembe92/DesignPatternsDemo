namespace DesignPatternsDemo.Behavial.Strategy
{
    internal class WildDuck : Duck
    {
        public WildDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }
    }
}
