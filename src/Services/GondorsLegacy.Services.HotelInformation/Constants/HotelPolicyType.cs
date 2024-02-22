namespace GondorsLegacy.Services.HotelInformation.Constants;

public record HotelPolicyType(int Value, string Name)
{
    public static HotelPolicyType CancellationAllowed { get; } = new HotelPolicyType(1, "Cancellation Allowed");
    public static HotelPolicyType NoCancellationAllowed { get; } = new HotelPolicyType(2, "No Cancellation Allowed");
    public static HotelPolicyType PetsAllowed { get; } = new HotelPolicyType(3, "Pets Allowed");
    public static HotelPolicyType NoPetsAllowed { get; } = new HotelPolicyType(4, "No Pets Allowed");
    public static HotelPolicyType SmokingAllowed { get; } = new HotelPolicyType(5, "Smoking Allowed");
    public static HotelPolicyType NoSmokingAllowed { get; } = new HotelPolicyType(6, "No Smoking Allowed");
    public static HotelPolicyType BreakfastIncluded { get; } = new HotelPolicyType(7, "Breakfast Included");
    public static HotelPolicyType NoBreakfastIncluded { get; } = new HotelPolicyType(8, "No Breakfast Included");

    public static HotelPolicyType FreeCancellationAllowed { get; } =
        new HotelPolicyType(9, "Free Cancellation Allowed");

    public static HotelPolicyType PaidCancellationAllowed { get; } =
        new HotelPolicyType(10, "Paid Cancellation Allowed");

    public static HotelPolicyType FreeWiFiAvailable { get; } = new HotelPolicyType(11, "Free WiFi Available");
    public static HotelPolicyType PaidWiFiAvailable { get; } = new HotelPolicyType(12, "Paid WiFi Available");
    public static HotelPolicyType ParkingAvailable { get; } = new HotelPolicyType(13, "Parking Available");

    public static HotelPolicyType AirportTransferAvailable { get; } =
        new HotelPolicyType(14, "Airport Transfer Available");

    public static HotelPolicyType LaundryServiceAvailable { get; } =
        new HotelPolicyType(15, "Laundry Service Available");

    public static HotelPolicyType RoomServiceAvailable { get; } = new HotelPolicyType(16, "Room Service Available");
    public static HotelPolicyType MiniBarAvailable { get; } = new HotelPolicyType(17, "MiniBar Available");
    public static HotelPolicyType GymAvailable { get; } = new HotelPolicyType(18, "Gym Available");
    public static HotelPolicyType SpaAvailable { get; } = new HotelPolicyType(19, "Spa Service Available");
    public static HotelPolicyType PoolAvailable { get; } = new HotelPolicyType(20, "Pool Available");
    public static HotelPolicyType MeetingRoomsAvailable { get; } = new HotelPolicyType(21, "Meeting Rooms Available");
    public static HotelPolicyType RestaurantAvailable { get; } = new HotelPolicyType(22, "Restaurant Available");
    public static HotelPolicyType BarAvailable { get; } = new HotelPolicyType(23, "Bar Available");

    public static HotelPolicyType TwentyFourHourFrontDesk { get; } =
        new HotelPolicyType(24, "24-Hour Front Desk Service");

    public static HotelPolicyType BusinessCenterAvailable { get; } =
        new HotelPolicyType(25, "Business Center Available");

    public static HotelPolicyType ChildCareServicesAvailable { get; } =
        new HotelPolicyType(26, "Child Care Services Available");

    public static HotelPolicyType ConciergeServiceAvailable { get; } =
        new HotelPolicyType(27, "Concierge Service Available");

    public static HotelPolicyType CurrencyExchangeAvailable { get; } =
        new HotelPolicyType(28, "Currency Exchange Service Available");

