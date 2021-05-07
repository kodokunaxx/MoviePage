using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePageSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Configurations
{
    public class CastConfiguration : IEntityTypeConfiguration<Cast>
    {
        public void Configure(EntityTypeBuilder<Cast> builder)
        {
            builder.ToTable("Cast");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fullname).IsRequired();
            builder.Property(x => x.DoB).IsRequired();
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Nationality).IsRequired();
            builder.Property(x => x.Avatar).IsRequired();
        }
    }
}
