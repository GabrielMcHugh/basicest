using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Data;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    var connection = "DevelopmentBlogContext";
    builder.Services.AddDbContext<BlogContext>(
        options =>
            options.UseSqlite(
                builder.Configuration.GetConnectionString(connection)
                    ?? throw new InvalidOperationException(
                        $"Connection string {connection} not found."
                    )
            )
    );
}
else
{
    var connection = "ProductionBlogContext";
    builder.Services.AddDbContext<BlogContext>(
        options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString(connection)
                    ?? throw new InvalidOperationException(
                        $"Connection string {connection} not found."
                    )
            )
    );
}

// // Add services to the container.
// var connectionString =
//     builder.Configuration.GetConnectionString("DefaultConnection")
//     ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
// builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlite(connectionString));
// builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// builder
//     .Services.AddDefaultIdentity<IdentityUser>(
//         options => options.SignIn.RequireConfirmedAccount = true
//     )
//     .AddEntityFrameworkStores<ApplicationDbContext>();
// builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
