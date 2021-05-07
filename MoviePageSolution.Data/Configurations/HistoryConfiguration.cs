using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviePageSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.Configurations
{
    class HistoryConfiguration : IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            builder.ToTable("History");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IdUser).IsRequired();
            builder.Property(x => x.Keyword).IsRequired();
        }
    }
}
