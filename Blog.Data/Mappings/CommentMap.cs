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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(r => new { r.Id, r.ArticleId }); 

            builder.HasData(new Comment
            {
                Id = Guid.NewGuid(),
                Username = "abdullah avzi",
                Email = "abdullahavzi@gmail.com",
                Content = "Taktik çalışma yapıyorum bir şey deniyorum.",
                CreatedBy = "abdullah avzi",
                CreatedDate = DateTime.Now,
                isDeleted = false,
                ArticleId = Guid.Parse("fc661b5e-ced9-4d1b-89bd-a50bbe46c276"),
            });
        }
    }
}
