using Microsoft.AspNetCore.Http.Extensions;
namespace HelloAPI;

public class LoggingMiddleware(RequestDelegate next, ILogger<LoggingMiddleware> logger) {
    public async Task InvokeAsync(HttpContext context) {
        logger.LogInformation("Request URL: {URL}", context.Request.GetDisplayUrl());
        await next(context);
    }
}