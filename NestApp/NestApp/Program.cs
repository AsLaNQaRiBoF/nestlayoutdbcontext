using Microsoft.EntityFrameworkCore;
using NestApp.DAL;
using NestApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]));
var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();



app.MapDefaultControllerRoute();

app.Run();
