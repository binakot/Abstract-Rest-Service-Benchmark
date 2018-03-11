using System;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Abstractions.Internal;

namespace dotNetCoreRestService
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var message = Encoding.UTF8.GetBytes("Hello, World!");
            var messageSize = message.Length;

            var notFoundMessage = Encoding.UTF8.GetBytes("Not Found");
            var notFoundMessageSize = notFoundMessage.Length;

            var apiPath = new PathString("/api/test");

            new WebHostBuilder()
                .UseKestrel(options =>
                {
                    options.ApplicationSchedulingMode = SchedulingMode.Inline;
                    options.AllowSynchronousIO = false;
                    options.AddServerHeader = false;
                })
                .UseLibuv(options => { options.ThreadCount = Environment.ProcessorCount; })
                .Configure(app => app.Run(httpContext =>
                {
                    if (httpContext.Request.Path == apiPath)
                    {
                        return httpContext.Response.Body.WriteAsync(message, 0, messageSize);
                    }

                    httpContext.Response.StatusCode = 404;
                    return httpContext.Response.Body.WriteAsync(notFoundMessage, 0, notFoundMessageSize);
                }))
                .Build()
                .Run();
        }
    }
}