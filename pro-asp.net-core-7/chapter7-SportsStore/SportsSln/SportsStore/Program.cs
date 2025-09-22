using Microsoft.EntityFrameworkCore;
using SportsStore.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportsStoreConnection"]);
});

// AddScoped creates service for each HTTP request, meaning each HTTP request has its own repository object
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.MapControllerRoute("pagination", "Products/Page{productPage}", new { Controller = "Home", action = "Index" });
app.MapDefaultControllerRoute();
SeedData.EnsurePopulated(app);

app.Run();
