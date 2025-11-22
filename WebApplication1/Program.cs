
namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseRouting(); // Agar yo'q bo'lsa qo'shing
                              // ...
                              // Eng oddiy "Hello World" javobini "/" yo'lida qaytaradi
            app.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("WebApplication1 is running! Use /swagger to see API endpoints.");
            });

            app.MapControllers();
            app.Run();

            app.MapControllers();

            app.Run();
        }
    }
}
