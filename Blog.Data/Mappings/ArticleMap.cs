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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.NET Core Deneme Makalesi 1",
                Content = "Asp.NET Core Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                ViewCount = 15,
                CategoryId = Guid.Parse("EA8E620C-9D28-4B4A-962E-104EF111ACE4"),
                ImageId = Guid.Parse("AB93EFD7-1144-4343-B7A9-ED3DE38A597D"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false,
                UserId = Guid.Parse("B31EB5CC-FF98-4979-B273-DB39087C6AE8"),
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi 1",
                Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi vel tellus consequat, semper ex a, dictum enim. Maecenas tortor velit, placerat et aliquam id, scelerisque vel risus. Etiam varius justo quis rhoncus condimentum. Ut dignissim lacus at orci mollis blandit. Maecenas tempor neque purus, a imperdiet justo elementum vel. Duis in bibendum ligula. Phasellus eu ornare mauris, ut vestibulum neque. Cras placerat massa et ultricies venenatis. Fusce vestibulum ipsum quis nunc dictum dignissim. Suspendisse non turpis id enim euismod pretium eget vitae ipsum. Donec tempor ullamcorper eros, convallis pretium risus. Vestibulum lobortis eu ligula sed lacinia. Praesent nec feugiat ligula, et egestas arcu. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
                ViewCount = 15,
                CategoryId = Guid.Parse("46D6D928-E1F3-4A16-9557-53E5941CE64A"),
                ImageId = Guid.Parse("0AD8EACA-F38A-447B-B21C-89AC3EA4C72A"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                isDeleted = false,
                UserId = Guid.Parse("A129D7CD-D69B-491C-BB10-0E199F1366E7"),
            });
        }
    }
}
