using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TaskManager.Application.Interfaces;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.CQRS.Commands.CreateTask
{
    public class CreateTaskHandler : IRequestHandler<CreateTaskCommand, bool>
    {
        private readonly IDatabaseContext context;
        public CreateTaskHandler(IDatabaseContext context)
        {
            this.context = context;
        }
        public Task<bool> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new Tasks
            {

                Description = request.Description,
                Title = request.Title,
                Status = request.Status

            };

            this.context.task.AddAsync(task);
            var result =  this.context.SaveChangesAsync(cancellationToken).Result;

            return Task.FromResult(result > 0);
        }
    }
}
