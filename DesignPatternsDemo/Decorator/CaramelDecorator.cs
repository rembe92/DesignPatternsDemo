namespace DesignPatternsDemo.Decorator
{
    internal class CaramelDecorator : AddonDecorator
    {
        public CaramelDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override double Cost { get => Beverage.Cost + 2; }

        override public string? Description { get; set; }
    }
}
