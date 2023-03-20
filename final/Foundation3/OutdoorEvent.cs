public class OutdoorEvent : Event
{
    private string _weather;

    public OutdoorEvent(string title, string description, string date, string time, string typeOfEvent, Address address, string weather):base(title,description,date,time,typeOfEvent,address)
    {
        _weather = weather;
    }

    public string GetFullOutdoorDetails()
    {
        return $"{GetStandardDetails} Weather Forcast:{_weather}";
    }
}