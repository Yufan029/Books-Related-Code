using Observer_WeatherStation.ObserverObjects;

namespace Observer_WeatherStation.SubjectObject
{
    public class WeatherData : Subject
    {
        private readonly List<Observer> observers = new List<Observer>();
        private float temperature;
        private float humidity;
        private float pressure;

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            foreach (var o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }
    }
}
