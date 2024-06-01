namespace Index.Api.Configurations;

internal static class WebApplicationConfiguration
{
    internal static WebApplication ConfigureApp(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.ConfigureSwagger();
        }

        app.AddSeriLog();
        app.UseHttpsRedirection();
        app.AddAuthenticationAndAuthorization();
        app.MapControllers();

        return app;
    }

    private static WebApplication ConfigureSwagger(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI(options =>
        {
            options.EnableDeepLinking();
            options.DefaultModelsExpandDepth(0);
        });

        return app;
    }

    private static WebApplication AddAuthenticationAndAuthorization(this WebApplication app)
    {
        return app;
    }

    private static WebApplication AddSeriLog(this WebApplication app)
    {
        app.UseSerilogRequestLogging();
        return app;
    }
}