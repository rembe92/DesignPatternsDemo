namespace DesignPatternsDemo.Prototype
{
    internal class Book : ICloneable
    {
        public int Bid { get; set; }

        public string Name { get; set; }

        public object Clone()
        {
            return new Book() { Bid = Bid, Name = Name };
        }
    }
}
