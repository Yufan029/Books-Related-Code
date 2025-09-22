using Observer_WeatherStation.SubjectObject;

namespace Observer_WeatherStation.ObserverObjects
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {temperature}");
        }

        public void Update()
        {
            temperature = this.weatherData.GetTemperature();

            Display();
        }
    }
}
