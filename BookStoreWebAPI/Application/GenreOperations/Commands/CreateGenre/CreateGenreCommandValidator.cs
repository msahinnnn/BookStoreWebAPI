﻿using FluentValidation;

namespace BookStoreWebAPI.Application.GenreOperations.Commands.CreateGenre
{
    public class CreateGenreCommandValidator:AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty();
            RuleFor(command => command.Model.Name).MinimumLength(4);
        }
    }
}
