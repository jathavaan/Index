namespace Index.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddMediatR(this IServiceCollection services)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

        return services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssemblies(assemblies.ToArray());

            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ErrorHandlingPipelineBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(CommandValidatorPipelineBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehaviour<,>));
        });
    }
}