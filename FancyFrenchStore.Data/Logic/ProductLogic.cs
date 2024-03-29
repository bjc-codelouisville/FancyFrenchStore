using FancyFrenchStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore
{
    public class ProductLogic
    {
        public void AddProduct()
        {
            using (var context = new FancyFrenchStoreContext())
            {
                var myProduct = new Product();
                //myProduct.SKU = Console.ReadLine();
                //myProduct.UPC = Console.ReadLine();
                Console.WriteLine("Enter a Name:");
                myProduct.Name = Console.ReadLine();
                //myProduct.BrandID = Console.ReadLine();
                //myProduct.Model = Console.ReadLine();
                //myProduct.Description = Console.ReadLine();
                //myProduct.Price = Console.ReadLine();
                //myProduct.ProdPkgLength = Console.ReadLine();
                //myProduct.ProdPkgWidth = Console.ReadLine();
                //myProduct.ProdPkgHeight = Console.ReadLine();
                //myProduct.ProdPkgWeight = Console.ReadLine();
                //myProduct.Discontinued = Console.ReadLine();

                context.Products.Add(myProduct);
                context.SaveChanges();
            }
        }
        // Display product details
        public void DisplayAllProducts()
        {
            using (var context = new FancyFrenchStoreContext())
            {
                //Console.WriteLine($"ID: {Id}, SKU: {SKU}, UPC: {UPC}, Name: {Name}, Brand ID: {BrandID}, Model: {Model}, Description: {Description}, Price: {Price:C}, Packaging LxWxH: {ProdPkgLength}x{ProdPkgWidth}x{ProdPkgHeight}, Weight: {ProdPkgWeight}kg, Discontinued: {Discontinued}, Created: {CreatedDate}, Updated: {UpdatedDate}");
                foreach (var product in context.Products)
                {
                    Console.WriteLine("<-------------------- Begin Product -------------------->");
                    Console.WriteLine("Product ID: " + product.Id);
                    Console.WriteLine("Product Name: " + product.Name);
                    Console.WriteLine("Product Price: " + product.Price);
                    Console.WriteLine("<-------------------- End Product -------------------->");
                }
            }
        }
        //// Method to update certain product details
        //public void UpdateProduct(string name, string model, string description, decimal price, bool discontinued)
        //{
        //    using (var context = new FancyFrenchStoreContext())
        //    {
        //        Name = name;
        //        Model = model;
        //        Description = description;
        //        Price = price;
        //        Discontinued = discontinued;
        //        UpdatedDate = DateTime.Now;
        //    }
        //}
        // Method to 
    }
}
