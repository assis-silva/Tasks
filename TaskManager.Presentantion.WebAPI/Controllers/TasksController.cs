using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.CQRS.Commands.CreateTask;

namespace TaskManager.Presentantion.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IMediator mediator;

        public TasksController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public Task<bool> Post([FromBody] CreateTaskCommand command)
        {
            return this.mediator.Send(command);
        }
    }
}