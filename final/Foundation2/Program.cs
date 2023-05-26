using System;

class Program
{
    static void Main(string[] args)
    {
        
        Product product1 = new Product("Apples", "GH57H", 1.5, 70);
        Product product2 = new Product("Lettuce", "SOH98", 2.33, 90);
        Product product3 = new Product("Mangoes", "GP483", 10.2, 10);
        Product product4 = new Product("watermelons", "26FH7", 5.8, 2000);
        Product product5 = new Product("Yogurt", "8KE36", 4.2, 40);
        Product product6 = new Product("Milk", "KQW4Y", 2.3, 50);
        


        Address address1 = new Address("123 Main St", "New York City", "NY", "USA");
        string newAddress1 = address1.GetAddress();
        string newCountry1 = address1.GetCountry();
        Customer customer1 = new Customer("Fred the math teacher", $"{newAddress1}", $"{newCountry1}");

        Address address2 = new Address("321 side St", "San Diago", "CA", "USA");
        string newAddress2 = address2.GetAddress();
        string newCountry2 = address2.GetCountry();
        Customer customer2 = new Customer("Bob the math teacher", $"{newAddress2}", $"{newCountry2}");

        Order order1 = new Order();
        order1._customer = customer1.DisplayCustomerInfo();
        order1._shippingCost = customer1.GetShippingCost();
        order1._products.Add(product1);
        order1._products.Add(product2);

        Order order2 = new Order();
        order2._customer = customer2.DisplayCustomerInfo();
        order2._shippingCost = customer2.GetShippingCost();
        order2._products.Add(product3);
        order2._products.Add(product4);
        order2._products.Add(product5);
        order2._products.Add(product6);

        order1.DisplayTotalPrice();
        Console.WriteLine();
        order1.DisplayShippingLabel();
        Console.WriteLine();
        order1.DisplayPackingLabel();
        Console.WriteLine();

        order2.DisplayTotalPrice();
        Console.WriteLine();
        order2.DisplayShippingLabel();
        Console.WriteLine();
        order2.DisplayPackingLabel();
        Console.WriteLine();

    }
}