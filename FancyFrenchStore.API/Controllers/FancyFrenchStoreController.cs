using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FancyFrenchStore.Data.Models;
using FancyFrenchStore.Data;

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

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            //if (_context.Products == null)
            //{
            //    return NotFound();
            //}
            return _context.Products;//.ToListAsync();
        }

        //// GET: FancyFrenchStoreController
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: FancyFrenchStoreController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: FancyFrenchStoreController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: FancyFrenchStoreController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FancyFrenchStoreController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: FancyFrenchStoreController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: FancyFrenchStoreController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: FancyFrenchStoreController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
