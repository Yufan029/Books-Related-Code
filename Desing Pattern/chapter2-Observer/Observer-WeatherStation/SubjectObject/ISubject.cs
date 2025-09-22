using Observer_WeatherStation.ObserverObjects;

namespace Observer_WeatherStation.SubjectObject
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
        public float GetTemperature();
        public float GetHumidity();
    }
}
