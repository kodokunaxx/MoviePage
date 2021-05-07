using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePageSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Configurations
{
    public class MovieCastConfiguration : IEntityTypeConfiguration<MovieCast>
    {
        public void Configure(EntityTypeBuilder<MovieCast> builder)
        {
            builder.ToTable("MovieCast");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdCast).IsRequired();
            builder.Property(x => x.IdMovie).IsRequired();
            builder.Property(x => x.Character).IsRequired();
        }
    }
}
