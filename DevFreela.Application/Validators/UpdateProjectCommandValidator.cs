using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator: AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(u => u.Description)
                .MaximumLength(255)
                .WithMessage("Tamanho máximo de Descriçao é de 255 caracteres.");

            RuleFor(u => u.Title)
                .MaximumLength(30)
                .WithMessage("Tamanho máximo de Título é de 30 caracteres");
        }
    }
}
