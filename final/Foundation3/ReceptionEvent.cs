public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string description, string date, string time, string typeOfEvent, Address address, string email):base(title,description,date,time,typeOfEvent,address)
    {
        _email = email;
    }

    public string GetFullReceptionDetails()
    {
        return $"{GetStandardDetails()} Email:{_email}";
    }
}