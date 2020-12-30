using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using ToDo.Entities.Concrete;

namespace ToDoList.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class BusinessMap : IEntityTypeConfiguration<Business>
    {
    
     public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).UseIdentityColumn();
            builder.Property(u => u.Name).IsRequired().HasMaxLength(200);
            builder.Property(u => u.Description).IsRequired().HasColumnType("ntext");

            builder.ToTable("Business");
        }
    }
}
