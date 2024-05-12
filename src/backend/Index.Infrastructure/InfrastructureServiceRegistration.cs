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
        services.AddTransient<IStudyPlanService, StudyPlanService>();
        services.AddTransient<IStudyPlanRestrictionService, StudyPlanRestrictionService>();

        // Hosted services

        return services;
    }
}