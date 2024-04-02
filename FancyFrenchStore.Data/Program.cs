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
                Console.WriteLine("----------");
                Console.WriteLine("Products Menu");
                Console.WriteLine("1. Product List");
                Console.WriteLine("2. Add New Product");
                // Console.WriteLine("3. Update Existing Product");
                Console.WriteLine("4. Product List with Brands");
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
                    //if (userInput == "3")
                    //{
                    //    productLogic.DisplayAllProducts();
                    //}
                    if (userInput == "4")
                    {
                        //using (var context = new FancyFrenchStoreContext())
                        //{
                        //    var productsWithBrands = ProductService.GetProductsWithBrandsAsync();
                        //    Console.WriteLine("ID\tSKU\t\tUPC\t\tBrand\t\tName\t\t\tPrice");
                        //    Console.WriteLine("-------------------------------------------------------------------------");
                        //    foreach (var product in productsWithBrands)
                        //    {
                        //        //Console.WriteLine($"{product.Id,-5} {product.SKU,-10} {product.UPC,-15} {product.Brand,-20} {product.Name,-25} ${product.Price,10:N2}");
                        //        Console.WriteLine($"{product.Id}\t{product.SKU}\t{product.UPC}\t{product.Brand}\t{product.Name}\t${product.Price}");
                        //    }
                        //}
                        {
                            static async Task Main(string[] args)
                            {
                                // Assuming you have setup DI and configuration appropriately
                                var context = new FancyFrenchStoreContext(); // Initialize this with the correct options
                                var productService = new ProductService(context);

                                var productsWithBrands = await productService.GetProductsWithBrandsAsync();

                                foreach (var product in productsWithBrands)
                                {
                                    Console.WriteLine($"ID: {product.Id}, SKU: {product.SKU}, UPC: {product.UPC}, Brand: {product.Brand}, Name: {product.Name}, Price: {product.Price}");
                                }
                            }
                        }
                    }
                    Console.WriteLine("----------");
                    Console.WriteLine("Products Menu");
                    Console.WriteLine("1. Product List");
                    Console.WriteLine("2. Add New Product");
                    // Console.WriteLine("3. Update Existing Product");
                    Console.WriteLine("4. Product List with Brands");
                    Console.WriteLine("Type 'exit' to quit");
                    userInput = Console.ReadLine();
                }
            }
            if (userInput == "2")
            {
                BrandLogic brandLogic = new BrandLogic();
                Console.WriteLine("----------");
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
                    Console.WriteLine("----------");
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
            //    Console.WriteLine("----------");
            //    Console.WriteLine("Customers Menu");
            //    Console.WriteLine("1. Customer List");
            //    Console.WriteLine("2. Add New Customer");
            //    Console.WriteLine("3. Update Existing Customer");
            //    Console.WriteLine("4. Customer Report");
            //    Console.WriteLine("Type 'exit' to quit");
            //}
            //if (userInput == "4")
            //{
            //    Console.WriteLine("----------");
            //    Console.WriteLine("Payments Menu");
            //    Console.WriteLine("1. Payment List");
            //    Console.WriteLine("2. Add New Payment");
            //    Console.WriteLine("3. Update Existing Payment");
            //    Console.WriteLine("4. Payment Report");
            //    Console.WriteLine("Type 'exit' to quit");
            //}
            //if (userInput == "5")
            //{
            //    Console.WriteLine("----------");
            //    Console.WriteLine("Brands Menu");
            //    Console.WriteLine("1. Brand List");
            //    Console.WriteLine("2. Add New Brand");
            //    Console.WriteLine("3. Update Existing Brand");
            //    Console.WriteLine("4. Brand Report");
            //    Console.WriteLine("Type 'exit' to quit");
            //}

            Console.WriteLine("----------");
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