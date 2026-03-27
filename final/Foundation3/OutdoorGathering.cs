using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

public OutdoorGathering(string weatherForecaststring, string title, string description, string date, string time, Address address) : base( title,  description,  date,  time,  address)
    {
      _weatherForecast = weatherForecaststring;
    }

public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n Event Type: {GetType().Name}\n Weather Forecast: {_weatherForecast}. ";
    }
}