using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class HomeConfiguration : IEntityTypeConfiguration<Homework>
    {
         
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.Property(P => P.Id).IsRequired();
            builder.Property(p => p.DeadLine).IsRequired();
            builder.Property(p => p.StudentId).IsRequired();
            builder.Property(p => p.TeacherId).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(500);
                builder.HasOne(p => p.Student)
            .WithMany(p=>p.Homeworks)
            .HasForeignKey(p =>p.StudentId);
        }
    }
}