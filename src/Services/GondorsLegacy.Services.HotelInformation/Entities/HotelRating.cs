using GondorsLegacy.Domain.Entities;

namespace GondorsLegacy.Services.HotelInformation.Entities;

public sealed class HotelRating : Entity<Guid>
{
    public Guid HotelId { get; set; }

    public int Stars { get; set; }

    public string? Description { get; set; }

    public float Cleanliness { get; set; }

    public float ServiceQuality { get; set; }

    public float ValueForMoney { get; set; }

    public float Location { get; set; }

    public float Amenities { get; set; }
}