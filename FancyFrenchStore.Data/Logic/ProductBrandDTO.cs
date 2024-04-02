//using Microsoft.EntityFrameworkCore;

//namespace FancyFrenchStore
//{

//    public class ProductBrandDTO
//    {

//        public List<ProductBrandDTO> GetProductsWithBrands()
//        {
//            using (var context = new FancyFrenchStoreContext())
//            {
//                var sqlQuery = @"
//                SELECT
//                    Products.Id,
//                    Products.SKU,
//                    Products.UPC,
//                    Brands.Name AS Brand,
//                    Products.Name,
//                    Products.Price
//                FROM
//                    Products INNER JOIN
//                    Brands ON Products.BrandID = Brands.Id";
//                return Set<ProductBrandDTO>().FromSqlRaw(sqlQuery).ToList();
//            }
//        }

//    }
//}
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FancyFrenchStore
{
    public class ProductBrandDTO
    {

        private readonly FancyFrenchStoreContext _context;

        public ProductBrandDTO(FancyFrenchStoreContext context)
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