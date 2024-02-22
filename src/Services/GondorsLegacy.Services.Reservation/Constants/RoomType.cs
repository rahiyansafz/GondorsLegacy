namespace GondorsLegacy.Services.Reservation.Constants;

public record RoomType(int Value, string Description)
{
    public static RoomType Standard { get; } = new RoomType(1, "Standard room type, with basic comfort.");
    public static RoomType Deluxe { get; } = new RoomType(2, "Deluxe room type, with luxury and extra amenities.");
    public static RoomType Suite { get; } = new RoomType(3, "Suite room type, offering spacious and luxurious areas.");

    public static RoomType Villa { get; } =
        new RoomType(4, "Villa room type, typically an independent and luxurious accommodation unit.");

    public static RoomType Family { get; } =
        new RoomType(5, "Family room type, suitable for large families or groups.");

    public static RoomType Business { get; } =
        new RoomType(6, "Business room type, suitable for business trips, with work areas.");

    public static RoomType SeaView { get; } = new RoomType(7, "Sea view room type, for rooms with a sea view.");
    public static RoomType PoolView { get; } = new RoomType(8, "Pool view room type, for rooms with a pool view.");

    public static RoomType MountainView { get; } =
        new RoomType(9, "Mountain view room type, for rooms with a mountain view.");

    public static RoomType Jacuzzi { get; } =
        new RoomType(10, "Jacuzzi room type, for luxurious rooms with a jacuzzi.");

    public static implicit operator int(RoomType type) => type.Value;

    public static implicit operator RoomType(int value) => value switch
    {
        1 => RoomType.Standard,
        2 => RoomType.Deluxe,
        3 => RoomType.Suite,
        4 => RoomType.Villa,
        5 => RoomType.Family,
        6 => RoomType.Business,
        7 => RoomType.SeaView,
        8 => RoomType.PoolView,
        9 => RoomType.MountainView,
        10 => RoomType.Jacuzzi,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid value")
    };

    public override string ToString() => Description;
}