using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MediatR;
using FluentValidation;
using System;
using CqrsTopaz.Contracts.DTO;
using CqrsTopaz.Core.Handlers.Commands;
using CqrsTopaz.Core.Handlers.Queries;

namespace CqrsTopaz.API.Controllers
{
    /// <summary>
    /// Controller for handling API requests related to test_1234_5 entity
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class Test_1234_5Controller : ControllerBase
    {
        private readonly IMediator _mediator;

        public Test_1234_5Controller(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTest_1234_5ById(int id)
        {
            var query = new GetTest_1234_5ByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTest_1234_5([FromBody] CreateTest_1234_5DTO dto)
        {
            var command = new CreateTest_1234_5Command(dto);
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetTest_1234_5ById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTest_1234_5(int id, [FromBody] UpdateTest_1234_5DTO dto)
        {
            var command = new UpdateTest_1234_5Command(id, dto);
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTest_1234_5(int id)
        {
            var command = new DeleteTest_1234_5Command(id);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}