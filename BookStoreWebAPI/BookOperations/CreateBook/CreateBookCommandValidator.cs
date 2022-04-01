using FluentValidation;
using System;

namespace BookStoreWebAPI.BookOperations.CreateBook
{
    public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            
            RuleFor(command => command.Model.PageCount).GreaterThan(0);
            
            RuleFor(command => command.Model.PublishDate).NotEmpty();
            RuleFor(command => command.Model.PublishDate).LessThan(DateTime.Now.Date);

            RuleFor(command => command.Model.Title).NotEmpty();
            RuleFor(command => command.Model.Title).MinimumLength(4);
        }
    }
}
