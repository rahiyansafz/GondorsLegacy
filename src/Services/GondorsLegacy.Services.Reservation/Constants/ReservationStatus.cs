namespace GondorsLegacy.Services.Reservation.Constants;

public record ReservationStatus(int Value, string Description)
{
    public static ReservationStatus Confirmed { get; } =
        new ReservationStatus(1, "Reservation is confirmed and valid.");

    public static ReservationStatus Pending { get; } =
        new ReservationStatus(2, "Reservation is still pending confirmation.");

    public static ReservationStatus Canceled { get; } = new ReservationStatus(3, "Reservation is canceled.");

    public static ReservationStatus Completed { get; } =
        new ReservationStatus(4, "Reservation is completed and service provided.");

    public static ReservationStatus Modified { get; } =
        new ReservationStatus(5, "Reservation is modified and updated.");

    public static ReservationStatus PastDue { get; } = new ReservationStatus(6, "Reservation is past due.");

    public static ReservationStatus PaymentPending { get; } =
        new ReservationStatus(7, "Payment is pending for the reservation.");

    public static ReservationStatus Rescheduled { get; } =
        new ReservationStatus(8, "Reservation is rescheduled to another date.");

    public static ReservationStatus Conflict { get; } = new ReservationStatus(9,
        "There is a conflict for the reservation, another date may need to be selected.");

    public static ReservationStatus Unknown { get; } =
        new ReservationStatus(10, "Reservation status is unknown or undefined.");

    public static implicit operator int(ReservationStatus status) => status.Value;

    public static implicit operator ReservationStatus(int value) => value switch
    {
        1 => ReservationStatus.Confirmed,
        2 => ReservationStatus.Pending,
        3 => ReservationStatus.Canceled,
        4 => ReservationStatus.Completed,
        5 => ReservationStatus.Modified,
        6 => ReservationStatus.PastDue,
        7 => ReservationStatus.PaymentPending,
        8 => ReservationStatus.Rescheduled,
        9 => ReservationStatus.Conflict,
        10 => ReservationStatus.Unknown,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid value")
    };

    public override string ToString() => Description;
}