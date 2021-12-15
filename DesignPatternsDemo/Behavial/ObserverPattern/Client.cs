namespace DesignPatternsDemo.Behavial.ObserverPattern
{
    internal class Client
    {
        public static void Demo()
        {
            var weatherStation = new WeatherStation();
            var phoneDisplay = new PhoneDisplay(weatherStation);
            var windowDisplay = new WindowsDisplay(weatherStation);
            weatherStation.Add(phoneDisplay);
            weatherStation.Add(windowDisplay);
            weatherStation.Temperature = 5;
        }
    }
}
