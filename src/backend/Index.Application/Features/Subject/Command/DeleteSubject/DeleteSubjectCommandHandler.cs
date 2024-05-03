using Index.Application.Features.Subject.Command.CreateSubject;

namespace Index.Application.Features.Subject.Command.DeleteSubject;

public class DeleteSubjectCommandHandler(ISubjectService subjectService) : IRequestHandler<DeleteSubjectCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        => new()
        {
            Result = await subjectService.DeleteSubject(request.SubjectCode)
        };
}