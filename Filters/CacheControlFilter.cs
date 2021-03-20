﻿using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace remittance.api.Filters
{
    /// <summary>
    /// Filter to add header Cache-Control to responses
    /// </summary>
    /// <remarks>See: https://github.com/drwatson1/AspNet-Core-REST-Service/wiki#cache-control</remarks>
    public class CacheControlFilter : IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {

        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (context.HttpContext.Request.Method == "GET")
            {
                context.HttpContext.Response.Headers.Add(
                    "Cache-Control", new string[] { "no-cache, no-store, must-revalidate" });
            }
        }
    }
}
