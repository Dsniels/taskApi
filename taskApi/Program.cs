using BusinessLogic.Data;
using Core.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Writers;
using System;
using System.Threading.Tasks;
using taskApi;


public class Program{


        private static IHostBuilder CreateHostBuilder(string[] args)=>
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => {
                webBuilder.UseStartup<StartApp>();
            });
        

        public static async Task Main(string[] args){
            var host = CreateHostBuilder(args).Build();

            using(var scope = host.Services.CreateScope()){
                var services = scope.ServiceProvider;
                try{
                    var context = services.GetRequiredService<TaskDbContext>();
                    await context.Database.MigrateAsync();
                    
                }catch(Exception e){
                    Console.WriteLine(e);

                }
            }

        }
}