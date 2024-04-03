using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyFrenchStore
{
    public class ProductService
    {

        private readonly FancyFrenchStoreContext _context;

        public ProductService(FancyFrenchStoreContext context)
        {
            _context = context;
        }

        public List<ProductBrandDTO> GetProductsWithBrands()
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

            return _context.Set<ProductBrandDTO>()
                                 .FromSqlRaw(sqlQuery)
                                 .ToList();
        }
    }
}
