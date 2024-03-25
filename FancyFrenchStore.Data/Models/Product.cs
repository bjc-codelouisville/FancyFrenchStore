using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string SKU { get; set; }
        public string UPC { get; set; }
        public string Name { get; set; }
        public int BrandID { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal ProdPkgLength { get; set; }
        public decimal ProdPkgWidth { get; set; }
        public decimal ProdPkgHeight { get; set; }
        public decimal ProdPkgWeight { get; set; }
        public bool Discontinued { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }
    }
}
