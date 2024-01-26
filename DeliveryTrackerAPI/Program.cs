using AutoMapper;
using DeliveryTrackerAPI.Data;
using DeliveryTrackerAPI.Profiles;
using Microsoft.EntityFrameworkCore;
using System;

namespace DeliveryTrackerAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("Default")
                    );
                options.UseLazyLoadingProxies();
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var configuration = new MapperConfiguration(cfg => {

                cfg.AddProfile<CargoProfile>();
                cfg.AddProfile<DeliveryProfile>();
                cfg.AddProfile<DriverProfile>();

            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}