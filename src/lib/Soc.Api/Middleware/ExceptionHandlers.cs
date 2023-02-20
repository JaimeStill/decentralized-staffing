using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using static System.Net.Mime.MediaTypeNames;

namespace Soc.Api.Middleware;

public static class ExceptionHandlers
{
    public static void SimpleErrorHandler(this IApplicationBuilder app) =>
        app.Run(async context =>
        {
            IExceptionHandlerFeature error = context.Features.Get<IExceptionHandlerFeature>();

            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            context.Response.ContentType = Text.Plain;

            await context.Response.WriteAsync("An exception was thrown.\n\n");
            await context.Response.WriteAsync($"Exception: {error.Error}");
        });

    public static void DetailedErrorHandler(this IApplicationBuilder app) =>
        app.Run(async context =>
        {
            IExceptionHandlerFeature error = context.Features.Get<IExceptionHandlerPathFeature>();

            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = Application.Json;

            var response = new
            {
                user = context.User.Identity.Name ?? "N/A",
                localIp = context.Connection.LocalIpAddress.ToString() ?? "N/A",
                localPort = context.Connection.LocalPort.ToString() ?? "N/A",
                remoteIp = context.Connection.RemoteIpAddress.ToString() ?? "N/A",
                remotePort = context.Connection.RemotePort.ToString() ?? "N/A",
                contentType = context.Request.ContentType ?? "N/A",
                url = context.Request.GetDisplayUrl(),
                error = error.Error.Message ?? "Something bad happened",
                source = error.Error.Source ?? "N/A",
                type = error.Error.GetType().ToString() ?? "N/A",
                path = error.Path ?? "N/A",
                endpoint = error.Endpoint.DisplayName ?? "N/A"
            };

            await context.Response.WriteAsJsonAsync(response);
        });
}