using Observer_WeatherStation.SubjectObject;

namespace Observer_WeatherStation.ObserverObjects
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Forcast: Imporving weather on the way!");
        }

        public void Update()
        {
            this.temperature = this.weatherData.GetTemperature();
            this.humidity = this.weatherData.GetHumidity();
            this.pressure = this.weatherData.GetPressure();

            Display();
        }
    }
}
