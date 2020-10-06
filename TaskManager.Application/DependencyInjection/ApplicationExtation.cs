using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace TaskManager.Application.DependencyInjection
{
    public static class ApplicationExtation
    {
        public static IServiceCollection ApplicationRegister(this IServiceCollection service)
        {
            service.AddMediatR(typeof(ApplicationExtation).Assembly);
            return service;
        }
    }
}
