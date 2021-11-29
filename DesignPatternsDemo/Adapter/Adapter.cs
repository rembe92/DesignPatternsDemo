namespace DesignPatternsDemo.Adapter
{
    internal class Adapter : ITarget
    {
        readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public int Request()
        {
            return _adaptee.SpecificRequest();
        }
    }
}
