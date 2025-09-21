using Observer_WeatherStation.SubjectObject;

namespace Observer_WeatherStation.ObserverObjects
{
    public class StatisticsDisplay : IObserver, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;

        //public StatisticsDisplay(WeatherData weatherData)
        //{
        //    weatherData.RegisterObserver(this);
        //}

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {temperature}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
