public class Address
{
    private string _street;
    private string _city;
    private string _state;

    public string GetAddress()
    {
        return $"{_street}\r\n{_city},{_state}";
    }
}