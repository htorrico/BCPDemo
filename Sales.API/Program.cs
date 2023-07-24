using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sales.API.Extensions;
using Sales.Infraestructure;
using System.Configuration;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services                
                .AddUnitOfWork()
                .AddRepositories()
                .AddBusinessServices();

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles); ;


//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<EFContext>(
options =>
    options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection"),
            x => x.MigrationsAssembly("Sales.Infraestructure")));


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}





app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
