using AppStore.Middleware;
using Microsoft.AspNetCore.Builder;

namespace AppStore.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app) => app.UseMiddleware<LogMiddleware>();
    }
}