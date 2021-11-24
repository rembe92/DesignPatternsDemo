namespace DesignPatternsDemo.Decorator
{
    internal class SoyDecorator : AddonDecorator
    {
        public SoyDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost { get => Beverage.Cost + 1;}

        override public string? Description { get; set; }
    }
}
