namespace DesignPatternsDemo.Behavial.IteratorPattern
{
    internal class HandHeldInventoryInventory<TItem> : IInventory<TItem>
    {
        public TItem Right { get; private set; }
        public TItem Left { get; private set; }

        public HandHeldInventoryInventory(TItem right, TItem left)
        {
            Right = right;
            Left = left;
        }

        public IInventoryIterator<TItem> GetIterator()
        {
            return new HandHeldInventoryIterator<TItem>(this);
        }
    }
}
