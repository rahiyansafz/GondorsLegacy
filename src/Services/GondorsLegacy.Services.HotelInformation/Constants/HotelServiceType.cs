﻿namespace GondorsLegacy.Services.HotelInformation.Constants;

public record HotelServiceType(int Value, string Name)
{
    public static HotelServiceType None { get; } = new HotelServiceType(1, "Hiçbiri");
    public static HotelServiceType Restaurant { get; } = new HotelServiceType(2, "Restoran");
    public static HotelServiceType Spa { get; } = new HotelServiceType(3, "Spa");
    public static HotelServiceType Gym { get; } = new HotelServiceType(4, "Spor Salonu");
    public static HotelServiceType Pool { get; } = new HotelServiceType(5, "Havuz");
    public static HotelServiceType RoomService { get; } = new HotelServiceType(6, "Oda Servisi");
    public static HotelServiceType WiFi { get; } = new HotelServiceType(7, "Wi-Fi Erişimi");
    public static HotelServiceType Parking { get; } = new HotelServiceType(8, "Otopark");
    public static HotelServiceType AirportTransfer { get; } = new HotelServiceType(9, "Havaalanı Transferi");
    public static HotelServiceType LaundryService { get; } = new HotelServiceType(10, "Çamaşırhane Hizmeti");
    public static HotelServiceType MiniBar { get; } = new HotelServiceType(11, "Minibar");
    public static HotelServiceType MeetingRoom { get; } = new HotelServiceType(12, "Toplantı Salonu");
    public static HotelServiceType Concierge { get; } = new HotelServiceType(13, "Concierge Hizmeti");
    public static HotelServiceType TwentyFourHourReception { get; } = new HotelServiceType(14, "24 Saat Resepsiyon");
    public static HotelServiceType BusinessCenter { get; } = new HotelServiceType(15, "İş Merkezi");
    public static HotelServiceType ValetParking { get; } = new HotelServiceType(16, "Vale Park Hizmeti");
    public static HotelServiceType Babysitting { get; } = new HotelServiceType(17, "Bebek Bakıcılığı");
    public static HotelServiceType CurrencyExchange { get; } = new HotelServiceType(18, "Döviz Bürosu");
    public static HotelServiceType FitnessCenter { get; } = new HotelServiceType(19, "Fitness Merkezi");
    public static HotelServiceType KidsClub { get; } = new HotelServiceType(20, "Çocuk Kulübü");
    public static HotelServiceType Library { get; } = new HotelServiceType(21, "Kütüphane");
    public static HotelServiceType Nightclub { get; } = new HotelServiceType(22, "Gece Kulübü");
    public static HotelServiceType PetFriendly { get; } = new HotelServiceType(23, "Evcil Hayvan Dostu");
    public static HotelServiceType ShuttleService { get; } = new HotelServiceType(24, "Servis Hizmeti");
    public static HotelServiceType SmokingArea { get; } = new HotelServiceType(25, "Sigara İçme Alanı");
    public static HotelServiceType Terrace { get; } = new HotelServiceType(26, "Teras");
    public static HotelServiceType Garden { get; } = new HotelServiceType(27, "Bahçe");
    public static HotelServiceType BeachAccess { get; } = new HotelServiceType(28, "Plaj Erişimi");
    public static HotelServiceType SkiStorage { get; } = new HotelServiceType(29, "Kayak Ekipmanı Depolama");
    public static HotelServiceType TennisCourt { get; } = new HotelServiceType(30, "Tenis Kortu");
    public static HotelServiceType WaterPark { get; } = new HotelServiceType(31, "Su Parkı");
    public static HotelServiceType BicycleRental { get; } = new HotelServiceType(32, "Bisiklet Kiralama");
    public static HotelServiceType CarRental { get; } = new HotelServiceType(33, "Araç Kiralama");
    public static HotelServiceType AirportShuttle { get; } = new HotelServiceType(34, "Havaalanı Servisi");
    public static HotelServiceType ShuttleToSkiLift { get; } = new HotelServiceType(35, "Kayak Asansörü Servisi");
    public static HotelServiceType Casino { get; } = new HotelServiceType(36, "Kumarhane");
    public static HotelServiceType GolfCourse { get; } = new HotelServiceType(37, "Golf Sahası");
    public static HotelServiceType HikingTrails { get; } = new HotelServiceType(38, "Doğa Yürüyüş Yolları");
    public static HotelServiceType HorseRiding { get; } = new HotelServiceType(39, "At Binme");
    public static HotelServiceType SkiInSkiOut { get; } = new HotelServiceType(40, "Kayak Merkezine Ulaşım");
    public static HotelServiceType WaterSportEquipment { get; } = new HotelServiceType(41, "Su Sporu Ekipmanları");
    public static HotelServiceType YogaClasses { get; } = new HotelServiceType(42, "Yoga Dersleri");
    public static HotelServiceType BeautySalon { get; } = new HotelServiceType(43, "Güzellik Salonu");
    public static HotelServiceType MedicalAssistance { get; } = new HotelServiceType(44, "Tıbbi Yardım");
    public static HotelServiceType Ballroom { get; } = new HotelServiceType(45, "Balo Salonu");
    public static HotelServiceType GiftShop { get; } = new HotelServiceType(46, "Hediyelik Eşya Mağazası");
    public static HotelServiceType Chapel { get; } = new HotelServiceType(47, "Şapel");
    public static HotelServiceType WeddingServices { get; } = new HotelServiceType(48, "Düğün Hizmetleri");
    public static HotelServiceType LimousineService { get; } = new HotelServiceType(49, "Limuzin Hizmeti");
    public static HotelServiceType DryCleaning { get; } = new HotelServiceType(50, "Kuru Temizleme");
    public static HotelServiceType ATM { get; } = new HotelServiceType(51, "ATM");
    public static HotelServiceType AirportLounges { get; } = new HotelServiceType(52, "Havaalanı Salonları");
    public static HotelServiceType ExpressCheckInCheckOut { get; } = new HotelServiceType(53, "Hızlı Giriş/Çıkış");
    public static HotelServiceType BuffetBreakfast { get; } = new HotelServiceType(54, "Büfe Kahvaltı");
    public static HotelServiceType LuggageStorage { get; } = new HotelServiceType(55, "Bagaj Depolama");
    public static HotelServiceType Elevator { get; } = new HotelServiceType(56, "Asansör");
    public static HotelServiceType Fireplace { get; } = new HotelServiceType(57, "Şömine");
    public static HotelServiceType BeachTowels { get; } = new HotelServiceType(58, "Plaj Havluları");
    public static HotelServiceType SunTerrace { get; } = new HotelServiceType(59, "Güneş Terası");
    public static HotelServiceType BBQFacilities { get; } = new HotelServiceType(60, "Barbekü Alanı");
    public static HotelServiceType SharedLoungeTVArea { get; } = new HotelServiceType(61, "Ortak TV Alanı");
    public static HotelServiceType TwentyFourHourSecurity { get; } = new HotelServiceType(62, "24 Saat Güvenlik");
    public static HotelServiceType BicycleParking { get; } = new HotelServiceType(63, "Bisiklet Parkı");
    public static HotelServiceType PicnicArea { get; } = new HotelServiceType(64, "Piknik Alanı");

