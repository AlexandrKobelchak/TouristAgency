using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TouristAgency.DatabaseContext;
using TouristAgency.Entities.Identity;
using TouristAgency.Repositories;

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

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            builder.Services.AddTransient<DbContext, AppDbContext>();

            builder.Services.AddTransient<IBankRepository, BankRepository>();
            builder.Services.AddTransient<ICompanyRepository, CompanyRepository>();
            builder.Services.AddTransient<ICountryRepository, CountryRepository>();
            builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddTransient<IIndividualPersonRepository, IndividualPersonRepository>();
            builder.Services.AddTransient<ILegalPersonRepository, LegalPersonRepository>();
            builder.Services.AddTransient<ISaleRepository, SaleRepository>();
            builder.Services.AddTransient<ITouristPhoneRepository, TouristPhoneRepository>();
            builder.Services.AddTransient<ITouristProfileRepository, TouristProfileRepository>();
            builder.Services.AddTransient<ITourRepository, TourRepository>();
            builder.Services.AddTransient<ITourTypeRepository, TourTypeRepository>();
            builder.Services.AddTransient<ITouristTagRepository, TouristTagRepository>();
            builder.Services.AddTransient<ISocialNetworkRepository, SocialNetworkRepository>();

            builder.Services.AddIdentityCore<AppUser>()
                .AddRoles<AppRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            builder.Services.Configure<IdentityOptions>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;

                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

            });

            builder.Services.AddAuthentication();

            builder.Services.AddAuthorization(options => {
                options.AddPolicy("RequireModerator",
                    policy => policy.RequireRole("Administrator", "Moderator").RequireAuthenticatedUser());

                options.AddPolicy("RequireAdministrator",
                    policy => policy.RequireRole("Administrator").RequireAuthenticatedUser());
            });

            builder.Services.AddAuthorization(options => {
                options.AddPolicy("RequireModerator",
                    policy => policy.RequireRole("Administrator", "Moderator").RequireAuthenticatedUser());

                options.AddPolicy("RequireAdministrator",
                    policy => policy.RequireRole("Administrator").RequireAuthenticatedUser());
            });


            ///////////////////////////////////////////////////////////////////////////////////////////////////

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
