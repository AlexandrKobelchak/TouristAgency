using Microsoft.EntityFrameworkCore;
using TouristAgency.DatabaseContext;

namespace TouristAgency.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            string? connStr = builder.Configuration.GetConnectionString("DefaultConnStr");
            if(connStr == null)
            {
                return;
            }

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseMySQL(connStr,
                optionBuilder => optionBuilder.MigrationsAssembly("TouristAgency.Migrations")));
            
            //command:
            //add-migration StartMigration -context TouristAgency.DatabaseContext.AppDbContext -project TouristAgency.Migrations

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