    public static HotelServiceType DesignatedSmokingArea { get; } =
        new HotelServiceType(65, "Belirlenen Sigara İçme Alanı");

    public static HotelServiceType FirstAidKit { get; } = new HotelServiceType(66, "İlk Yardım Kiti");
    public static HotelServiceType FireExtinguishers { get; } = new HotelServiceType(67, "Yangın Söndürücüler");
    public static HotelServiceType SecurityAlarm { get; } = new HotelServiceType(68, "Güvenlik Alarmı");
    public static HotelServiceType CCTVSecurity { get; } = new HotelServiceType(69, "CCTV Güvenlik");
    public static HotelServiceType SmokeAlarms { get; } = new HotelServiceType(70, "Duman Dedektörleri");
    public static HotelServiceType KeyCardAccess { get; } = new HotelServiceType(71, "Anahtar Kart Erişimi");
    public static HotelServiceType WheelchairAccess { get; } = new HotelServiceType(72, "Tekerlekli Sandalye Erişimi");
    public static HotelServiceType AssistanceForDisabled { get; } = new HotelServiceType(73, "Engellilere Yardım");
    public static HotelServiceType SoundproofRooms { get; } = new HotelServiceType(74, "Ses Yalıtımlı Odalar");
    public static HotelServiceType AirConditioning { get; } = new HotelServiceType(75, "Klima");
    public static HotelServiceType Heating { get; } = new HotelServiceType(76, "Isıtma");
    public static HotelServiceType FamilyRooms { get; } = new HotelServiceType(77, "Aile Odaları");
    public static HotelServiceType NonSmokingRooms { get; } = new HotelServiceType(78, "Sigara İçilmeyen Odalar");
    public static HotelServiceType PetBowls { get; } = new HotelServiceType(79, "Evcil Hayvan Kapları");
    public static HotelServiceType PetBasket { get; } = new HotelServiceType(80, "Evcil Hayvan Sepeti");
    public static HotelServiceType PetCushion { get; } = new HotelServiceType(81, "Evcil Hayvan Yastığı");
    public static HotelServiceType PetClothing { get; } = new HotelServiceType(82, "Evcil Hayvan Kıyafeti");
    public static HotelServiceType PetToy { get; } = new HotelServiceType(83, "Evcil Hayvan Oyuncağı");
    public static HotelServiceType PetLeash { get; } = new HotelServiceType(84, "Evcil Hayvan Gezdirme Kayışı");
    public static HotelServiceType PetHarness { get; } = new HotelServiceType(85, "Evcil Hayvan Gezdirme Harnı");
    public static HotelServiceType PetCollar { get; } = new HotelServiceType(86, "Evcil Hayvan Gezdirme Tasma");
    public static HotelServiceType PetHeater { get; } = new HotelServiceType(87, "Evcil Hayvan Gezdirme Isıtıcılar");

