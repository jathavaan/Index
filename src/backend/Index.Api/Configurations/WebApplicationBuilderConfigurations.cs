using StackExchange.Redis;

namespace Index.Api.Configurations;

public static class WebApplicationBuilderConfigurations
{
    internal static WebApplicationBuilder ConfigureBuilder(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddInfraStructureServices(builder.Configuration);

        builder.Services.AddMediatR();
        builder.ConfigureControllers();
        builder.ConfigureConfigurations();
        builder.ConfigureDatabase();
        builder.ConfigureAuthenticationAndAuthorization();
        builder.ConfigureLogging();
        builder.ConfigureSwaggerGen();
        builder.ConfigureModelExamples();
        builder.ConfigureCache();

        return builder;
    }

    private static void ConfigureSwaggerGen(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen(options => { options.ExampleFilters(); });
    }

    private static void ConfigureConfigurations(this WebApplicationBuilder builder)
    {
    }

    private static void ConfigureDatabase(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<IndexDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Index")));
    }

    private static WebApplicationBuilder ConfigureControllers(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        return builder;
    }

    private static void ConfigureAuthenticationAndAuthorization(this WebApplicationBuilder builder)
    {
    }

    private static void ConfigureLogging(this WebApplicationBuilder builder)
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
    }

    private static void ConfigureModelExamples(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());
    }

    private static void ConfigureCache(this WebApplicationBuilder builder)
    {
        builder.Services.AddTransient<IConnectionMultiplexer>(_ =>
            ConnectionMultiplexer.Connect(builder.Configuration.GetConnectionString("RedisCache") ?? string.Empty));
    }
}