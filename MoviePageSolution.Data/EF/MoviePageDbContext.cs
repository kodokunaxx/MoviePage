using Microsoft.EntityFrameworkCore;
using MoviePageSolution.Data.Configurations;
using MoviePageSolution.Data.Entities;
using MoviePageSolution.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviePageSolution.Data.EF
{
    public class MoviePageDbContext : DbContext
    {
        public MoviePageDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure using Fluent API
            modelBuilder.ApplyConfiguration(new CastConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new HistoryConfiguration());
            modelBuilder.ApplyConfiguration(new MovieCastConfiguration());
            modelBuilder.ApplyConfiguration(new MovieCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            //Data seeding
            modelBuilder.Seed();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
    }
}