    public static HotelPolicyType DisabilityAccessible { get; } = new HotelPolicyType(29, "Disability Accessible");
    public static HotelPolicyType ExpressCheckIn { get; } = new HotelPolicyType(30, "Express Check-In Available");
    public static HotelPolicyType ExpressCheckOut { get; } = new HotelPolicyType(31, "Express Check-Out Available");
    public static HotelPolicyType IndoorPoolAvailable { get; } = new HotelPolicyType(32, "Indoor Pool Available");
    public static HotelPolicyType OutdoorPoolAvailable { get; } = new HotelPolicyType(33, "Outdoor Pool Available");
    public static HotelPolicyType SaunaAvailable { get; } = new HotelPolicyType(34, "Sauna Service Available");
    public static HotelPolicyType JacuzziAvailable { get; } = new HotelPolicyType(35, "Jacuzzi Available");
    public static HotelPolicyType TerraceAvailable { get; } = new HotelPolicyType(36, "Terrace Available");
    public static HotelPolicyType GardenAvailable { get; } = new HotelPolicyType(37, "Garden Available");
    public static HotelPolicyType BeachAccessAvailable { get; } = new HotelPolicyType(38, "Beach Access Available");
    public static HotelPolicyType TennisCourtsAvailable { get; } = new HotelPolicyType(39, "Tennis Courts Available");
    public static HotelPolicyType GolfCourseAvailable { get; } = new HotelPolicyType(40, "Golf Course Available");
    public static HotelPolicyType BikeRentalAvailable { get; } = new HotelPolicyType(41, "Bike Rental Available");
    public static HotelPolicyType CarRentalAvailable { get; } = new HotelPolicyType(42, "Car Rental Service Available");

    public static HotelPolicyType ShuttleServiceAvailable { get; } =
        new HotelPolicyType(43, "Shuttle Service Available");

    public static HotelPolicyType BabysittingServicesAvailable { get; } =
        new HotelPolicyType(44, "Babysitting Services Available");

    public static HotelPolicyType LibraryAvailable { get; } = new HotelPolicyType(45, "Library Available");
    public static HotelPolicyType GameRoomAvailable { get; } = new HotelPolicyType(46, "Game Room Available");
    public static HotelPolicyType MovieTheaterAvailable { get; } = new HotelPolicyType(47, "Movie Theater Available");

    public static HotelPolicyType LiveEntertainmentAvailable { get; } =
        new HotelPolicyType(48, "Live Entertainment Available");

    public static HotelPolicyType KaraokeAvailable { get; } = new HotelPolicyType(49, "Karaoke Available");
    public static HotelPolicyType DanceFloorAvailable { get; } = new HotelPolicyType(50, "Dance Floor Available");

    public static HotelPolicyType IndoorSportsFacilitiesAvailable { get; } =
        new HotelPolicyType(51, "Indoor Sports Facilities Available");

    public static HotelPolicyType OutdoorSportsFacilitiesAvailable { get; } =
        new HotelPolicyType(52, "Outdoor Sports Facilities Available");

    public static HotelPolicyType PetFriendlyRoomsAvailable { get; } =
        new HotelPolicyType(53, "Pet-Friendly Rooms Available");

    public static HotelPolicyType ChildFriendlyFacilities { get; } =
        new HotelPolicyType(54, "Child-Friendly Facilities");

    public static HotelPolicyType EcoFriendlyPolicies { get; } = new HotelPolicyType(55, "Eco-Friendly Policies");

    public static HotelPolicyType AllInclusivePackagesAvailable { get; } =
        new HotelPolicyType(56, "All-Inclusive Packages Available");

    public static HotelPolicyType VeganMenuOptionsAvailable { get; } =
        new HotelPolicyType(57, "Vegan Menu Options Available");

    public static HotelPolicyType HalalMenuOptionsAvailable { get; } =
        new HotelPolicyType(58, "Halal Menu Options Available");

    public static HotelPolicyType KosherMenuOptionsAvailable { get; } =
        new HotelPolicyType(59, "Kosher Menu Options Available");

    public static HotelPolicyType OrganicFoodOptionsAvailable { get; } =
        new HotelPolicyType(60, "Organic Food Options Available");

    public static implicit operator int(HotelPolicyType hotelPolicyType) => hotelPolicyType.Value;

