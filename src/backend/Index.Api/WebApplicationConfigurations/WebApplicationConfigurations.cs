using Serilog.Debugging;

namespace Index.Api.WebApplicationConfigurations;

public static class WebApplicationConfigurations
{
    internal static WebApplicationBuilder ConfigureConfigurations(this WebApplicationBuilder builder)
    {
        return builder;
    }

    internal static WebApplicationBuilder ConfigureDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<IndexDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Index")));

        return builder;
    }

    internal static WebApplicationBuilder ConfigureControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        return builder;
    }

    internal static WebApplicationBuilder ConfigureLogging(this WebApplicationBuilder builder)
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateBootstrapLogger();

        builder.Host.UseSerilog((context, loggerConfiguration) =>
        {
            SelfLog.Enable(Console.WriteLine);

            loggerConfiguration.ReadFrom.Configuration(context.Configuration)
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.EntityFrameworkCore", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.AspNetCore.Hosting", LogEventLevel.Information)
                .Enrich.WithMachineName()
                .WriteTo.Console();
        }, true);

        return builder;
    }
}