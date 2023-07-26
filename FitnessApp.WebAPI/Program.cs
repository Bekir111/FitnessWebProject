
namespace FitnessApp.WebAPI
{
    using FitnessApp.Data;
    using FitnessApp.Services.Data.Interfaces;
    using FitnessApp.Web.Infrastructure.Extensions;
    using Microsoft.EntityFrameworkCore;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<FitnessAppDbContext>(opt => 
            opt.UseSqlServer(connectionString));

            builder.Services.AddApplicationServices(typeof(IStatisticsService));


            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(setup =>
            {
                setup.AddPolicy("FitnessApp", policyBuilder =>
                {
                    policyBuilder.WithOrigins("https://localhost:7093")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.UseCors("FitnessApp");

            app.Run();
        }
    }
}