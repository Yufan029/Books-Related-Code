using Observer_WeatherStation.ObserverObjects;
using Observer_WeatherStation.SubjectObject;

WeatherData weatherData = new WeatherData();
//weatherData.RegisterObserver(new CurrentConditionsDisplay());
//weatherData.RegisterObserver(new StatisticsDisplay());
//weatherData.RegisterObserver(new ForecastDisplay());

CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
var heatIndexDisplay = new HeatIndexDisplay(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);