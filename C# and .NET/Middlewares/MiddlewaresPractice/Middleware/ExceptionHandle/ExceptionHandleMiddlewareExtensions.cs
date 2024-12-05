namespace MiddlewaresPractice.Middleware.ExceptionHandle
{
    /// <summary>
    /// A static class that contains the extension methods for adding the ExceptionHandlingMiddleware to HTTP request pipeline.
    /// </summary>
    public static class ExceptionHandleMiddlewareExtensions
    {
        /// <summary>
        /// Adds ExceptionHandlingMiddleware to HTTP request pipeline.
        /// </summary>
        /// <param name="builder">
        /// The Microsoft.AspNetCore.Builder.IApplicationBuilder to add the middleware to.
        /// </param>
        /// <returns>
        /// A reference to this instance after the operation has completed.
        /// </returns>
        public static IApplicationBuilder UseCustomException(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlingMiddleware>();
        }
    }
}
