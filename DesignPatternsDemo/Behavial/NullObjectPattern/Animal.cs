namespace DesignPatternsDemo.Behavial.NullObjectPattern
{
    internal abstract class Animal : IAnimal
    {
        public abstract void MakeSound();

        public static readonly IAnimal Null = new NullAnimal();

        private class NullAnimal : Animal
        {
            public override void MakeSound()
            {
                // Purposefully provides no behaviour.
            }
        }
    }
}
