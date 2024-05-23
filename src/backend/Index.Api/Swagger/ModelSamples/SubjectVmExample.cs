namespace Index.Api.Swagger.ModelSamples;

public class SubjectVmExample : IExamplesProvider<SubjectVm>
{
    public SubjectVm GetExamples()
        => new()
        {
            SubjectCode = "TDT4100",
            SubjectName = "Object oriented programming",
            Credits = 7.5
        };
}