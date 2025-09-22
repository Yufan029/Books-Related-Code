using Observer_WeatherStation.ObserverObjects;

namespace Observer_WeatherStation.SubjectObject
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;
        private float pressure;

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
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
                o.Update();
            }
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }

        public float GetTemperature()
        {
            return this.temperature;
        }

        public float GetHumidity()
        {
            return this.humidity;
        }

        public float GetPressure()
        {
            return this.pressure;
        }
    }
}
