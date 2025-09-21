using Observer_WeatherStation.SubjectObject;

namespace Observer_WeatherStation.ObserverObjects
{
    public class CurrentConditionsDisplay : IObserver, DisplayElement
    {
        private float temperature;
        private float pressure;
        private float humidity;

        //public CurrentConditionsDisplay(WeatherData weatherData)
        //{
        //    weatherData.RegisterObserver(this);
        //}

        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature} F degrees and {humidity}% humidity");
        }
    }
}
