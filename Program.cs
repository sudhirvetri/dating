using api.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<DataContext>(opt=>
{
opt.UseSqlite(builder.Configuration.GetConnectionString("DefaulConnection"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
