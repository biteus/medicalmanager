using System.Security.AccessControl;
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
using System.Data.SqlClient;
using Oracle.ManagedDataAccess;
using Oracle;
using Oracle.ManagedDataAccess.Client;
using Oracle.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

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

            /*ORACLE_PWD=mm2020
            ORACLE_USER=mmuser
            ORACLE_HOSTNAME=mm20db 
            ORACLE_SERVICE=mm20db */
            
//            ORCLCDB =   (DESCRIPTION =     (ADDRESS = (PROTOCOL = TCP)(HOST = 0.0.0.0)(PORT = 1521))     (CONNECT_DATA =       (SERVER = DEDICATED)       (SERVICE_NAME = ORCLCDB.localdomain)     )   )
//            ORCLPDB1 =   (DESCRIPTION =     (ADDRESS = (PROTOCOL = TCP)(HOST = 0.0.0.0)(PORT = 1521))     (CONNECT_DATA =       (SERVER = DEDICATED)       (SERVICE_NAME = ORCLPDB1.localdomain)     )   )
//                                                                                                                                                                                                         
//           const string conString = "User Id=mmuser; Password=mm2020; Data Source=" +
//                                    "(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = mm20db)(PORT = 1522)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = ORCLCDB.mm20db)))";

           
           const string conString = "User Id=mmuser; Password=mmpwd; Data Source=" +
                                    "(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = 0.0.0.0)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = ORCLCDB.localdomain)))";


            
            services.AddDbContext<MedicalManagerDBContext>(options => 
                //options.UseOracle(conString)
                options.UseSqlServer(conString)
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
