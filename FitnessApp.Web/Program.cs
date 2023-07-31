using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FitnessApp.Data;
namespace FitnessApp.Web
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    using FitnessApp.Data;
    using FitnessApp.Data.Models;
    using FitnessApp.Web.Infrastructure.Extensions;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Services.Data;
    using FitnessApp.Web.Infrastructure.ModelBinders;
    using FitnessApp.Web.Controllers;
    using Microsoft.AspNetCore.Mvc;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            builder.Services.AddDbContext<FitnessAppDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
                options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireLowercase");
                options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Identity:Password:RequireUppercase");
                options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
                options.Password.RequiredLength = builder.Configuration.GetValue<int>("Identity:Password:RequiredLength");
            })
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<FitnessAppDbContext>();

            builder.Services.AddApplicationServices(typeof(IProgramService));


            builder.Services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/User/Login";
            });

            //builder.Services.AddDistributedMemoryCache();

            //builder.Services.AddSession(options =>
            //{
            //    options.IdleTimeout = TimeSpan.FromMinutes(30);
            //    options.Cookie.IsEssential = true;
            //});

            builder.Services
                .AddControllersWithViews()
                .AddMvcOptions(options =>
                {
                    options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
                    options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
                });


            var app = builder.Build();

           // app.UseSession();

            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error/500");
                app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");

                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.SeedAdministrator("admin@admin.com");

            app.UseEndpoints(config =>
            {
                config.MapControllerRoute(
                    name: "ProtectingUrlPattern",
                    pattern: "/{controller}/{action}/{id}/{information}",
                    defaults: new { Controller = "Post", Action = "Detail"}
                    );
                config.MapDefaultControllerRoute();
                config.MapRazorPages();
            });

            app.Run();
        }
    }
}