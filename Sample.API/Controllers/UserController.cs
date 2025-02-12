using Microsoft.AspNetCore.Mvc;
using Sample.Contracts.DTO;
using Sample.Core.Entities;
using Sample.Core.Handlers.Commands;
using Sample.Core.Handlers.Queries;
using System;
using System.Threading.Tasks;

namespace Sample.API.Controllers
{
    /// <summary>
    /// Controller for handling CRUD operations for User entity
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserDTO createUserDto)
        {
            var command = new CreateUserCommand
            {
                Age = createUserDto.Age
            };

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        // Implement other CRUD operations for User entity
    }
}