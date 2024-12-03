using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Riode.Areas.Dashboard.ViewModels.Product;
using Riode.DAL;
using Riode.Helpers.Extensions;
using Riode.Models;

namespace Riode.Areas.Dashboard.Controllers
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
            var products= await _context.products.Include(v=>v.Brand).Include(y=>y.ProductImages).ToListAsync();
            return View(products);
        }
        public IActionResult Create()
        {
            ViewBag.Brands=_context.brands.ToList();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductVm vm)
        {
            ViewBag.Brands = _context.brands.ToList();
            if (!ModelState.IsValid)
            {
                return View();
            }
            Product product= new Product()
            {
                Name = vm.Name,
                Price = vm.Price,
                Description=vm.Description,
                Quantity = vm.Quantity,
                SKU = vm.SKU,
                BrandId = vm.BrandId,
                ProductImages=new List<ProductImages>()
            };

            if (!vm.MainPhoto.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("MainPhoto", "sekil daxil edin");
            }
            if (vm.MainPhoto.Length > 3000000 )   
            {
                ModelState.AddModelError("MainPhoto", "Max 2mb olmalidir");
            }
            product.ProductImages.Add(new()
            {
                Primary=true,
                ImgUrl= vm.MainPhoto.Upload(_env.WebRootPath,"Upload/Product")
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
            await _context.products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var product = _context.products.FirstOrDefault(x => x.Id == id);
            if (product == null) return NotFound();
            _context.products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
