public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time,string typeOfEvent, Address address, string speaker, int capacity):base(title,description,date,time,typeOfEvent,address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullLectureDetails()
        {
            return $"{GetStandardDetails()}\r\nSpeaker:{_speaker}\r\nCapacity:{_capacity}";
        }
    
}