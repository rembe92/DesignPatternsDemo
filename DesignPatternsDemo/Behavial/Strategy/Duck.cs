namespace DesignPatternsDemo.Behavial.Strategy
{
    internal  abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }

        public IQuackBehavior QuackBehavior { get; set; }

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }
    }
}
