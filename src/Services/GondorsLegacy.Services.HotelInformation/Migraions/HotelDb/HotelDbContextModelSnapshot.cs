﻿// <auto-generated />
using System;
using GondorsLegacy.Services.HotelInformation.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GondorsLegacy.Services.HotelInformation.Migraions.HotelDb
{
    [DbContext(typeof(HotelDbContext))]
    partial class HotelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApartmentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsSecure")
                        .HasColumnType("bit");

                    b.Property<string>("Labels")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Neighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POBox")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Addresses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3e97bd4c-6762-41e7-8595-6c79a5d91a19"),
                            AdditionalInfo = "NULL",
                            ApartmentNumber = "5",
                            BuildingNumber = "9",
                            City = "İstanbul",
                            Country = "Türkiye",
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 878, DateTimeKind.Unspecified).AddTicks(2798), new TimeSpan(0, 3, 0, 0, 0)),
                            District = "Gaziosmanpaşa",
                            Floor = "1",
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            IsSecure = true,
                            Labels = "Özel Mülk",
                            Latitude = 34.100000000000001,
                            Longitude = 41.5,
                            Neighborhood = "Yenidoğan",
                            POBox = "34100",
                            PostCode = "34100",
                            Province = "İstanbul",
                            SecurityCode = "f4e465s1",
                            Street = "Kuyu",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 878, DateTimeKind.Unspecified).AddTicks(2862), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 878, DateTimeKind.Unspecified).AddTicks(8485), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "Açıklama",
                            EmailAddress = "info@salvatorresort.com",
                            Name = "SALVATOR RESORT HOTEL",
                            Phone = "05303288200",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 878, DateTimeKind.Unspecified).AddTicks(8502), new TimeSpan(0, 3, 0, 0, 0)),
                            Website = "https://www.salvatorresort.com"
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelCustomerReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Dislikes")
                        .HasColumnType("int");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsHelpful")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRecommended")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVerified")
                        .HasColumnType("bit");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelCustomerReviews", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("5aa381c7-7dab-4c81-a8d0-6c517ded8318"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(773), new TimeSpan(0, 3, 0, 0, 0)),
                            CustomerId = new Guid("efb1421d-65e7-4eda-bc9d-b6080420ba17"),
                            Dislikes = 10,
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            IsHelpful = true,
                            IsRecommended = true,
                            IsVerified = true,
                            Likes = 10,
                            ReviewDate = new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Local).AddTicks(797),
                            ReviewText = "Bu otele bayıldım",
                            ReviewTitle = "Bu otele bayıldım!",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(799), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("0230c9ac-c9fa-4d09-bf58-03979355604e"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(823), new TimeSpan(0, 3, 0, 0, 0)),
                            CustomerId = new Guid("e1e1af7b-01f0-4dc3-95a1-dd6873bf3dd7"),
                            Dislikes = 12,
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            IsHelpful = true,
                            IsRecommended = true,
                            IsVerified = true,
                            Likes = 17,
                            ReviewDate = new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Local).AddTicks(825),
                            ReviewText = "Bu otele güzeldi",
                            ReviewTitle = "Bu otel güzeldi!",
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(827), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelPolicy", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HotelPolicyType")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelPolicies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1388b190-db9f-47ec-9ab4-8ff9438ca309"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(3047), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelPolicyType = 13,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(3060), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("49909ea1-1cb9-4535-893d-0f96d05dea03"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(3067), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelPolicyType = 55,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(3069), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("a04bcb45-5327-4533-b9c5-d035d1188608"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(3073), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelPolicyType = 43,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(3074), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("41341e7b-c984-435b-b607-69877b6a7990"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(3078), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelPolicyType = 22,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(3079), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelRating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Amenities")
                        .HasColumnType("real");

                    b.Property<float>("Cleanliness")
                        .HasColumnType("real");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Location")
                        .HasColumnType("real");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<float>("ServiceQuality")
                        .HasColumnType("real");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<float>("ValueForMoney")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelRatings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("91a7887a-4318-4a0a-be4c-55248609e4d6"),
                            Amenities = 10f,
                            Cleanliness = 10f,
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(4909), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "NULL",
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            Location = 10f,
                            ServiceQuality = 10f,
                            Stars = 5,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(4921), new TimeSpan(0, 3, 0, 0, 0)),
                            ValueForMoney = 10f
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelRoom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RoomType")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelRooms", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("260e469a-b87f-49e5-8ac8-c36716521552"),
                            Capacity = 50,
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(6411), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            RoomType = 0,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(6428), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("88f4520b-9c57-4e55-9654-107b926b214b"),
                            Capacity = 75,
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(6431), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            RoomType = 3,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(6434), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("69e60e50-08bf-4bdc-95fc-fce558a0ea60"),
                            Capacity = 80,
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(6445), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            RoomType = 5,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(6447), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelService", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HotelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HotelServiceType")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTimeOffset>("UpdatedDateTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelServices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("86aa2b6a-329e-4ddf-a2db-21f8f6932fa6"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(7978), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 74,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(7988), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("58d6d610-424c-4df1-bda0-02848857920d"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(7999), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 51,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(8001), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("0097bc87-0623-461f-9479-7b96975fdbc9"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(8007), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 33,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(8009), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("5a7ec8e3-a70a-4058-861c-4457e3e54380"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(8013), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 8,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(8014), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = new Guid("442d1a17-b52d-4226-8c95-5052ce4a51af"),
                            CreatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(8018), new TimeSpan(0, 3, 0, 0, 0)),
                            HotelId = new Guid("459f9270-9f33-488b-a6d6-0b441697c50c"),
                            HotelServiceType = 72,
                            UpdatedDateTime = new DateTimeOffset(new DateTime(2024, 2, 11, 19, 49, 54, 879, DateTimeKind.Unspecified).AddTicks(8019), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Address", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("Addresses")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelCustomerReview", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("HotelCustomerReviews")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelPolicy", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("Policies")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelRating", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("HotelRatings")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelRoom", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.HotelService", b =>
                {
                    b.HasOne("GondorsLegacy.Services.HotelInformation.Entities.Hotel", null)
                        .WithMany("Services")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GondorsLegacy.Services.HotelInformation.Entities.Hotel", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("HotelCustomerReviews");

                    b.Navigation("HotelRatings");

                    b.Navigation("Policies");

                    b.Navigation("Rooms");

                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}