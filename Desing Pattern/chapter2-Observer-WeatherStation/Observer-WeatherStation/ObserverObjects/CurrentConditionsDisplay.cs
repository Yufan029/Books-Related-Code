using Observer_WeatherStation.SubjectObject;
using System.Runtime.CompilerServices;

namespace Observer_WeatherStation.ObserverObjects
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float pressure;
        private float humidity;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            this.temperature = this.weatherData.GetTemperature();
            this.humidity = this.weatherData.GetHumidity();

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature} F degrees and {humidity}% humidity");
        }
    }
}
