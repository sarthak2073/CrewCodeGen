using FluentValidation;
using Sample.Contracts.DTO;

namespace Sample.Core.Validators
{
    /// <summary>
    /// Validator for CreateUserDTO
    /// </summary>
    public class CreateUserDTOValidator : AbstractValidator<CreateUserDTO>
    {
        public CreateUserDTOValidator()
        {
            RuleFor(x => x.Age).NotEmpty().GreaterThan(0);
        }
    }
}