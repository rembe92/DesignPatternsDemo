namespace DesignPatternsDemo.Behavial.IteratorPattern
{
    internal class HandHeldInventoryIterator<TItem> : IInventoryIterator<TItem>
    {
        HandHeldInventoryInventory<TItem> inventory;

        int index = 0;

        public HandHeldInventoryIterator(HandHeldInventoryInventory<TItem> handHeldInventoryInventory)
        {
            inventory = handHeldInventoryInventory;
        }

        public TItem? Current()
        {
            switch (index)
            {
                case 0:
                    return inventory.Right;
                    case 1:
                    return inventory.Left;
                default:
                    return default;
            }
        }

        public bool IsDone()
        {
            return index < 2;
        }

        public void Next()
        {
            index++;
        }
    }
}
