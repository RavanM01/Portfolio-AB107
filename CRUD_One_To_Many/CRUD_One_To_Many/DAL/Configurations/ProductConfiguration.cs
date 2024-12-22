//using CRUD_One_To_Many.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace CRUD_One_To_Many.DAL.Configurations
//{
//    public class ProductConfiguration : IEntityTypeConfiguration<Product>
//    {
//        public void Configure(EntityTypeBuilder<Product> builder)
//        {
//            builder.Property(x=>x.Name).IsRequired()
//                .HasMaxLength(30);
//            builder.Property(x => x.Description).IsRequired();
//         //   builder.HasMany(x => x.Categories);
         
//        }
//    }
//}
