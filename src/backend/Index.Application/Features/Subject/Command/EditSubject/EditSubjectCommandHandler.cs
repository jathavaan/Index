namespace Index.Application.Features.Subject.Command.EditSubject;

public class EditSubjectCommandHandler(ISubjectService subjectService)
    : IRequestHandler<EditSubjectCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(EditSubjectCommand request, CancellationToken cancellationToken)
        => new()
        {
            Result = await subjectService.UpdateSubject(request.SubjectCode, request.NewName, request.Credits)
        };
}