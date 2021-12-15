namespace DesignPatternsDemo.Behavial.ObserverPattern
{
    internal interface IObservable
    {
        public ICollection<IObserver> Observers { get; }

        public void Add(IObserver observer);

        public void Remove(IObserver observer);

        public void Notify();
    }
}
