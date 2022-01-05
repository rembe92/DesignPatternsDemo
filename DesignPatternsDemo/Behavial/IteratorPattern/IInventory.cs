namespace DesignPatternsDemo.Behavial.IteratorPattern
{
    internal interface IInventory<TItem> //iterable
    {
        public IInventoryIterator<TItem> GetIterator();
    }
}
