using BusinessLogic;
using BusinessLogic.Data;
using BusinessLogic.Logic;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.Text;


namespace taskApi;

public class StartApp
{
    public IConfiguration Configuration {get;}

    public StartApp(IConfiguration configuration){
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services){

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddDbContext<TaskDbContext>(opt => {
            opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));    
        });
        services.AddTransient<ITareasRepository, TareasRepository>();
        services.AddControllers();
        services.AddCors(opt => opt.AddPolicy("CorsRule", rule => rule.AllowAnyHeader().AllowAnyMethod().WithOrigins("*")));
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {

        app.UseRouting();
        app.UseCors("CorsRule");
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints => {
            endpoints.MapControllers();
        });



    }
}
