using System;
using System.Linq;
using FancyFrenchStore.Data;
using FancyFrenchStore.Domain;

Console.WriteLine("Main Menu");
Console.WriteLine("1. Products");
Console.WriteLine("2. Orders");
Console.WriteLine("3. Customers");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit")
{
    if (userInput == "1")
    {
        Console.Clear();
        Console.WriteLine("Products Menu");
        Console.WriteLine("1. Product List");
        Console.WriteLine("2. Add New Product");
        Console.WriteLine("3. Update Existing Product");
        Console.WriteLine("4. Inventory Report");
        Console.WriteLine("Type 'exit' to quit");
    }
    if (userInput == "2")
    {
        Console.Clear();
        Console.WriteLine("Orders Menu");
        Console.WriteLine("1. Order List");
        Console.WriteLine("2. Add New Order");
        Console.WriteLine("3. Update Existing Order");
        Console.WriteLine("4. Order Report");
        Console.WriteLine("Type 'exit' to quit");
    }
    if (userInput == "3")
    {
        Console.Clear();
        Console.WriteLine("Customers Menu");
        Console.WriteLine("1. Customer List");
        Console.WriteLine("2. Add New Customer");
        Console.WriteLine("3. Update Existing Customer");
        Console.WriteLine("4. Customer Report");
        Console.WriteLine("Type 'exit' to quit");
    }
    if (userInput == "4")
    {
        Console.Clear();
        Console.WriteLine("Payments Menu");
        Console.WriteLine("1. Payment List");
        Console.WriteLine("2. Add New Payment");
        Console.WriteLine("3. Update Existing Payment");
        Console.WriteLine("4. Payment Report");
        Console.WriteLine("Type 'exit' to quit");
    }
    if (userInput == "5")
    {
        Console.Clear();
        Console.WriteLine("Brands Menu");
        Console.WriteLine("1. Brand List");
        Console.WriteLine("2. Add New Brand");
        Console.WriteLine("3. Update Existing Brand");
        Console.WriteLine("4. Brand Report");
        Console.WriteLine("Type 'exit' to quit");
    }

    Console.WriteLine("Main Menu");
    Console.WriteLine("1. Products");
    Console.WriteLine("2. Orders");
    Console.WriteLine("3. Customers");
    Console.WriteLine("Type 'exit' to quit");

    string userInput = Console.ReadLine();

}