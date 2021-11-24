namespace DesignPatternsDemo.Prototype
{
    internal class BookShop : ICloneable
    {
        public string Name { get; set; }
        List<Book> Books { get; set; } = new List<Book>();

        public BookShop(string name)
        {
            Name = name;
        }

        public void LoadData()
        {
            for (int i = 1; i <= 10; i++)
            {
                Books.Add( 
                    new Book()
                    {
                        Bid = i,
                        Name = "Book " + i
                    });
            }
        }

        public override string? ToString()
        {
            return $"Name: {Name} Books: {Books.Count()}";
        }

        public object Clone()
        {
            var shop = new BookShop(Name);
            foreach (var b in Books) { shop.Books.Add((Book)b.Clone()); }
            return shop;
        }
    }
}
