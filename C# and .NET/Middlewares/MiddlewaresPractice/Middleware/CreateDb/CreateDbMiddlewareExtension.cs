namespace MiddlewaresPractice.Middleware.CreateDb
{
    public static class CreateDbMiddlewareExtension
    {
        public static IApplicationBuilder UseDbMiddleware(this IApplicationBuilder app) 
        {
            return app.UseMiddleware<CreateDbMiddleware>();
        }
    }
}
