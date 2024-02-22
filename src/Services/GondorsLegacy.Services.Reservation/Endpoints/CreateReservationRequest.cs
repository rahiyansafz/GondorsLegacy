using Asp.Versioning.Builder;
using Asp.Versioning;
using AutoMapper;
using GondorsLegacy.Infrastructure.Web.MinimalApis;
using GondorsLegacy.Services.Reservation.Commands;
using GondorsLegacy.Services.Reservation.Constants;
using GondorsLegacy.Services.Reservation.Entities;
using GondorsLegacy.Services.Reservation.Models;
using GondorsLegacy.Services.Reservation.Validations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace GondorsLegacy.Services.Reservation.Endpoints;

public class CreateReservationRequest
{
    public Guid CustomerId { get; set; }
    public string CustomerFirstName { get; set; }
    public string CustomerLastName { get; set; }
    public Guid HotelId { get; set; }
    public string HotelName { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public RoomType RoomType { get; set; }
    public string RoomNumber { get; set; }
    public decimal TotalPrice { get; set; }
    public int NumberOfGuests { get; set; }
    public string CustomerEmail { get; set; }
    public ReservationStatus ReservationStatus { get; set; }
    public string PaymentInformation { get; set; }
    public string SpecialRequests { get; set; }
    public int NumberOfAdults { get; set; }
    public int NumberOfChildren { get; set; }
    public PaymentStatus PaymentStatus { get; set; }
}

public class CreateReservationResponse
{
    public Guid ReservationId { get; set; }
}

public class CreateReservationRequestHandler : IEndpointHandler
{
    public static void MapEndpoint(IEndpointRouteBuilder builder)
    {
        ApiVersionSet apiVersionSet = builder.NewApiVersionSet()
            .HasApiVersion(new ApiVersion(1))
            .HasApiVersion(new ApiVersion(2))
            .ReportApiVersions()
            .Build();

        builder.MapPost("api/v{version:apiVersion}/reservation/create", HandleAsync)
            .WithName("CreateReservation")
            .Produces<CreateReservationResponse>(statusCode: StatusCodes.Status201Created,
                contentType: "application/json")
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithOpenApi(operation => new Microsoft.OpenApi.Models.OpenApiOperation
            {
                Tags = new List<OpenApiTag> { new OpenApiTag { Name = "Reservations" } },
                RequestBody = new OpenApiRequestBody
                {
                    Content = new Dictionary<string, OpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema
                            {
                                Reference = new OpenApiReference
                                    { Type = ReferenceType.Schema, Id = "CreateReservationRequest" }
                            }
                        }
                    },
                    Required = true
                }
            }).WithApiVersionSet(apiVersionSet).MapToApiVersion(1);
    }

    private static async Task<IResult> HandleAsync(IMediator dispatcher, [FromBody] CreateReservationRequest request,
        IMapper mapper)
    {
        try
        {
            var reservation = mapper.Map<Entities.Reservation>(request);

            var validator = new ReservationValidator();

            var result = validator.Validate(reservation);

            if (result.IsValid)
            {
                await dispatcher.Send(new CreateReservationCommand { Reservation = reservation });

                var response = new CreateReservationResponse
                {
                    ReservationId = reservation.Id
                };

                return Results.Created($"api/v{{version:apiVersion}}/reservations/{response.ReservationId}", response);
            }
            else
            {
                var errorDetails = new ErrorResponseModel
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    Message = Messages.InvalidReservationRequestMessage,
                    ErrorDetails = result.Errors.Select(error => error.ErrorMessage).ToList()
                };

                return Results.BadRequest(error: errorDetails);
            }
        }
        catch (Exception ex)
        {
            var errorResponse = new ErrorResponseModel
            {
                StatusCode = StatusCodes.Status400BadRequest,
                Message = Messages.DefaultErrorMessage,
                ErrorDetails = new List<string> { ex.Message }
            };

            return Results.BadRequest();
        }
    }
}