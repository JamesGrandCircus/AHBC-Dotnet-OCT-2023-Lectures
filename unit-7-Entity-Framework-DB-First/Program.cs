using unit_7_Entity_Framework_DB_First.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace unit_7_Entity_Framework_DB_First
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Services are DEPENDENCIES!!!!!
            // ALL CONTROLLERS AND VIEWS ARE DEPENDENCIES
            // Dependency == Service
            builder.Services.AddControllersWithViews();

            // the only way a Dependency can ACCESS another Dependency (or service)
            // is IF both Services EXIST in your SERVICES COLLECTION
            builder.Services.AddDbContext<LibraryContext>(options =>
               options.UseSqlServer("Server=JIMMY-PC\\SQLEXPRESS;Database=Library;Trusted_Connection=True;MultipleActiveResultSets=true;")
             );

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
        }
    }
}