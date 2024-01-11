using FluentValidation;


namespace CleanArchitecture.Application.Features.Propiedad.Commands.CreatePropiedad
{
     public class CreatePropiedadCommandValidator:AbstractValidator<CreatePropiedadCommand>
     {
          public CreatePropiedadCommandValidator()
          {
               RuleFor(p => p.Descripcion)
               .NotEmpty().WithMessage("{Descripcion} no puede estar en blanco")
               .NotNull()
               .MaximumLength(500).WithMessage("{Descripcion} no puede exceder los 500 caracteres");

               RuleFor(p => p.Direccion)
                    .NotEmpty().WithMessage("La {Direccion} no puede estar en blanco");
          }
     }
}
