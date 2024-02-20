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

            // ADD CORS as a serivce!
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy =>
                    {
                        //replace localhost with yours
                        //also add your deployed website
                        policy.WithOrigins("http://localhost:4200",
                            // you can put in MULTIPLE urls, this is A WAY to 
                            // solve for multiple environments! more on that later
                                            "https://MyChatRoom.com")
                        .AllowAnyMethod() // method in this context means GET, POST, PUT, DELETE, etc. 
                        .AllowAnyHeader();
                    });
            });


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

            // use that CORS service in MIDDLEWARE, more on MIDDLEWARE later!
            app.UseCors();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
