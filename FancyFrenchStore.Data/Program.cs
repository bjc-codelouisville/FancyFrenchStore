using FancyFrenchStore;
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main()
    {
        // Check if the EF_MIGRATIONS environment variable is set
        if (Environment.GetEnvironmentVariable("EF_MIGRATIONS") == "true")
        {
            Console.WriteLine("Skipping application startup due to EF migrations.");
            return; // Exit the application early.
        }
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Products");
        Console.WriteLine("2. Brands");
        // Console.WriteLine("3. Customers");
        Console.WriteLine("Type 'exit' to quit");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string userInput = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        while (userInput.ToLower() != "exit")
        {
            if (userInput == "1")
            {
                ProductLogic productLogic = new ProductLogic();
                Console.Clear();
                Console.WriteLine("Products Menu");
                Console.WriteLine("1. Product List");
                Console.WriteLine("2. Add New Product");
                // Console.WriteLine("3. Update Existing Product");
                // Console.WriteLine("4. Product List with Brands");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
                while (userInput.ToLower() != "exit")
                {
                    if (userInput == "1")
                    {
                        productLogic.DisplayAllProducts();
                    }
                    if (userInput == "2")
                    {
                        productLogic.AddProduct();
                    }
                    Console.Clear();
                    Console.WriteLine("Products Menu");
                    Console.WriteLine("1. Product List");
                    Console.WriteLine("2. Add New Product");
                    // Console.WriteLine("3. Update Existing Product");
                    // Console.WriteLine("4. Product List with Brands");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }
            }
            if (userInput == "2")
            {
                BrandLogic brandLogic = new BrandLogic();
                Console.Clear();
                Console.WriteLine("Brands Menu");
                Console.WriteLine("1. Brand List");
                Console.WriteLine("2. Add New Brand");
                // Console.WriteLine("3. Update Existing Brand");
                // Console.WriteLine("4. Brand Report");
                Console.WriteLine("Type 'exit' to quit");
                userInput = Console.ReadLine();
                while (userInput.ToLower() != "exit")
                {
                    if (userInput == "1")
                    {
                        brandLogic.DisplayAllBrands();
                    }
                    if (userInput == "2")
                    {
                        brandLogic.AddBrand();
                    }
                    Console.Clear();
                    Console.WriteLine("Brands Menu");
                    Console.WriteLine("1. Brand List");
                    Console.WriteLine("2. Add New Brand");
                    // Console.WriteLine("3. Update Existing Brand");
                    // Console.WriteLine("4. Brand Report");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }
            }
            //if (userInput == "3")
            //{
            //    Console.Clear();
            //    Console.WriteLine("Customers Menu");
            //    Console.WriteLine("1. Customer List");
            //    Console.WriteLine("2. Add New Customer");
            //    Console.WriteLine("3. Update Existing Customer");
            //    Console.WriteLine("4. Customer Report");
            //    Console.WriteLine("Type 'exit' to quit");
            //}
            //if (userInput == "4")
            //{
            //    Console.Clear();
            //    Console.WriteLine("Payments Menu");
            //    Console.WriteLine("1. Payment List");
            //    Console.WriteLine("2. Add New Payment");
            //    Console.WriteLine("3. Update Existing Payment");
            //    Console.WriteLine("4. Payment Report");
            //    Console.WriteLine("Type 'exit' to quit");
            //}
            //if (userInput == "5")
            //{
            //    Console.Clear();
            //    Console.WriteLine("Brands Menu");
            //    Console.WriteLine("1. Brand List");
            //    Console.WriteLine("2. Add New Brand");
            //    Console.WriteLine("3. Update Existing Brand");
            //    Console.WriteLine("4. Brand Report");
            //    Console.WriteLine("Type 'exit' to quit");
            //}

            Console.Clear();
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Products");
            Console.WriteLine("2. Brands");
            // Console.WriteLine("3. Customers");
            Console.WriteLine("Type 'exit' to quit");

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            userInput = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        }
    }
}