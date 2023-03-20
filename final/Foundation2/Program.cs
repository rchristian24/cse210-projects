using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Address address1 = new Address("111 Fredrick St.", "Whosville", "CA", "USA");
        Customer customer1 = new Customer("George Wilson", address1);
        Product product1 = new Product("hairbrush", "28J89", 12, 1);
        Product product2 = new Product("Red Ribbon, large", "39G03", 3.85, 1);
        Product product3 = new Product("Large Inflatable Rubber Duck", "29H20", 27.18, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.GetShippingLabel(customer1, address1);
        order1.GetPackingLabel();
        order1.GetTotalCost();

        Address address2 = new Address("50 Rocklands Crescent", "WS13", "6DJ", "Great Britian");
        Customer customer2 = new Customer("Sofia Lorenzo", address2);
        Product product4 = new Product("Open-glass Aquarium", "03I39", 79.99, 1);
        Product product5 = new Product("Artificial Trees, small", "93J29", 9.99, 4);
        Product product6 = new Product("Pirate Ship", "83P38", 29.99, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.GetShippingLabel(customer2, address2);
        order2.GetPackingLabel();
        order2.GetTotalCost();
    }
}