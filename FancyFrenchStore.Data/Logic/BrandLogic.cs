using FancyFrenchStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore
{ 
    internal class BrandLogic
    {
        public void AddBrand()
        {
            using (var context = new FancyFrenchStoreContext())
            {
                var myBrand = new Brand();
                Console.WriteLine("Enter a Name:");
                myBrand.Name = Console.ReadLine();
                Console.WriteLine("Enter a Description:");
                myBrand.Description = Console.ReadLine();
                Console.WriteLine("Enter a Website:");
                myBrand.Website = Console.ReadLine();
                Console.WriteLine("Enter the LogoURL:");
                myBrand.LogoURL = Console.ReadLine();

                context.Brands.Add(myBrand);
                context.SaveChanges();
            }
        }
        // Display Brand details
        public void DisplayAllBrands()
        {
            using (var context = new FancyFrenchStoreContext())
            {

                foreach (var Brand in context.Brands)
                {
                    Console.WriteLine("<-------------------------------------------------->");
                    Console.WriteLine("Brand Name: " + Brand.Name);
                    Console.WriteLine("Brand Description: " + Brand.Description);
                    Console.WriteLine("Brand Website: " + Brand.Website);
                    Console.WriteLine("Brand LogoURL: " + Brand.LogoURL);
                    Console.WriteLine("<-------------------------------------------------->");
                }
            }
        }
    }
}
