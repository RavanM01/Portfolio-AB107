using AutoMapper;
using CRUD_One_To_Many.DAL;
using CRUD_One_To_Many.DTOs.Category;
using CRUD_One_To_Many.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_One_To_Many.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        AppDBContext _db;
        IMapper _mapper;

        public CategoryController(AppDBContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult Create(CreateCategoryDto category)
        {
            var newCategory = _mapper.Map<Category>(category);
            _db.Categories.Add(newCategory);
            _db.SaveChanges();
            return StatusCode(StatusCodes.Status201Created, newCategory);
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_db.Categories.ToList());
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
            return category==null?NotFound():Ok(category);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var category = _db.Categories.FirstOrDefault(c => c.Id == id);
               if (category==null) return NotFound();
               _db.Categories.Remove(category);
            _db.SaveChanges();
            return StatusCode(StatusCodes.Status204NoContent);
        }
        [HttpPut]
        public async Task<IActionResult> Update(UpdateCategoryDto categorydto)
        {
            var category = _db.Categories.AsNoTracking().FirstOrDefault(c => c.Id == categorydto.Id);
            if (category==null) return NotFound();
            category=_mapper.Map<Category>(categorydto);
            _db.Categories.Update(category);
            await _db.SaveChangesAsync();
            return Ok(category);
        }

    }
}
