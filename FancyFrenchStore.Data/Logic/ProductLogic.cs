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
                Console.WriteLine("Enter a Price (as a decimal):");
                myProduct.Price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a ProdPkgLength (as a decimal):");
                myProduct.ProdPkgLength = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a ProdPkgWidth (as a decimal):");
                myProduct.ProdPkgWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a ProdPkgHeight (as a decimal):");
                myProduct.ProdPkgHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a ProdPkgWeight (as a decimal):");
                myProduct.ProdPkgWeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter a Discontinued (true or false:)");
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
                foreach (var product in context.Products)
                {
                    Console.WriteLine("<-------------------- Begin Product -------------------->");
                    Console.WriteLine("Product ID: " + product.Id);
                    Console.WriteLine("Product Name: " + product.Name);
                    Console.WriteLine("Product Price: " + product.Price);
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
                }
            }
        }
        public void ProductServicePrint()
        {
            var context = new FancyFrenchStoreContext();
            var productService = new ProductService(context);

            var productsWithBrands = productService.GetProductsWithBrands();

            foreach (var product in productsWithBrands)
            {
                Console.WriteLine($"ID: {product.Id}, SKU: {product.SKU}, UPC: {product.UPC}, Brand: {product.Brand}, Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
