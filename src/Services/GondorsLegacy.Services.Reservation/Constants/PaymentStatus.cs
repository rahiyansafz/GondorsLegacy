namespace GondorsLegacy.Services.Reservation.Constants;

public record PaymentStatus(int Value, string Description)
{
    public static PaymentStatus Paid { get; } = new PaymentStatus(1, "Payment successfully completed.");

    public static PaymentStatus PendingPayment { get; } =
        new PaymentStatus(2, "Payment has not been completed yet, pending.");

    public static PaymentStatus Refunded { get; } = new PaymentStatus(3, "Payment refunded.");
    public static PaymentStatus Failed { get; } = new PaymentStatus(4, "Payment transaction failed.");
    public static PaymentStatus PartiallyPaid { get; } = new PaymentStatus(5, "Payment partially made.");
    public static PaymentStatus Authorized { get; } = new PaymentStatus(6, "Payment authorized but not yet completed.");
    public static PaymentStatus Chargeback { get; } = new PaymentStatus(7, "Customer initiated a chargeback.");
    public static PaymentStatus Processing { get; } = new PaymentStatus(8, "Payment processing.");
    public static PaymentStatus OnHold { get; } = new PaymentStatus(9, "Payment on hold.");
    public static PaymentStatus Disputed { get; } = new PaymentStatus(10, "Payment disputed.");
    public static PaymentStatus Overdue { get; } = new PaymentStatus(11, "Payment overdue.");
    public static PaymentStatus Voided { get; } = new PaymentStatus(12, "Payment voided.");
    public static PaymentStatus Settled { get; } = new PaymentStatus(13, "Payment settled successfully.");
    public static PaymentStatus AwaitingConfirmation { get; } = new PaymentStatus(14, "Payment awaiting confirmation.");
    public static PaymentStatus Canceled { get; } = new PaymentStatus(15, "Payment canceled by the user.");
    public static PaymentStatus Refused { get; } = new PaymentStatus(16, "Payment refused.");
    public static PaymentStatus Unknown { get; } = new PaymentStatus(17, "Payment status unknown or not specified.");

    public static implicit operator int(PaymentStatus status) => status.Value;

    public static implicit operator PaymentStatus(int value) => value switch
    {
        1 => PaymentStatus.Paid,
        2 => PaymentStatus.PendingPayment,
        3 => PaymentStatus.Refunded,
        4 => PaymentStatus.Failed,
        5 => PaymentStatus.PartiallyPaid,
        6 => PaymentStatus.Authorized,
        7 => PaymentStatus.Chargeback,
        8 => PaymentStatus.Processing,
        9 => PaymentStatus.OnHold,
        10 => PaymentStatus.Disputed,
        11 => PaymentStatus.Overdue,
        12 => PaymentStatus.Voided,
        13 => PaymentStatus.Settled,
        14 => PaymentStatus.AwaitingConfirmation,
        15 => PaymentStatus.Canceled,
        16 => PaymentStatus.Refused,
        17 => PaymentStatus.Unknown,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid value")
    };

    public override string ToString() => Description;
}