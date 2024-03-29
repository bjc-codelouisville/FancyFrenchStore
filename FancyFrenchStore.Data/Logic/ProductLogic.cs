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
                Console.WriteLine("Enter the SKU:");
                myProduct.SKU = Console.ReadLine();
                Console.WriteLine("Enter a UPC:");
                myProduct.UPC = Console.ReadLine();
                Console.WriteLine("Enter a Name:");
                myProduct.Name = Console.ReadLine();
                //Console.WriteLine("Enter a BrandID:");
                //myProduct.BrandID = Console.ReadLine();
                Console.WriteLine("Enter a Model:");
                myProduct.Model = Console.ReadLine();
                Console.WriteLine("Enter a Description:");
                myProduct.Description = Console.ReadLine();
                Console.WriteLine("Enter a Price:");
                myProduct.Price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a ProdPkgLength:");
                myProduct.ProdPkgLength = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a ProdPkgWidth:");
                myProduct.ProdPkgWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a ProdPkgHeight:");
                myProduct.ProdPkgHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a ProdPkgWeight:");
                myProduct.ProdPkgWeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a Discontinued (true or false:");
                myProduct.Discontinued = Convert.ToBoolean(Console.ReadLine());

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
        public void DisplayAllProductsBrands()
        {
            using (var context = new FancyFrenchStoreContext())
            {
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
    }
}
