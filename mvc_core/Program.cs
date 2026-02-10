using Microsoft.EntityFrameworkCore;
using mvc_core.database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//registering the string
builder.Services.AddDbContext<student_db>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("CON")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=student_view}/{id?}");

app.Run();
