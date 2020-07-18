using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace MedicalManager.Models
{
    public static class DbMigrationHandler
    {
        public static void DBPreSet(IApplicationBuilder app){
            using (var serviceScope = app.ApplicationServices.CreateScope()){
                    SeedData(serviceScope.ServiceProvider.GetService<MedicalManagerDBContext>());
            }
        }

        public static void SeedData(MedicalManagerDBContext context){
            System.Console.WriteLine("Applying Migrations..");
            context.Database.Migrate();
        }
    }
}