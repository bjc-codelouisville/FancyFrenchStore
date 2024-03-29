using FancyFrenchStore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class ProductBrandDTO
{
    public int Id { get; set; }
    public string? SKU { get; set; }
    public string? UPC { get; set; }
    public string? Name { get; set; }
    public string? BrandName { get; set; }
    public decimal? Price { get; set; }
}

public class ProductService
{
    private readonly FancyFrenchStoreContext _context;

    public ProductService(FancyFrenchStoreContext context)
    {
        _context = context;
    }

    public List<ProductBrandDTO> GetProductsWithBrand()
    {
        var query = @"
            SELECT
                Products.Id,
                Products.SKU,
                Products.UPC,
                Products.Name,
                Brands.Name AS BrandName,
                Products.Price
            FROM
                Products INNER JOIN
                Brands ON Products.BrandID = Brands.Id";

        var result = _context.Set<ProductBrandDTO>()
                             .FromSqlRaw(query)
                             .ToList();

        return result;
    }
}