using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using MedicalManager.Models;

namespace MedicalManager
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            /* services.AddDbContextPool<MedicalManagerDBContext>(
                options => options.UseSqlServer(Configuration.GetConnectionString("MedicalManagerDBConnection")));
             */
            // var server = Configuration["DBServer"] ?? "localhost";
            var server = Configuration["DBServer"] ?? "ms-sql-server";
            var port = Configuration["DBPort"] ?? "1443";
            var user = Configuration["DBUser"] ?? "SA";
            var password = Configuration["DBPassword"] ?? "Pa55w0rd2019";
            var database = Configuration["Database"] ?? "MedicalManagerDB";

            //Database=MedicalManagerDB; Trusted_Connection=true; MultipleActiveResultSets=true
            // "MedicalManagerDBConnection": "Server=(localdb)\\MSSQLLocalDB; Database=MedicalManagerDB; Trusted_Connection=true; MultipleActiveResultSets=true"

            services.AddDbContext<MedicalManagerDBContext>(options => 
                options.UseSqlServer(
                    //$"Server={server},{port};Initial Catalog={database};User ID={user};Password={password}"
                    $"Server={server},{port};Database={database};User ID={user};Password={password}; Trusted_Connection=true"
                )
            );
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IMedicationRepository, MedicationRepository > ();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MedicalManagerDBContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Create}/{id?}");
            });

            DbMigrationHandler.DBPreSet(app);
            //context.Database.Migrate();
        }
    }
}
