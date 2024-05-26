using Microsoft.OpenApi.Models;

namespace Index.Api.ProgramConfigurations;

public static class WebApplicationBuilderConfigurations
{
    internal static WebApplicationBuilder ConfigureBuilder(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddInfraStructureServices(builder.Configuration);
        builder.Services.AddControllers();
        builder.Services.AddMediatR();

        builder.ConfigureConfigurations();
        builder.ConfigureDatabase();
        builder.ConfigureAuthenticationAndAuthorization();
        builder.ConfigureLogging();
        builder.ConfigureSwaggerGen();
        builder.ConfigureModelExamples();

        return builder;
    }

    private static WebApplicationBuilder ConfigureSwaggerGen(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(options => { options.ExampleFilters(); });

        return builder;
    }

    private static WebApplicationBuilder ConfigureConfigurations(this WebApplicationBuilder builder)
    {
        return builder;
    }

    private static WebApplicationBuilder ConfigureDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<IndexDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Index")));

        return builder;
    }

    private static WebApplicationBuilder ConfigureControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        return builder;
    }

    private static WebApplicationBuilder ConfigureAuthenticationAndAuthorization(this WebApplicationBuilder builder)
    {
        return builder;
    }

    private static WebApplicationBuilder ConfigureLogging(this WebApplicationBuilder builder)
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
                .Enrich.WithMachineName()
                .WriteTo.Console();
        }, true);

        return builder;
    }

    private static WebApplicationBuilder ConfigureModelExamples(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());
        return builder;
    }
}