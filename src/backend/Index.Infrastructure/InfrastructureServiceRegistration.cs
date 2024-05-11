namespace Index.Infrastructure;

public static class InfrastructureServiceRegistration
{
    public static IServiceCollection AddInfraStructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        // Transient services
        services.AddTransient<IUserProfileService, UserProfileService>();
        services.AddTransient<ISubjectService, SubjectService>();
        services.AddTransient<IReportCardService, ReportCardService>();
        services.AddTransient<IAssignmentService, AssignmentService>();
        services.AddTransient<IAssignmentGroupSerivce, AssignmentGroupService>();

        // Hosted services

        return services;
    }


}