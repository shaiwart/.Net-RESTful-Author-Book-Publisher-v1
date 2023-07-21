
using Microsoft.EntityFrameworkCore;
using WebApiRESTful_Demo_5.Models;

namespace WebApiRESTful_Demo_5;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();

        var b = builder.Configuration.GetConnectionString("MySqlDefault");
        builder.Services.AddDbContextPool<AppDbContext>((op) => op.UseMySQL(b));
        builder.Services.AddTransient<IBookInterface, MySQLBookRepository>();
        builder.Services.AddTransient<IAuthorInterface, MySQLAuthorRepository>(); 




        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

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

