using System;
using System.Collections.Generic;
using System.Text;
using Com.Efrata.Service.Auth.Lib.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Com.Ambassador.Service.Auth.Lib.Configs
{
    public class Permission2Config : IEntityTypeConfiguration<Permission2>
    {
        public void Configure(EntityTypeBuilder<Permission2> builder)
        {
            builder.Property(p => p.Menu).HasMaxLength(255);
            builder.Property(p => p.SubMenu).HasMaxLength(255);
            builder.Property(p => p.Code).HasMaxLength(255);
            builder.Property(p => p.UId).HasMaxLength(255);
            builder.Property(p => p.MenuName).HasMaxLength(255);
        }
    }
}
