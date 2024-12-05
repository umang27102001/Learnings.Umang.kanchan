namespace MiddlewaresPractice
{
    using MiddlewaresPractice.Middleware.CreateDb;
    using MiddlewaresPractice.Middleware.ExceptionHandle;
    using MiddlewaresPractice.Middleware.FactoryBasedMiddlewares;
    using MiddlewaresPractice.Middleware.RequestCultureMiddleware;
    using MiddlewaresPractice.Models;
    using System.Globalization;
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a web application builder to configure the http request pipeline and services.
            var builder = WebApplication.CreateBuilder(args);

            // Register IMessageWriter service with its implementation with Scoped lifetime in the service.
            builder.Services.AddScoped<IMessageWriter, MessageWriter>();
            builder.Services.AddDbContext<Context>();
            builder.Services.AddTransient<FactoryActivatedMiddleware>();
            // Build the web application.
            var app = builder.Build();

            // Always add exception middlewares in the beginning of the pipeline so that they can catch any exception in later calls.
            app.UseCustomException();
            app.UseDbMiddleware();
            app.UseFactoryActivatedMiddware();
            app.UseRequestCulture();

            // Add an in-line middleware delegate to the HTTP request pipeline.
            app.Use(async (context, next) =>
            {
                var name = context.Request.Query["name"];
                if (!string.IsNullOrEmpty(name))
                {
                    await context.Response.WriteAsync($"Hello {name}\n");
                }
                else
                {
                    throw new Exception("Please provide a name in query params. eg: name=umang");
                }
                await next(context);
            });

            // Run delegate that is working as a terminal middleware in the request pipeline.
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(
                    $"CurrentCulture.DisplayName: {CultureInfo.CurrentCulture.DisplayName}");
            });

            app.Run();
        }
    }
}
