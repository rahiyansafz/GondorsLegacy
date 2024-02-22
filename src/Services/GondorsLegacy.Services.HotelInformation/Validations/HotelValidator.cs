using FluentValidation;

namespace GondorsLegacy.Services.HotelInformation.Validations;

public class HotelValidator : AbstractValidator<Entities.Hotel>
{
    public HotelValidator()
    {
        RuleFor(h => h.Name)
            .NotEmpty()
            .WithMessage("Hotel name cannot be empty.");

        RuleFor(h => h.Description)
            .NotEmpty()
            .WithMessage("Hotel description cannot be empty.")
            .MaximumLength(2500)
            .MinimumLength(50);

        // RuleFor(h => h.Id)
        //     .NotEqual(Guid.Empty)
        //     .WithMessage("A valid Hotel Id must be specified.")
        //     .NotEqual(Guid.Parse("00000000-0000-0000-0000-000000000001"))
        //     .WithMessage("A valid Hotel Id must be specified.");
    }
}