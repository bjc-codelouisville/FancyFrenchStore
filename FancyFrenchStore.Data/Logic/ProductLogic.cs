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
        //public struct Product(string sku, string upc, string name, int brandId, string model, string description, decimal price, decimal prodPkgLength, decimal prodPkgWidth, decimal prodPkgHeight, decimal prodPkgWeight, bool discontinued)
        //{
        //    Id = Guid.NewGuid();
        //    SKU = sku;
        //    UPC = upc;
        //    Name = name;
        //    BrandID = brandId;
        //    Model = model;
        //    Description = description;
        //    Price = price;
        //    ProdPkgLength = prodPkgLength;
        //    ProdPkgWidth = prodPkgWidth;
        //    ProdPkgHeight = prodPkgHeight;
        //    ProdPkgWeight = prodPkgWeight;
        //    Discontinued = discontinued;
        //    CreatedDate = DateTime.Now; // Set the initial update timestamp
        //    UpdatedDate = DateTime.Now; // Set the initial update timestamp
        //}
        public void AddProduct()
        {
            using (var context = new FancyFrenchStoreContext())
            {
                var myProduct = new Product();
                //myProduct.SKU = Console.ReadLine();
                //myProduct.UPC = Console.ReadLine();
                //myProduct.Name = Console.ReadLine();
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
        //// Display product details
        //public void DisplayProduct()
        //{
        //    using (var context = new FancyFrenchStoreContext())
        //    {
        //        Console.WriteLine($"ID: {Id}, SKU: {SKU}, UPC: {UPC}, Name: {Name}, Brand ID: {BrandID}, Model: {Model}, Description: {Description}, Price: {Price:C}, Packaging LxWxH: {ProdPkgLength}x{ProdPkgWidth}x{ProdPkgHeight}, Weight: {ProdPkgWeight}kg, Discontinued: {Discontinued}, Created: {CreatedDate}, Updated: {UpdatedDate}");
        //    }

        //}
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
    }
}
