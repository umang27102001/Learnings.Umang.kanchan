namespace MiddlewaresPractice.Middleware.ExceptionHandle
{
    /// <summary>
    /// Custom exception handling middleware delegate encapsulated in a class.
    /// </summary>
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate _next)
        {
            this._next = _next;
        }
        /// <summary>
        /// This method performs work before and after the _next middleware delegate in HTTP request pipeline.
        /// </summary>
        /// <param name="context">
        /// HTTP context that contains all the HTTP-related information about an HTTP request.
        /// </param>
        /// <param name="writer">
        /// A contract used to exposes MessageWiter.Writer method.
        /// </param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext context, IMessageWriter writer)
        {
            try
            {
               await _next(context);
            }
            catch (Exception ex)
            {
                writer.Writer(ex.Message);
                await context.Response.WriteAsync(ex.Message);
            }
        }
    }
}
