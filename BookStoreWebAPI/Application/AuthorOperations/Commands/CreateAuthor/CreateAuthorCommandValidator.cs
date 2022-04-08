using FluentValidation;
using System;

namespace BookStoreWebAPI.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();
            RuleFor(command => command.Model.Name).MinimumLength(4);

            RuleFor(command => command.Model.BirthDate).NotEmpty();
            RuleFor(command => command.Model.BirthDate).LessThan(DateTime.Now.Date);
        }
    }
}
