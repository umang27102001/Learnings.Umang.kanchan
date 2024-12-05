using Azure.Core;
using MiddlewaresPractice.Models;

namespace MiddlewaresPractice.Middleware.FactoryBasedMiddlewares
{
    public class FactoryActivatedMiddleware
    {
        private readonly Context _dbContext;

        public FactoryActivatedMiddleware(Context dbContext)
            => _dbContext = dbContext;

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var keyValue = context.Request.Query["key"];

            if (!string.IsNullOrWhiteSpace(keyValue))
            {
                try
                {
                    _dbContext.FilePath.Add(new FilePath() { Path = keyValue });

                    await _dbContext.SaveChangesAsync();
                }
                catch
                {
                    throw;
                }
            }

            await next(context);
        }
    }
}
