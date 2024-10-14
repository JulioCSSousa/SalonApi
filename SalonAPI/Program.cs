using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SalonAPI.AutoMapper;
using SalonAPI.Data;
using SalonAPI.Models.Entities;

namespace SalonAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<SalonAPIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SalonAPIContext") ?? throw new InvalidOperationException("Connection string 'SalonAPIContext' not found.")));

            // Add services to the container.
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()    // Permite qualquer origem
                               .AllowAnyMethod()    // Permite qualquer método (GET, POST, etc.)
                               .AllowAnyHeader();   // Permite qualquer cabeçalho
                    });
            });

            

            builder.Services.AddControllers();

            var app = builder.Build();
            

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseAuthorization();


            app.MapControllers();
            app.UseCors("AllowAll");

            app.Run();
        }
    }
}
