namespace DesignPatternsDemo.Structural.CompositePattern
{
    internal class Composite : IComponent
    {
        ICollection<IComponent> components;

        public Composite(ICollection<IComponent> components)
        {
            this.components = components;
        }

        public void Operation()
        {
            throw new NotImplementedException();
        }
    }
}
