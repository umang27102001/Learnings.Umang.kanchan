namespace AmLite
{
    using AmLite.Api;
    using AmLite.Api.Middleware;
    using AmLite.Business;
    using AmLite.Repository;
    using AmLite.Repository.DbContexts;
    using System.Diagnostics.CodeAnalysis;
    [ExcludeFromCodeCoverage]
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
            builder.Services.AddScoped<IAmRepository, AmRepository>();
            builder.Services.AddScoped<IAmBusiness, AmBusiness>();
            builder.Services.AddDbContext<AmDbContext>();
            builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
            var app = builder.Build();

            
            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseMasterData();
            app.MapControllers();
            app.MapGet("", async(context) =>
            {
                await context.Response.WriteAsync("hello");
            });
            app.Run();

        }
    }
}