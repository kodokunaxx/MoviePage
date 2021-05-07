using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MoviePageSolution.Data.EF
{
    public class MoviePageDbContextFactory : IDesignTimeDbContextFactory<MoviePageDbContext>
    {
        public MoviePageDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("MoviePageSolutionDb");

            var optionBuilder = new DbContextOptionsBuilder<MoviePageDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new MoviePageDbContext(optionBuilder.Options);
        }
    }
}
