namespace Index.Application.Features.Subject.Command.DeleteSubject;

public class DeleteSubjectCommandHandler(ISubjectService subjectService)
    : IRequestHandler<DeleteSubjectCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
    {
        var subject = await subjectService.GetSubject(request.SubjectCode);
        if (subject is null)
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find subject with subject code {request.SubjectCode}"
            };

        var result = await subjectService.DeleteSubject(subject);
        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}