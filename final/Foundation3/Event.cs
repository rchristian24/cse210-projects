public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _typeOfEvent;
    private Address _address;

    public Event(string title, string description, string date, string time,string typeOfEvent, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _typeOfEvent = typeOfEvent;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title:{_title} Description:{_description} Date:{_date} Time{_time} Address:{_address}";
    }
   
    public string GetShortDetails()
    {
        return $"Event:{_typeOfEvent} Title:{_title} Date:{_date}";
    }
    
}