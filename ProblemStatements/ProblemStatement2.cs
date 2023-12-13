using System;
using System.Collections.Generic;

class Product
{
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string name, double price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
}

class Inventory
{
    private List<Product> _products;

    public Inventory()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public List<Product> GetProducts()
    {
        return _products;
    }
}

class InventoryManager
{
    public static void Main(string[] arguments)
    {
        Inventory inventory = new Inventory();

        while (true)
        {
            Console.WriteLine("\nInv Mgmt System");
            Console.WriteLine("1. Add Prod");
            Console.WriteLine("2. Display Inv");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            int choiceOfOperation = Convert.ToInt32(Console.ReadLine());

            switch (choiceOfOperation)
            {
                case 1:
                    Console.Write("Enter prod name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter prod price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter prod qty: ");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Product product = new Product(name, price, quantity);
                    inventory.AddProduct(product);

                    Console.WriteLine("Prod added successfully!");
                    break;

                case 2:
                    Console.WriteLine("\nCurrent Inv:");
                    List<Product> products = inventory.GetProducts();
                    foreach (Product currentProduct in products)
                    {
                        Console.WriteLine("Name: " + currentProduct.GetName() + ", Price: $" + currentProduct.GetPrice() + ", Quantity: " + currentProduct.GetQuantity());
                    }
                    break;

                case 3:
                    Console.WriteLine("Exiting program. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}