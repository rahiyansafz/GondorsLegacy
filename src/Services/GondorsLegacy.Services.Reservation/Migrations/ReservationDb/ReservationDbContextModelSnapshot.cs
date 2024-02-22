﻿// <auto-generated />
using System;
using GondorsLegacy.Services.Reservation.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GondorsLegacy.Services.Reservation.Migrations.ReservationDb
{
    [DbContext(typeof(ReservationDbContext))]
    partial class ReservationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GondorsLegacy.Services.Reservation.Entities.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CancellationReason")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsReservationCancelled")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfAdults")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfChildren")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfGuests")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<int>("ReservationStatus")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("SpecialRequests")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("Reservations", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b4dc50fa-add7-4c3f-b927-4fd5e3090f03"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 21, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9810),
                            CheckOutDate = new DateTime(2023, 10, 29, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9840),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "yasin.salvator@gmail.com",
                            CustomerFirstName = "Yasin Çınar",
                            CustomerId = new Guid("ff4f4d78-e72c-49b8-993d-24be40eb6aa3"),
                            CustomerLastName = "SALVATOR",
                            HotelId = new Guid("bc8034a7-c718-4b69-98f0-4fa80c304886"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 2,
                            NumberOfChildren = 0,
                            NumberOfGuests = 2,
                            PaymentStatus = 0,
                            ReservationStatus = 0,
                            RoomNumber = 501,
                            RoomType = 1,
                            SpecialRequests = "Internet mutlaka olmalıdır!",
                            TotalPrice = 17500.12m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("057611d0-10ca-4505-b1bd-ff477deb451d"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 22, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9860),
                            CheckOutDate = new DateTime(2023, 10, 25, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9860),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "ahmet.cakar@gmail.com",
                            CustomerFirstName = "Ahmet ASLAN ",
                            CustomerId = new Guid("282ced65-8138-428e-b6af-f6b9498c4ca8"),
                            CustomerLastName = "ÇAKAR",
                            HotelId = new Guid("d5b0f772-bea2-406f-8417-182f4f3881ea"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 2,
                            NumberOfChildren = 1,
                            NumberOfGuests = 3,
                            PaymentStatus = 1,
                            ReservationStatus = 1,
                            RoomNumber = 502,
                            RoomType = 2,
                            SpecialRequests = "Çocuğum için klozete basamak koyulabilir mi?",
                            TotalPrice = 21500.00m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("e452ccbf-0e0b-427e-80f5-618775536521"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 11, 2, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9870),
                            CheckOutDate = new DateTime(2023, 11, 7, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9870),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "ahmet.cakar@gmail.com",
                            CustomerFirstName = "Sibel",
                            CustomerId = new Guid("0cf04832-aafd-443b-b8c7-f4e306c5ffcc"),
                            CustomerLastName = "SAĞLAM",
                            HotelId = new Guid("beb6ddc5-7dd4-4113-bd8c-7a921ccf8147"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 1,
                            NumberOfChildren = 0,
                            NumberOfGuests = 1,
                            PaymentStatus = 0,
                            ReservationStatus = 0,
                            RoomNumber = 503,
                            RoomType = 0,
                            SpecialRequests = "Sigara kullanılmayan oda olsun.",
                            TotalPrice = 1500.00m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("bde393d3-1bba-433f-8926-52b1d34f783a"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 22, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9880),
                            CheckOutDate = new DateTime(2023, 10, 24, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9880),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "john.doe@example.com",
                            CustomerFirstName = "John Doe",
                            CustomerId = new Guid("8b36aa79-2bcd-4f0b-8c45-7bb645db66de"),
                            CustomerLastName = "Doe",
                            HotelId = new Guid("c15fe9db-9d68-4ff7-bc3b-856dbebaf342"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 1,
                            NumberOfChildren = 0,
                            NumberOfGuests = 1,
                            PaymentStatus = 0,
                            ReservationStatus = 0,
                            RoomNumber = 101,
                            RoomType = 0,
                            SpecialRequests = "Need a quiet room.",
                            TotalPrice = 8000.50m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("3b82150a-8076-4457-9e22-9571a092f824"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 22, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9890),
                            CheckOutDate = new DateTime(2023, 10, 28, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9890),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "jane.doe@example.com",
                            CustomerFirstName = "Jane Doe",
                            CustomerId = new Guid("20a6f274-1022-454b-9c7e-47cb88136bc6"),
                            CustomerLastName = "Doe",
                            HotelId = new Guid("e814fc57-b888-478a-99d3-b9dc31f7de08"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 2,
                            NumberOfChildren = 0,
                            NumberOfGuests = 2,
                            PaymentStatus = 0,
                            ReservationStatus = 0,
                            RoomNumber = 502,
                            RoomType = 1,
                            SpecialRequests = "Need a room with a view.",
                            TotalPrice = 22000.00m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("0109bd61-0fc2-466b-a32c-206fe7f3956f"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 23, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9910),
                            CheckOutDate = new DateTime(2023, 10, 26, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9910),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "peter.parker@example.com",
                            CustomerFirstName = "Peter Parker",
                            CustomerId = new Guid("2144bf0e-c462-4278-959c-c4801fe9d584"),
                            CustomerLastName = "Parker",
                            HotelId = new Guid("69a019e9-dc9a-4fde-a082-2bb09db41603"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 2,
                            NumberOfChildren = 2,
                            NumberOfGuests = 4,
                            PaymentStatus = 1,
                            ReservationStatus = 1,
                            RoomNumber = 603,
                            RoomType = 2,
                            SpecialRequests = "Need a room with two double beds.",
                            TotalPrice = 35000.75m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("7285e556-c91b-4ba4-9520-82cd404748fc"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 24, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9920),
                            CheckOutDate = new DateTime(2023, 10, 26, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9920),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "ali.yilmaz@example.com",
                            CustomerFirstName = "Ali Yılmaz",
                            CustomerId = new Guid("f6b8e0c5-baf5-469b-b55f-e187626a1e37"),
                            CustomerLastName = "Yılmaz",
                            HotelId = new Guid("e779aafb-7147-495c-a8ce-1f9102a58f88"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 2,
                            NumberOfChildren = 1,
                            NumberOfGuests = 3,
                            PaymentStatus = 2,
                            ReservationStatus = 2,
                            RoomNumber = 701,
                            RoomType = 2,
                            SpecialRequests = "Need a room with a balcony.",
                            TotalPrice = 45000.00m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("88aaed72-2670-4da0-b701-4d8dbb4c6cef"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 27, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9930),
                            CheckOutDate = new DateTime(2023, 10, 30, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9930),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "aysegul.aktas@example.com",
                            CustomerFirstName = "Ayşegül Aktaş",
                            CustomerId = new Guid("4a9f08d0-f3c0-4feb-ace4-cf6baaeacd4f"),
                            CustomerLastName = "Aktaş",
                            HotelId = new Guid("fa0f16ff-c2ba-4513-9c52-991e6b7a4127"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 1,
                            NumberOfChildren = 0,
                            NumberOfGuests = 1,
                            PaymentStatus = 0,
                            ReservationStatus = 0,
                            RoomNumber = 201,
                            RoomType = 0,
                            SpecialRequests = "Need a room with a wheelchair accessible bathroom.",
                            TotalPrice = 10000.00m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("6dcc23e4-d3a6-4178-a882-d8862dbba3b7"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 28, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9940),
                            CheckOutDate = new DateTime(2023, 10, 31, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9940),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "mehmet.ozdemir@example.com",
                            CustomerFirstName = "Mehmet Özdemir",
                            CustomerId = new Guid("5fa55ca6-4a7b-49be-abc4-c22f1a9d1be3"),
                            CustomerLastName = "Özdemir",
                            HotelId = new Guid("4de693df-ef3a-4936-a973-cdcb976d8a69"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 2,
                            NumberOfChildren = 0,
                            NumberOfGuests = 2,
                            PaymentStatus = 0,
                            ReservationStatus = 0,
                            RoomNumber = 402,
                            RoomType = 1,
                            SpecialRequests = "Need a room with a king-sized bed.",
                            TotalPrice = 25000.00m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("eb71c04b-11e8-404c-ae6f-3f404be81dfb"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 22, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9950),
                            CheckOutDate = new DateTime(2023, 10, 24, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9950),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "john.doe@example.com",
                            CustomerFirstName = "John Doe",
                            CustomerId = new Guid("9061dc28-e587-4bdd-9126-d830a0627907"),
                            CustomerLastName = "Doe",
                            HotelId = new Guid("b9baaa59-a96e-4381-b07a-e7d271d43524"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 1,
                            NumberOfChildren = 0,
                            NumberOfGuests = 1,
                            PaymentStatus = 1,
                            ReservationStatus = 1,
                            RoomNumber = 101,
                            RoomType = 0,
                            SpecialRequests = "Need a quiet room.",
                            TotalPrice = 8000.50m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("c85bef17-31e3-486c-bfaa-6c7c3d87dd9e"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 22, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9980),
                            CheckOutDate = new DateTime(2023, 10, 28, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9980),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "jane.doe@example.com",
                            CustomerFirstName = "Jane Doe",
                            CustomerId = new Guid("fdf2e3a5-8b8a-422e-9142-c9695170d390"),
                            CustomerLastName = "Doe",
                            HotelId = new Guid("aa137bfe-289c-49e1-abe0-d3e247a91f00"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 2,
                            NumberOfChildren = 0,
                            NumberOfGuests = 2,
                            PaymentStatus = 0,
                            ReservationStatus = 0,
                            RoomNumber = 502,
                            RoomType = 1,
                            SpecialRequests = "Need a room with a view.",
                            TotalPrice = 22000.00m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("46dbf404-62eb-4a08-a8ca-f142396c7d3b"),
                            CancellationReason = 0,
                            CheckInDate = new DateTime(2023, 10, 23, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9990),
                            CheckOutDate = new DateTime(2023, 10, 26, 15, 52, 25, 544, DateTimeKind.Local).AddTicks(9990),
                            CreatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            CustomerEmail = "peter.parker@example.com",
                            CustomerFirstName = "Peter Parker",
                            CustomerId = new Guid("81a44440-5b8f-4b48-bb97-d0d63041cd40"),
                            CustomerLastName = "Parker",
                            HotelId = new Guid("13b8c194-b5f9-4f1a-8acd-55dbf597c6f3"),
                            HotelName = "Hilton Otel",
                            IsReservationCancelled = false,
                            NumberOfAdults = 2,
                            NumberOfChildren = 2,
                            NumberOfGuests = 4,
                            PaymentStatus = 1,
                            ReservationStatus = 1,
                            RoomNumber = 603,
                            RoomType = 2,
                            SpecialRequests = "Need a room with two double beds.",
                            TotalPrice = 35000.75m,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0))
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
