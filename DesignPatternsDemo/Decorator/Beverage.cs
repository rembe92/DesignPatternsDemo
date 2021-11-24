namespace DesignPatternsDemo.Decorator
{
    abstract internal class Beverage
    {
        abstract public string? Description { get; set; }

        abstract public double Cost { get; set; }
    }
}
