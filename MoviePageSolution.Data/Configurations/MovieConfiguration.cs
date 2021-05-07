using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePageSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movie");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Overview).IsRequired();
            builder.Property(x => x.Release_date).IsRequired();
            builder.Property(x => x.Director).IsRequired();
            builder.Property(x => x.Backdrop).IsRequired();
            builder.Property(x => x.Poster).IsRequired();
            builder.Property(x => x.Time).IsRequired();
            builder.Property(x => x.Nation).IsRequired();
            builder.Property(x => x.Episodes).IsRequired();
            builder.Property(x => x.Language).IsRequired();
            builder.Property(x => x.Youtube).IsRequired();

        }
    }
}
