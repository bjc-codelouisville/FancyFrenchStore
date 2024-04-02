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
    public class ProductService
    {

        private readonly FancyFrenchStoreContext _context;

        public ProductService(FancyFrenchStoreContext context)
        {
            _context = context;
        }

        public async Task<List<ProductBrandDTO>> GetProductsWithBrandsAsync()
        {
            var sqlQuery = @"
                SELECT
                    Products.Id,
                    Products.SKU,
                    Products.UPC,
                    Brands.Name AS Brand,
                    Products.Name,
                    Products.Price
                FROM
                    Products INNER JOIN
                    Brands ON Products.BrandID = Brands.Id";

            return await _context.Set<ProductBrandDTO>()
                                 .FromSqlRaw(sqlQuery)
                                 .ToListAsync();
        }
    }
}