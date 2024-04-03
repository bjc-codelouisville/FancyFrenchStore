using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FancyFrenchStore
{
    public class ProductBrandDTO
    {
        public Guid Id { get; set; }
        public string? SKU { get; set; }
        public string? UPC { get; set; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public decimal? Price { get; set; }
    }
}