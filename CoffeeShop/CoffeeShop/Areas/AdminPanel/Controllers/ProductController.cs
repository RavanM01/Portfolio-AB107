using CoffeeShop.DAL;
using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShop.Areas.AdminPanel.Controllers
{
        [Area("AdminPanel")]
    public class ProductController : Controller
    {
        AppDBContext dbContext;

        public ProductController(AppDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var products = await dbContext.products.ToListAsync();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            dbContext.products.Add(product);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var product = dbContext.products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            dbContext.products.Remove(product);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Update(int? id)
        {
            if (id == null) return BadRequest();
            var product = dbContext.products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (product.Id == null) return BadRequest();
            var oldProduct = dbContext.products.FirstOrDefault(x => x.Id == product.Id);
            if (oldProduct == null) return NotFound();
            oldProduct.Name = product.Name;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
