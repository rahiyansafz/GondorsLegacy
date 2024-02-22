﻿using GondorsLegacy.Domain.Entities;
using GondorsLegacy.Services.Reservation.Constants;

namespace GondorsLegacy.Services.Reservation.Entities;

public class Reservation : Entity<Guid>
{
    public Guid CustomerId { get; set; }
    public string CustomerFirstName { get; set; }
    public string CustomerLastName { get; set; }
    public Guid HotelId { get; set; }
    public string HotelName { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public RoomType RoomType { get; set; }
    public int NumberOfGuests { get; set; }
    public decimal TotalPrice { get; set; }
    public int RoomNumber { get; set; }
    public string CustomerEmail { get; set; }
    public ReservationStatus ReservationStatus { get; set; }
    public string SpecialRequests { get; set; }
    public int NumberOfAdults { get; set; }
    public int NumberOfChildren { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
    public CancellationReason CancellationReason { get; set; }
    public bool IsReservationCancelled { get; set; } = false;
}