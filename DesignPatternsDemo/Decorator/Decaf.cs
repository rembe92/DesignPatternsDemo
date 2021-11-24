namespace DesignPatternsDemo.Decorator
{
    internal class Decaf : Beverage
    {
        public override double Cost { get; set; } = 2;
        public override string? Description { get; set; }
    }
}
