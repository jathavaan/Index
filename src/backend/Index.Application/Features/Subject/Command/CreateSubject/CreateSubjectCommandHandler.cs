namespace Index.Application.Features.Subject.Command.CreateSubject;

public class CreateSubjectCommandHandler(ISubjectService subjectService)
    : IRequestHandler<CreateSubjectCommand, CommandResponse<bool>>
{
    public async Task<CommandResponse<bool>> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        => new()
        {
            Result = await subjectService.CreateSubject(request.Dto.SubjectCode, request.Dto.Name, request.Dto.Credit)
        };
}