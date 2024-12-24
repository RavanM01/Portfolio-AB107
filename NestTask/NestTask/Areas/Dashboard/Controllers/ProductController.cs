using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestTask.Areas.Dashboard.ViewModels.Product;
using NestTask.DAL;
using NestTask.Helpers.Extension;
using NestTask.Models;

namespace NestTask.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ProductController : Controller
    {
        AppDBContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDBContext context,IWebHostEnvironment env)
        {
            _context = context;
            this._env = env;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.Include(x => x.Category).Include(y => y.Tags).Include(c=>c.ProductImages).ToListAsync();
            return View(products);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductVm vm)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            if (!ModelState.IsValid)
            {
                return View();
            }
            Product product = new Product()
            {
                Name = vm.Name,
                Price = vm.Price,
                Description = vm.Description,
               CategoryId=vm.CategoryId,
                SKU = vm.SKU,
                ProductImages = new List<ProductImages>(),
                Tags=new List<Tag>()
            };

            if (!vm.MainPhoto.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("MainPhoto", "sekil daxil edin");
            }
            if (vm.MainPhoto.Length > 3000000)
            {
                ModelState.AddModelError("MainPhoto", "Max 2mb olmalidir");
            }
            product.ProductImages.Add(new()
            {
                Primary = true,
                ImgUrl = vm.MainPhoto.Upload(_env.WebRootPath, "Upload/Product")
            });
            foreach (var image in vm.Images)
            {
                if (image.Length > 2097152)
                {
                    ModelState.AddModelError("MainPhoto", "Max 2mb olmalidir");
                }
                if (!image.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("MainPhoto", "sekil daxil edin");
                }
                product.ProductImages.Add(new()
                {
                    Primary = false,
                    ImgUrl = image.Upload(_env.WebRootPath, "Upload/Product")
                });
            }
            foreach(var tag in vm.TagIds)
            {
                if (tag == null)
                {
                    return NotFound();
                }
                product.Tags.Add(new()
                {
                    Name=_context.Tags.FirstOrDefault(x=>x.Id==tag).Name
                    
                });
            }
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
