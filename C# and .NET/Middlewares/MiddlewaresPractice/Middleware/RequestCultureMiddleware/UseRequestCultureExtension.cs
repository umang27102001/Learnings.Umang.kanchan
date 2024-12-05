namespace MiddlewaresPractice.Middleware.RequestCultureMiddleware
{
    public static class UseRequestCultureExtension
    {
        public static IApplicationBuilder UseRequestCulture(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestCultureMiddleware>();
        }
    }
}
