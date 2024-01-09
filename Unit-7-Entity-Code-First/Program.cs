using Microsoft.EntityFrameworkCore;
using Unit_7_Entity_Code_First.Services;

namespace Unit_7_Entity_Code_First
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // adding my TodoContext to my Services collecti on (aka. Dependancy)
            builder.Services.AddDbContext<TodoContext>(options =>
            {
                options.UseSqlServer("Server=JIMMY-PC\\SQLEXPRESS;Database=Todos;Trusted_Connection=True;MultipleActiveResultSets=true;");
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
        }
    }
}