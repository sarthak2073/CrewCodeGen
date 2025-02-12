using MediatR;
using Sample.Core.Entities;
using Sample.Contracts.DTO;
using Sample.Contracts.Responses;
using Sample.Core.Exceptions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Core.Handlers.Commands
{
    /// <summary>
    /// Handler for CreateUserCommand
    /// </summary>
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, BaseResponseDTO>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<BaseResponseDTO> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            // Logic to create a new User entity
            var user = new User
            {
                Age = request.Age
            };

            _unitOfWork.UserRepository.Add(user);
            await _unitOfWork.SaveAsync();

            return new BaseResponseDTO { Success = true, Message = "User created successfully" };
        }
    }
}