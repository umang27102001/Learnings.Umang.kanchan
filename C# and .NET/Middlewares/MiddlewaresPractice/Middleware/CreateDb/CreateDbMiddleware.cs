using MiddlewaresPractice.Models;

namespace MiddlewaresPractice.Middleware.CreateDb
{
    public class CreateDbMiddleware
    {
        private readonly RequestDelegate _next;

        public CreateDbMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            using(var dbCotntext = new Context())
            {
                await dbCotntext.Database.EnsureCreatedAsync();
            }
            await _next(context);
        }
    }
}
