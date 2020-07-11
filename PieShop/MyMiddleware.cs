using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public MyMiddleware(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;
            _logger = logFactory.CreateLogger("MyMidleware");
        }

        public Task Invoke(HttpContext httpContext)
        {
            // write your own logic
            Console.WriteLine(" Request from User{0}", httpContext.User.Identity.Name);
            var isAuth = httpContext.Request.HttpContext.User.Identity.IsAuthenticated;
            _logger.LogInformation("MyMiddelware is executing ...");
            return _next(httpContext);
        }
    }

     // Extension method for middleware for HttpRequest

    public static class MyMiddlewareExtensions
    {
         public static IApplicationBuilder UseMyMidleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware>();
        }
    }
}
