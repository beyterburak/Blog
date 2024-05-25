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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("B31EB5CC-FF98-4979-B273-DB39087C6AE8"),
                RoleId = Guid.Parse("D9CA0B7A-A37E-4D2E-B016-86F3CEB56397")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("A129D7CD-D69B-491C-BB10-0E199F1366E7"),
                RoleId = Guid.Parse("6AFCD0C7-7FB7-4B34-A14A-E2A55141D71A"),
            });
        }
    }
}
