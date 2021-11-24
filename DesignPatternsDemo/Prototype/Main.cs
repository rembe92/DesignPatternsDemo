namespace DesignPatternsDemo.Prototype
{
    internal class Main
    {
        public void Demo()
        {
            BookShop bs = new BookShop("Novelty");
            bs.LoadData();

            BookShop bs2 = (BookShop)bs.Clone();
        }
    }
}
