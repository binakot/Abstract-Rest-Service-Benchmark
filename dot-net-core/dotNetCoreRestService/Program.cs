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
            new WebHostBuilder()
                .UseKestrel(o =>
                {
                    o.ApplicationSchedulingMode = SchedulingMode.Inline;
                    o.AllowSynchronousIO = false;
                })
                .Configure(app => app.Run(c =>
                {
                    if (c.Request.Path == "/api/test")
                    {
                        return c.Response.WriteAsync("Hello, World!");
                    }
                    else
                    {
                        c.Response.StatusCode = 404;
                        return c.Response.WriteAsync("Not Found");
                    }
                }))
                .Build()
                .Run();
        }
    }
}
