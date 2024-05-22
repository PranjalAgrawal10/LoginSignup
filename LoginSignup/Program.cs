using LoginSignup.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using LoginSignup.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("LoginSignupDbContextConnection") ?? throw new InvalidOperationException("Connection string 'LoginSignupDbContextConnection' not found.");

builder.Services.AddDbContext<LoginSignupDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<LoginSignupUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<LoginSignupDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

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

app.MapRazorPages();
app.Run();