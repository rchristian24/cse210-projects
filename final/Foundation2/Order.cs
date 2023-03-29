public class Order
{
    private double _shippingCost;
    private Customer _customer;
    private double _subtotal = 0;
    List<Product> _productList = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void GetTotalCost()
    {
        foreach (Product p in _productList)
        {
            double price = p.PriceOfProduct();
            _subtotal += price;
        }
        GetShippingCost(_customer);
        double totalPrice = _subtotal + _shippingCost;
        Console.WriteLine($"Your total cost is: ${totalPrice}");
        Console.WriteLine();
    }

    public double GetShippingCost(Customer customer)
    {
        foreach (Product product in _productList)
        {
            if (customer.InUSA() == true)
            {
                _shippingCost = 5;
            }
            else
            {
                _shippingCost = 35;
            }
        }
        return _shippingCost;
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _productList)
        {
            Console.WriteLine($"Product ID:{product.GetID()} Product:{product.GetName()} [{product.GetQuantity()}]");
        }
    }

    public void GetShippingLabel(Customer customer, Address address)
    {
        string name = customer.GetCustomerName();

        Console.WriteLine($"{name}\r\n{address.DisplayAddress()}");
    }

    public void AddProduct(Product product)
    {
        product.GetName();
        product.GetID();
        product.GetPrice();
        product.GetQuantity();
        _productList.Add(product);
    }
}