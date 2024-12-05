namespace MiddlewaresPractice.Middleware.FactoryBasedMiddlewares
{
    public static class FactoryActivaedMiddlewareExtension
    {
        public static IApplicationBuilder UseFactoryActivatedMiddware(this IApplicationBuilder app) 
        {
            return app.UseMiddleware<FactoryActivatedMiddleware>();
        }
    }
}
