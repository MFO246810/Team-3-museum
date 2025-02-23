using Team_3_mueseum;
using Team_3_mueseum.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
var connstr = builder.Configuration.GetConnectionString("SqlConn");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connstr);
});

builder.Services.AddScoped<UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
