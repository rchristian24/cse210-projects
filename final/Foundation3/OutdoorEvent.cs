public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public string GetFullOutdoorDetails()
    {
        return $"{GetStandardDetails()}\r\nWeather Forecast:{_weather}";
    }
}