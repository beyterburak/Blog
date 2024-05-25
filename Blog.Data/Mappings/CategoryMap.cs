using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("EA8E620C-9D28-4B4A-962E-104EF111ACE4"),
                Name = "ASP.NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false,
            },
            new Category
            {
                Id = Guid.Parse("46D6D928-E1F3-4A16-9557-53E5941CE64A"),
                Name = "Visual Studio 2022",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false,
            });
        }
    }
}
