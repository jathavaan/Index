namespace Index.Api.ProgramConfigurations;

internal static class WebApplicationConfiguration
{
    internal static WebApplication ConfigureApp(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.ConfigureSwagger();
        }

        app.UseHttpsRedirection();
        // app.MapIdentityApi();
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

    private static WebApplication MapIdentityApi(this WebApplication app)
    {
        // app.MapIdentityApi<UserProfile>();
        return app;
    }

    private static WebApplication AddAuthenticationAndAuthorization(this WebApplication app)
    {
        /*app.UseAuthentication();
        app.UseAuthorization();*/
        return app;
    }
}