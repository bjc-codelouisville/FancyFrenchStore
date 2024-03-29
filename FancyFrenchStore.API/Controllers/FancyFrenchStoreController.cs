using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FancyFrenchStore;

namespace FancyFrenchStore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FancyFrenchStoreController : Controller
    {
        private readonly FancyFrenchStoreContext _context;

        public FancyFrenchStoreController(FancyFrenchStoreContext context)
        {
            _context = context;
        }

        [HttpGet("Products/")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            return await _context.Products.ToListAsync();
        }
        [HttpGet("Products/{id}")]
        public async Task<ActionResult<Product>> GetProduct(Guid id)
        {
            if (_context.Products == null)
            {
                return NotFound();
            }
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }
        [HttpPost("Products/")]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            if (_context.Products == null)
            {
                return Problem("_context.Products is null.");
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = product.Id }, product);
        }
        [HttpGet("Brands/")]
        public async Task<ActionResult<IEnumerable<Brand>>> GetBrands()
        {
            if (_context.Brands == null)
            {
                return NotFound();
            }
            return await _context.Brands.ToListAsync();
        }
        [HttpGet("Brands/{id}")]
        public async Task<ActionResult<Brand>> GetBrand(Guid id)
        {
            if (_context.Brands == null)
            {
                return NotFound();
            }
            var brand = await _context.Brands.FindAsync(id);

            if (brand == null)
            {
                return NotFound();
            }

            return brand;
        }
        [HttpPost("Brands/")]
        public async Task<ActionResult<Brand>> PostBrand(Brand brand)
        {
            if (_context.Brands == null)
            {
                return Problem("_context.Brands is null.");
            }
            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrand", new { id = brand.Id }, brand);
        }
    }
}
