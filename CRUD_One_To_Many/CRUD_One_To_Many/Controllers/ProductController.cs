using AutoMapper;
using CRUD_One_To_Many.DAL;
using CRUD_One_To_Many.DTOs.Category;
using CRUD_One_To_Many.DTOs.Product;
using CRUD_One_To_Many.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_One_To_Many.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        AppDBContext _db;
        IMapper _mapper;

        public ProductController(AppDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Create(CreateProductDto product)
        {
            var newProduct = _mapper.Map<Product>(product);
            _db.Products.Add(newProduct);
            _db.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, newProduct);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.Products.ToList());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var product = _db.Products.FirstOrDefault(c => c.Id == id);
            return product == null ? NotFound() : Ok(product);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = _db.Products.FirstOrDefault(c => c.Id == id);
            if (product == null) return NotFound();
            _db.Products.Remove(product);
            _db.SaveChanges();
            return StatusCode(StatusCodes.Status204NoContent);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductDto productdto)
        {
            var product = _db.Products.AsNoTracking().FirstOrDefault(c => c.Id == productdto.Id);
            if (product == null) return NotFound();
            product = _mapper.Map<Product>(productdto);
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
            return Ok(product);
        }

    }
}
