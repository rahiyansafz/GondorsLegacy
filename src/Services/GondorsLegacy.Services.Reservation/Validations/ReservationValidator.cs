namespace GondorsLegacy.Services.Reservation.Validations;

using FluentValidation;
using System;

public class ReservationValidator : AbstractValidator<Entities.Reservation>
{
    public ReservationValidator()
    {
        RuleFor(r => r.CustomerId).NotEmpty().WithMessage("Customer ID cannot be empty");
        RuleFor(r => r.CustomerFirstName).NotEmpty().WithMessage("Customer first name cannot be empty");
        RuleFor(r => r.CustomerLastName).NotEmpty().WithMessage("Customer last name cannot be empty");
        RuleFor(r => r.HotelId).NotEmpty().WithMessage("Hotel ID cannot be empty");
        RuleFor(r => r.HotelName).NotEmpty().WithMessage("Hotel name cannot be empty");
        RuleFor(r => r.CheckInDate).NotEmpty().WithMessage("Check-in date cannot be empty").GreaterThan(DateTime.Now).WithMessage("Invalid check-in date");
        RuleFor(r => r.CheckOutDate).NotEmpty().WithMessage("Check-out date cannot be empty").GreaterThan(r => r.CheckInDate).WithMessage("Check-out date cannot be before check-in date");
        RuleFor(r => r.RoomType).IsInEnum().WithMessage("Invalid room type");
        RuleFor(r => r.NumberOfGuests).NotEmpty().WithMessage("Number of guests cannot be empty").GreaterThan(0).WithMessage("Invalid number of guests");
        RuleFor(r => r.TotalPrice).NotEmpty().WithMessage("Total price cannot be empty").GreaterThan(0).WithMessage("Invalid total price");
        RuleFor(r => r.RoomNumber).NotEmpty().WithMessage("Room number cannot be empty");
        RuleFor(r => r.CustomerEmail).NotEmpty().WithMessage("Customer email address cannot be empty").EmailAddress().WithMessage("Invalid email address");
        RuleFor(r => r.ReservationStatus).IsInEnum().WithMessage("Invalid reservation status");
        RuleFor(r => r.SpecialRequests).MaximumLength(1000).WithMessage("Special requests cannot exceed 1000 characters");
        RuleFor(r => r.NumberOfAdults).GreaterThanOrEqualTo(0).WithMessage("Invalid number of adults");
        // RuleFor(r => r.NumberOfChildren).GreaterThanOrEqualTo(0).WithMessage("Invalid number of children");
        RuleFor(r => r.PaymentStatus).IsInEnum().WithMessage("Invalid payment status");
        RuleFor(r => r.CancellationReason).IsInEnum().WithMessage("Invalid cancellation reason");
    }
}
