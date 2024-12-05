using System.Globalization;

namespace MiddlewaresPractice.Middleware.RequestCultureMiddleware
{
    public class RequestCultureMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestCultureMiddleware(RequestDelegate _next)
        {
            this._next = _next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var cultureName = context.Request.Query["culture"];
            if (!string.IsNullOrEmpty(cultureName))
            {
                var culture = new CultureInfo(cultureName);

                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;
            }
            else
            {
                throw new Exception("Please provide a culture name in query params. eg: culture=es-es");
            }
            await _next(context);
        }
    }
}
