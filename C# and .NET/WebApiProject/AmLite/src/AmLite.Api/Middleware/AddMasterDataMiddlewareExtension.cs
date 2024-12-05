namespace AmLite.Api.Middleware
{
    public static class AddMasterDataMiddlewareExtension
    {
        public static IApplicationBuilder UseMasterData(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AddMasterDataMiddleware>();
        } 
    }
}
