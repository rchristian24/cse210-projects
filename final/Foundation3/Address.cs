public class Address
{
    private string _street;
    private string _city;
    private string _state;

    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
    }
    public string GetAddress()
    {
        return $"{_street}\r\n{_city},{_state}";
    }
}