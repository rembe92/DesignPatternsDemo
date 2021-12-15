using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Behavial.ObserverPattern
{
    internal class PhoneDisplay : IObserver
    {
        WeatherStation station;

        public PhoneDisplay(WeatherStation station)
        {
            this.station = station;
        }

        public void Update()
        {
            System.Console.WriteLine("Update PhoneDisplay, Temperature is now: " + station.Temperature);
        }
    }
}
