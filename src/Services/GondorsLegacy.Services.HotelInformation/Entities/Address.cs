using GondorsLegacy.Domain.Entities;

namespace GondorsLegacy.Services.HotelInformation;

public sealed class Address : Entity<Guid>
{
    public Guid HotelId { get; set; }
    public string? Country { get; set; }
    public string? Province { get; set; }
    public string? District { get; set; }
    public string? City { get; set; }
    public string? PostCode { get; set; }
    public string? Neighborhood { get; set; }
    public string? Street { get; set; }
    public string? AdditionalInfo { get; set; }

    public string? BuildingNumber { get; set; }
    public string? Floor { get; set; }
    public string? ApartmentNumber { get; set; }
    public string? POBox { get; set; }

    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public bool IsSecure { get; set; }
    public string? SecurityCode { get; set; }
    public string? Labels { get; set; }
}