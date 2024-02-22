using GondorsLegacy.Domain.Entities;

namespace GondorsLegacy.Services.HotelInformation.Entities;

public sealed class HotelCustomerReview : Entity<Guid>
{
    public Guid CustomerId { get; set; }
    public Guid HotelId { get; set; }
    public string? ReviewTitle { get; set; }
    public string? ReviewText { get; set; }
    public DateTime ReviewDate { get; set; }
    public bool IsRecommended { get; set; }

    public bool IsVerified { get; set; }
    public bool IsHelpful { get; set; }
    public int Likes { get; set; }
    public int Dislikes { get; set; }
}