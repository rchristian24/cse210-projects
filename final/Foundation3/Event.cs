public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetStandardDetails()
    {
        return $"Title:'{_title}' Description: {_description}\r\nDate: {_date} Time: {_time}\r\nAddress:{_address.GetAddress()}";
    }

    public string GetShortDetails()
    {
        return $"Event:{GetType()}\r\nTitle:'{GetTitle()}'\r\nDate:{GetDate()}";
    }
}