using Observer_WeatherStation.SubjectObject;

namespace Observer_WeatherStation.ObserverObjects
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;

        //public ForecastDisplay(WeatherData weatherData)
        //{
        //    weatherData.RegisterObserver(this);
        //}

        public void Display()
        {
            Console.WriteLine("Forcast: Imporving weather on the way!");
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
