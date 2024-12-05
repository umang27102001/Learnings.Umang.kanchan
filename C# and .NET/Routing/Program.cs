
namespace Routing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();


            //app.MapGet("/", () => "Hello World!");
            
            //app.MapGet("/hello/{name:alpha}", (string name) => $"Hello {name}!");
            app.Use(async (context, next) =>
            {
                var currentEndpoint = context.GetEndpoint();

                if (currentEndpoint is null)
                {
                    await next(context);
                    return;
                }

                Console.WriteLine($"Endpoint: {currentEndpoint.DisplayName}");

                if (currentEndpoint is RouteEndpoint routeEndpoint)
                {
                    Console.WriteLine($"  - Route Pattern: {routeEndpoint.RoutePattern}");
                }

                foreach (var endpointMetadata in currentEndpoint.Metadata)
                {
                    Console.WriteLine($"  - Metadata: {endpointMetadata}");
                }

                await next(context);
            });

            app.MapGet("/", () => "Inspect Endpoint.");
            app.Run();

        }
    }
}
