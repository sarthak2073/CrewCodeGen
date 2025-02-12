using MediatR;
using Sample.Core.Entities;
using Sample.Contracts.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.Core.Handlers.Queries
{
    /// <summary>
    /// Handler for GetUserByIdQuery
    /// </summary>
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetUserByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            // Logic to get a User entity by Id
            var user = await _unitOfWork.UserRepository.GetByIdAsync(request.Id);

            if (user == null)
            {
                throw new EntityNotFoundException($"User with Id {request.Id} not found");
            }

            return user;
        }
    }
}