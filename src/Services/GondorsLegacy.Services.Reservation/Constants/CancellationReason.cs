namespace GondorsLegacy.Services.Reservation.Constants;

public record CancellationReason(int Value, string Name)
{
    public static CancellationReason UnforeseenCircumstances { get; } =
        new CancellationReason(1, "Reservation canceled due to unforeseen circumstances.");

    public static CancellationReason ChangeOfPlans { get; } =
        new CancellationReason(2, "Reservation canceled due to change of plans.");

    public static CancellationReason FoundAnotherHotel { get; } =
        new CancellationReason(3, "Reservation canceled because another hotel was found.");

    public static CancellationReason FinancialIssues { get; } =
        new CancellationReason(4, "Reservation canceled due to financial issues.");

    public static CancellationReason Other { get; } =
        new CancellationReason(5, "Reservation canceled for other reasons.");

    public static CancellationReason HealthIssues { get; } =
        new CancellationReason(6, "Reservation canceled due to health issues.");

    public static CancellationReason TravelChange { get; } =
        new CancellationReason(7, "Reservation canceled because travel plans changed.");

    public static CancellationReason Emergency { get; } =
        new CancellationReason(8, "Reservation canceled due to an emergency.");

    public static CancellationReason HolidayChange { get; } =
        new CancellationReason(9, "Reservation canceled because holiday plans changed.");

    public static CancellationReason JobChange { get; } =
        new CancellationReason(10, "Reservation canceled due to job change.");

    public static CancellationReason BadWeather { get; } =
        new CancellationReason(11, "Reservation canceled due to bad weather conditions.");

    public static implicit operator int(CancellationReason reason) => reason.Value;

    public static implicit operator CancellationReason(int value) => value switch
    {
        1 => CancellationReason.UnforeseenCircumstances,
        2 => CancellationReason.ChangeOfPlans,
        3 => CancellationReason.FoundAnotherHotel,
        4 => CancellationReason.FinancialIssues,
        5 => CancellationReason.Other,
        6 => CancellationReason.HealthIssues,
        7 => CancellationReason.TravelChange,
        8 => CancellationReason.Emergency,
        9 => CancellationReason.HolidayChange,
        10 => CancellationReason.JobChange,
        11 => CancellationReason.BadWeather,

        _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid value")
    };

    public bool IsCancellationReason =>
        this == UnforeseenCircumstances ||
        this == ChangeOfPlans ||
        this == FoundAnotherHotel ||
        this == FinancialIssues ||
        this == Other ||
        this == HealthIssues ||
        this == TravelChange ||
        this == Emergency ||
        this == HolidayChange ||
        this == JobChange ||
        this == BadWeather;

    public override string ToString() => Name;
}