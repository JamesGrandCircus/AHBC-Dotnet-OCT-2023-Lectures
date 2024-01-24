using Microsoft.EntityFrameworkCore;
using Unit_9_API.Services;

namespace Unit_9_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // we only use AddControllers NOT AddControllrsWithViews()
            builder.Services.AddControllers();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer(); // these two services come with making a new api app.
            builder.Services.AddSwaggerGen();// don''t worr about these two services, this is that self
            // documenting api stuff

            builder.Services.AddDbContext<LibraryContext>(options =>
            {                                                    // MAKE SURE Database = the NAME OF YOUR DATABASE
                options.UseSqlServer("Server=JIMMY-PC\\SQLEXPRESS;Database=Library;Trusted_Connection=True;MultipleActiveResultSets=true;");
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
