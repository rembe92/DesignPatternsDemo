namespace DesignPatternsDemo.Decorator
{
    abstract internal class AddonDecorator : Beverage
    {
        public Beverage Beverage { get; init; }

        public AddonDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override double Cost { get; set; }

        public override string? Description { get; set; }
    }
}
