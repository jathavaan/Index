namespace Index.Application.Features.Subject.Command.EditSubject;

public class EditSubjectCommandHandler(ISubjectService subjectService)
    : IRequestHandler<EditSubjectCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(EditSubjectCommand request, CancellationToken cancellationToken)
    {
        var subject = await subjectService.GetSubject(request.SubjectCode);
        if (subject is null)
            return new CommandResponse<bool>
            {
                ErrorCode = IndexErrorCode.NotFound,
                Error = $"Could not find subject with subject code {request.SubjectCode}"
            };

        var result = await subjectService.UpdateSubject(subject, request.NewName, request.Credits);
        return new CommandResponse<bool>
        {
            Result = result
        };
    }
}