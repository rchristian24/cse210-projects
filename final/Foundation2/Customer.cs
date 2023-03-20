public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
 
    public void SetCustomerName(string customerName)
    {
        _customerName = customerName;
    }

    public bool InUSA()
    {
        if (_address.IsUSA() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}