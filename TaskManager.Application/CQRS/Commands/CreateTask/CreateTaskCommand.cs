using MediatR;

namespace TaskManager.Application.CQRS.Commands.CreateTask
{
    public class CreateTaskCommand : IRequest<bool>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
