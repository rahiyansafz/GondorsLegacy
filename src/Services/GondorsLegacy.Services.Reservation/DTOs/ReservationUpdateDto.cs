namespace GondorsLegacy.Services.Reservation.DTOs;

public class ReservationUpdateDto
{
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int NumberOfGuests { get; set; }
}