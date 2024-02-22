using GondorsLegacy.Services.HotelInformation.Entities;

namespace GondorsLegacy.Services.HotelInformation.Features.Hotel.GetHotel;

public class HotelResponse
{
    public Guid? HotelId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public List<Address>? Addresses { get; set; }
    public string? EmailAddress { get; set; }
    public string? Phone { get; set; }
    public string? Website { get; set; }
    public List<HotelRoom>? Rooms { get; set; }
    public List<HotelService>? Services { get; set; }
    public List<HotelPolicy>? Policies { get; set; }
    public List<HotelCustomerReview>? HotelCustomerReviews { get; set; }
    public List<HotelRating>? HotelRatings { get; set; }
}