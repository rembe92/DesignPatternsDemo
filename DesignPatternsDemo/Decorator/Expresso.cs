namespace DesignPatternsDemo.Decorator
{
    internal class Expresso : Beverage
    {
        public override double Cost { get; set; } = 1;
        public override string? Description { get; set; }
    }
}
