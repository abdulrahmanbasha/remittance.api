using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remittance.api.Middleware
{
    public static class ExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandler(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware.ExceptionMiddleware>();
        }
    }
}
