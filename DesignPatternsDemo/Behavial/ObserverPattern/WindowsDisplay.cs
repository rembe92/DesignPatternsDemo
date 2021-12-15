namespace DesignPatternsDemo.Behavial.ObserverPattern
{
    internal class WindowsDisplay : IObserver
    {
        WeatherStation station;

        public WindowsDisplay(WeatherStation station)
        {
            this.station = station;
        }

        public void Update()
        {
            System.Console.WriteLine("Update WindowsDisplay, Temperature is now: " + station.Temperature);
        }
    }
}
