using App_Test_Web;
using App_Test_Web.Services;
using App_Test_Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IWarehouseService, WarehouseService>();

builder.Services.AddDbContext<DbTestContext>(opt =>
{
    // opt.UseSqlite(builder.Configuration.GetConnectionString("SqLiteConnectionString"));
    opt.UseSqlServer("Server=KOMPUTER02\\SERVERMAIN;Database=apptestdbsql;Trusted_Connection=True;TrustServerCertificate=true");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
