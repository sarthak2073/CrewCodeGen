using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Sample.API.Controllers
{
    /// <summary>
    /// Controller for CRUD operations on Logs with attribute routing for API endpoints.
    /// </summary>
    [ApiController]
    [Route("api/logs")]
    public class LogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LogsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> CreateLog(CreateLogDTO logDTO)
        {
            var command = new CreateLogCommand(logDTO);
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> GetAllLogs()
        {
            var query = new GetAllLogsQuery();
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetLogById(int id)
        {
            var query = new GetLogByIdQuery(id);
            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateLog(int id, UpdateLogDTO logDTO)
        {
            var command = new UpdateLogCommand(id, logDTO);
            var result = await _mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteLog(int id)
        {
            var command = new DeleteLogCommand(id);
            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}