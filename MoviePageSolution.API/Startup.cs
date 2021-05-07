using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MoviePageSolution.Data.EF;
using MoviePageSolution.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviePageSolution.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("MoviePageSolutionDb");
            services.AddDbContext<MoviePageDbContext>(opt => opt.UseSqlServer(connection));
            services.AddControllers();
            services.AddTransient<UserRepository, UserRepository>();
            services.AddTransient<CastRepository, CastRepository>();
            services.AddTransient<MovieRepository, MovieRepository>();
            services.AddTransient<HistoryRepository, HistoryRepository>();
            services.AddTransient<CategoryRepository, CategoryRepository>();
            services.AddTransient<MovieCastRepository, MovieCastRepository>();
            services.AddTransient<MovieCategoryRepository, MovieCategoryRepository>();

            services.AddCors(option => option.AddPolicy("MyPolicy", builder => {
                builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();

            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("MyPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