    public static implicit operator HotelPolicyType(int value) => value switch
    {
        1 => HotelPolicyType.CancellationAllowed,
        2 => HotelPolicyType.NoCancellationAllowed,
        3 => HotelPolicyType.PetsAllowed,
        4 => HotelPolicyType.NoPetsAllowed,
        5 => HotelPolicyType.SmokingAllowed,
        6 => HotelPolicyType.NoSmokingAllowed,
        7 => HotelPolicyType.BreakfastIncluded,
        8 => HotelPolicyType.NoBreakfastIncluded,
        9 => HotelPolicyType.FreeCancellationAllowed,
        10 => HotelPolicyType.PaidCancellationAllowed,
        11 => HotelPolicyType.FreeWiFiAvailable,
        12 => HotelPolicyType.PaidWiFiAvailable,
        13 => HotelPolicyType.ParkingAvailable,
        14 => HotelPolicyType.AirportTransferAvailable,
        15 => HotelPolicyType.LaundryServiceAvailable,
        16 => HotelPolicyType.RoomServiceAvailable,
        17 => HotelPolicyType.MiniBarAvailable,
        18 => HotelPolicyType.GymAvailable,
        19 => HotelPolicyType.SpaAvailable,
        20 => HotelPolicyType.PoolAvailable,
        21 => HotelPolicyType.MeetingRoomsAvailable,
        22 => HotelPolicyType.RestaurantAvailable,
        23 => HotelPolicyType.BarAvailable,
        24 => HotelPolicyType.TwentyFourHourFrontDesk,
        25 => HotelPolicyType.BusinessCenterAvailable,
        26 => HotelPolicyType.ChildCareServicesAvailable,
        27 => HotelPolicyType.ConciergeServiceAvailable,
        28 => HotelPolicyType.CurrencyExchangeAvailable,
        29 => HotelPolicyType.DisabilityAccessible,
        30 => HotelPolicyType.ExpressCheckIn,
        31 => HotelPolicyType.ExpressCheckOut,
        32 => HotelPolicyType.IndoorPoolAvailable,
        33 => HotelPolicyType.OutdoorPoolAvailable,
        34 => HotelPolicyType.SaunaAvailable,
        35 => HotelPolicyType.JacuzziAvailable,
        36 => HotelPolicyType.TerraceAvailable,
        37 => HotelPolicyType.GardenAvailable,
        38 => HotelPolicyType.BeachAccessAvailable,
        39 => HotelPolicyType.TennisCourtsAvailable,
        40 => HotelPolicyType.GolfCourseAvailable,
        41 => HotelPolicyType.BikeRentalAvailable,
        42 => HotelPolicyType.CarRentalAvailable,
        43 => HotelPolicyType.ShuttleServiceAvailable,
        44 => HotelPolicyType.BabysittingServicesAvailable,
        45 => HotelPolicyType.LibraryAvailable,
        46 => HotelPolicyType.GameRoomAvailable,
        47 => HotelPolicyType.MovieTheaterAvailable,
        48 => HotelPolicyType.LiveEntertainmentAvailable,
        49 => HotelPolicyType.KaraokeAvailable,
        50 => HotelPolicyType.DanceFloorAvailable,
        51 => HotelPolicyType.IndoorSportsFacilitiesAvailable,
        52 => HotelPolicyType.OutdoorSportsFacilitiesAvailable,
        53 => HotelPolicyType.PetFriendlyRoomsAvailable,
        54 => HotelPolicyType.ChildFriendlyFacilities,
        55 => HotelPolicyType.EcoFriendlyPolicies,
        56 => HotelPolicyType.AllInclusivePackagesAvailable,
        57 => HotelPolicyType.VeganMenuOptionsAvailable,
        58 => HotelPolicyType.HalalMenuOptionsAvailable,
        59 => HotelPolicyType.KosherMenuOptionsAvailable,
        60 => HotelPolicyType.OrganicFoodOptionsAvailable,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid value")
    };

    public bool IsHotelPolicyType => this == GameRoomAvailable || this == HalalMenuOptionsAvailable; //TODO: continue

    public override string ToString() => Name;
}