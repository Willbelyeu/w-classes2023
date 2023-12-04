using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        // 2 orders, send them through the programs. Start from order, then work backward to see what you need.
        // 2 or three products in each order.
        List<Product> customer1OrderList=new List<Product>();
        string productName="milk";
        string productID="2k45j3h";
        double productPrice=5.12;
        int productCount=2;
        Product product1Customer1=new Product(productName, productID, productPrice, productCount);
        customer1OrderList.Add(product1Customer1);
        productName="eggs";
        productID="d8f7d7v";
        productPrice=2.92;
        productCount=1;
        Product product2Customer1=new Product(productName, productID, productPrice, productCount);
        customer1OrderList.Add(product2Customer1);
        Customer customer1=new Customer("Alexander Bilington", "412 River Bolivard", "Houstan", "TX", "America");
        Order order1=new Order(customer1, customer1OrderList);
        string packingLabel=order1.PackingLabel();
        Console.WriteLine("");
        Console.WriteLine(packingLabel);
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"${order1.FinalPrice()}");


        List<Product> customer2OrderList=new List<Product>();
        productName="bread";
        productID="cof4i2o";
        productPrice=1.42;
        productCount=1;
        Product product1Customer2=new Product(productName, productID, productPrice, productCount);
        customer2OrderList.Add(product1Customer2);
        productName="eggs";
        productID="d8f7d7v";
        productPrice=2.92;
        productCount=6;
        Product product2Customer2=new Product(productName, productID, productPrice, productCount);
        customer2OrderList.Add(product2Customer2);
        Customer customer2=new Customer("Rapheal Smith", "324 River street", "London", "LD", "Great Briton");
        Order order2=new Order(customer2, customer2OrderList);
        packingLabel=order2.PackingLabel();
        Console.WriteLine("");
        Console.WriteLine(packingLabel);
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"${order2.FinalPrice()}");
    }
}