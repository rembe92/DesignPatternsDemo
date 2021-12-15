using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Behavial.ObserverPattern
{
    internal class WeatherStation : IObservable
    {
        private int _temperature;

        public WeatherStation()
        {
            Observers = new HashSet<IObserver>();
        }

        public int Temperature 
        { 
            get => _temperature; 
            set 
            {
                _temperature = value;
                Notify(); 
            }
        }

        public ICollection<IObserver> Observers { get;  }

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
                observer.Update();
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }
    }
}
