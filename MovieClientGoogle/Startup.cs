using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoviePageSolution.Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieClient
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
            services.AddControllersWithViews();
            var connection = Configuration.GetConnectionString("MoviePageSolutionDb");
            services.AddDbContext<MoviePageDbContext>(opt => opt.UseSqlServer(connection));
            services.AddAuthentication()
                .AddGoogle(opts =>
                {
                    opts.ClientId = "955843831367-63da2vn20jveq70f96730a9mcghrttlu.apps.googleusercontent.com";
                    opts.ClientSecret = "Aa7RXJWIPkyn4V_r1zYSFK5v";
                    opts.SignInScheme = IdentityConstants.ExternalScheme;
                });
            services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<MoviePageDbContext>().AddDefaultTokenProviders();
            services.AddTransient<UserManager<IdentityUser>, UserManager<IdentityUser>>();
            services.AddTransient<SignInManager<IdentityUser>, SignInManager<IdentityUser>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