    public static HotelServiceType PetReflector { get; } =
        new HotelServiceType(88, "Evcil Hayvan Gezdirme Reflektörler");

    public static HotelServiceType PetEquipment { get; } =
        new HotelServiceType(89, "Evcil Hayvan Gezdirme Ekipmanları");

    public static HotelServiceType PetNecklace { get; } = new HotelServiceType(90, "Evcil Hayvan Gezdirme Yaka");

    public static HotelServiceType PetDogHarness { get; } =
        new HotelServiceType(91, "Evcil Hayvan Gezdirme Köpek Harnası");

    public static HotelServiceType PetCatLeash { get; } = new HotelServiceType(92, "Evcil Hayvan Gezdirme Kedi Tasma");

    public static HotelServiceType PetBackpack { get; } =
        new HotelServiceType(93, "Evcil Hayvan Gezdirme Sırt Çantası");

    public static HotelServiceType PetMat { get; } = new HotelServiceType(94, "Evcil Hayvan Gezdirme Pet Minderi");

    public static HotelServiceType PetCollarCamera { get; } =
        new HotelServiceType(95, "Evcil Hayvan Gezdirme Yaka Kamera");

    public static HotelServiceType PetBelt { get; } = new HotelServiceType(96, "Evcil Hayvan Gezdirme Kemeri");
    public static HotelServiceType PetBoots { get; } = new HotelServiceType(97, "Evcil Hayvan Gezdirme Botları");
    public static HotelServiceType PetCarrier { get; } = new HotelServiceType(98, "Evcil Hayvan Gezdirme Taşıyıcılar");
    public static HotelServiceType PetBag { get; } = new HotelServiceType(99, "Evcil Hayvan Gezdirme Çantası");
    public static HotelServiceType PetCamera { get; } = new HotelServiceType(100, "Evcil Hayvan Gezdirme Kamerası");

    public static implicit operator int(HotelServiceType hotelPolicyType) => hotelPolicyType.Value;

