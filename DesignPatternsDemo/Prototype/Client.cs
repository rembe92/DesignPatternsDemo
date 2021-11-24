namespace DesignPatternsDemo.Prototype
{
    internal class Client
    {
        // It is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects
        // is used to avoid subclasses of an object creator in the client application, like the factory method pattern does
        // and to avoid the inherent cost of creating a new object in the standard way
        //source: https://en.wikipedia.org/wiki/Prototype_pattern
        public void Demo()
        {
            BookShop bs = new BookShop("Novelty");
            bs.LoadData();

            BookShop bs2 = (BookShop)bs.Clone();
        }
    }
}
