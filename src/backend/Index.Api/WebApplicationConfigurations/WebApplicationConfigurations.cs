using Microsoft.EntityFrameworkCore;

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
}