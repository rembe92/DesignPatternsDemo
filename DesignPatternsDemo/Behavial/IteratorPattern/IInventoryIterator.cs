namespace DesignPatternsDemo.Behavial.IteratorPattern
{
    internal interface IInventoryIterator<TItem>
    {
        bool IsDone();

        void Next();

        TItem? Current();

    }
}