    public static implicit operator HotelServiceType(int value) => value switch
    {
        1 => HotelServiceType.None,
        2 => HotelServiceType.Restaurant,
        3 => HotelServiceType.Spa,
        4 => HotelServiceType.Gym,
        5 => HotelServiceType.Pool,
        6 => HotelServiceType.RoomService,
        7 => HotelServiceType.WiFi,
        8 => HotelServiceType.Parking,
        9 => HotelServiceType.AirportTransfer,
        10 => HotelServiceType.LaundryService,
        11 => HotelServiceType.MiniBar,
        12 => HotelServiceType.MeetingRoom,
        13 => HotelServiceType.Concierge,
        14 => HotelServiceType.TwentyFourHourReception,
        15 => HotelServiceType.BusinessCenter,
        16 => HotelServiceType.ValetParking,
        17 => HotelServiceType.Babysitting,
        18 => HotelServiceType.CurrencyExchange,
        19 => HotelServiceType.FitnessCenter,
        20 => HotelServiceType.KidsClub,
        21 => HotelServiceType.Library,
        22 => HotelServiceType.Nightclub,
        23 => HotelServiceType.PetFriendly,
        24 => HotelServiceType.ShuttleService,
        25 => HotelServiceType.SmokingArea,
        26 => HotelServiceType.Terrace,
        27 => HotelServiceType.Garden,
        28 => HotelServiceType.BeachAccess,
        29 => HotelServiceType.SkiStorage,
        30 => HotelServiceType.TennisCourt,
        31 => HotelServiceType.WaterPark,
        32 => HotelServiceType.BicycleRental,
        33 => HotelServiceType.CarRental,
        34 => HotelServiceType.AirportShuttle,
        35 => HotelServiceType.ShuttleToSkiLift,
        36 => HotelServiceType.Casino,
        37 => HotelServiceType.GolfCourse,
        38 => HotelServiceType.HikingTrails,
        39 => HotelServiceType.HorseRiding,
        40 => HotelServiceType.SkiInSkiOut,
        41 => HotelServiceType.WaterSportEquipment,
        42 => HotelServiceType.YogaClasses,
        43 => HotelServiceType.BeautySalon,
        44 => HotelServiceType.MedicalAssistance,
        45 => HotelServiceType.Ballroom,
        46 => HotelServiceType.GiftShop,
        47 => HotelServiceType.Chapel,
        48 => HotelServiceType.WeddingServices,
        49 => HotelServiceType.LimousineService,
        50 => HotelServiceType.DryCleaning,
        51 => HotelServiceType.ATM,
        52 => HotelServiceType.AirportLounges,
        53 => HotelServiceType.ExpressCheckInCheckOut,
        54 => HotelServiceType.BuffetBreakfast,
        55 => HotelServiceType.LuggageStorage,
        56 => HotelServiceType.Elevator,
        57 => HotelServiceType.Fireplace,
        58 => HotelServiceType.BeachTowels,
        59 => HotelServiceType.SunTerrace,
        60 => HotelServiceType.BBQFacilities,
        61 => HotelServiceType.SharedLoungeTVArea,
        62 => HotelServiceType.TwentyFourHourSecurity,
        63 => HotelServiceType.BicycleParking,
        64 => HotelServiceType.PicnicArea,
        65 => HotelServiceType.DesignatedSmokingArea,
        66 => HotelServiceType.FirstAidKit,
        67 => HotelServiceType.FireExtinguishers,
        68 => HotelServiceType.SecurityAlarm,
        69 => HotelServiceType.CCTVSecurity,
        70 => HotelServiceType.SmokeAlarms,
        71 => HotelServiceType.KeyCardAccess,
        72 => HotelServiceType.WheelchairAccess,
        73 => HotelServiceType.AssistanceForDisabled,
        74 => HotelServiceType.SoundproofRooms,
        75 => HotelServiceType.AirConditioning,
        76 => HotelServiceType.Heating,
        77 => HotelServiceType.FamilyRooms,
        78 => HotelServiceType.NonSmokingRooms,
        79 => HotelServiceType.PetBowls,
        80 => HotelServiceType.PetBasket,
        81 => HotelServiceType.PetCushion,
        82 => HotelServiceType.PetClothing,
        83 => HotelServiceType.PetToy,
        84 => HotelServiceType.PetLeash,
        85 => HotelServiceType.PetHarness,
        86 => HotelServiceType.PetCollar,
        87 => HotelServiceType.PetHeater,
        88 => HotelServiceType.PetReflector,
        89 => HotelServiceType.PetEquipment,
        90 => HotelServiceType.PetNecklace,
        91 => HotelServiceType.PetDogHarness,
        92 => HotelServiceType.PetCatLeash,
        93 => HotelServiceType.PetBackpack,
        94 => HotelServiceType.PetMat,
        95 => HotelServiceType.PetCollarCamera,
        96 => HotelServiceType.PetBelt,
        97 => HotelServiceType.PetBoots,
        98 => HotelServiceType.PetCarrier,
        99 => HotelServiceType.PetBag,
        100 => HotelServiceType.PetCamera,
        _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Invalid value")
    };
}