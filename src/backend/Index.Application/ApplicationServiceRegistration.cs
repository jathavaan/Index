namespace Index.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        // Transient services
        services.AddTransient<IUserProfileService, UserProfileService>();
        services.AddTransient<ISubjectService, SubjectService>();
        services.AddTransient<IReportCardService, ReportCardService>();

        // Hosted services

        return services;
    }

    public static IServiceCollection AddMediatR(this IServiceCollection services)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

        return services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(assemblies.ToArray());

            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ErrorHandlingPipelineBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(CommandValidatorPipelineBehaviour<,>));
        });
    }
}