using AutoMapper;
using CRUD_One_To_Many.DTOs.Category;
using CRUD_One_To_Many.DTOs.Product;
using CRUD_One_To_Many.Models;

namespace CRUD_One_To_Many.Helpers.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();

        }
    }
}
