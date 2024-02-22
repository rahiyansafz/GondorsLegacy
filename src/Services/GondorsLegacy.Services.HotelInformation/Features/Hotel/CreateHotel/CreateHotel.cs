﻿using AutoMapper;
using Castle.DynamicProxy;
using GondorsLegacy.Application.Common.Services;
using GondorsLegacy.CrossCuttingCorners.Caching;
using GondorsLegacy.Infrastructure.Interceptors;
using GondorsLegacy.Infrastructure.Web.MinimalApis;
using GondorsLegacy.Services.HotelInformation.Constants;
using GondorsLegacy.Services.HotelInformation.Models;
using GondorsLegacy.Services.HotelInformation.Validations;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;

namespace GondorsLegacy.Services.HotelInformation.Features.Hotel.CreateHotel;

public class CreateHotelRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string? EmailAddress { get; set; }
    public string? Phone { get; set; }
    public string? Website { get; set; }
}

public class CreateHotelResponse
{
    public Guid HotelId { get; set; }
}

public class CreateHotelCommand : IRequest
{
    public Entities.Hotel Hotel { get; set; }
}

public class CreateHotelCommandHandler : IRequestHandler<CreateHotelCommand>
{
    private readonly ICrudService<Entities.Hotel> _hotelService;
    private readonly ICache _cacheService;
    private readonly ILogger<CreateHotelCommand> _logger;
    private readonly IProxyGenerator _proxyGenerator;
    private readonly LoggingInterceptor _interceptor;

    public CreateHotelCommandHandler(
        ICrudService<Entities.Hotel> hotelService,
        ICache cacheService,
        ILogger<CreateHotelCommand> logger,
        IProxyGenerator proxyGenerator,
        LoggingInterceptor interceptor)
    {
        _hotelService = hotelService;
        _cacheService = cacheService;
        _logger = logger;
        _proxyGenerator = proxyGenerator;
        _interceptor = interceptor;
    }

    public async Task Handle(CreateHotelCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var proxy = _proxyGenerator.CreateInterfaceProxyWithTarget(_hotelService, _interceptor);

            await proxy.AddAsync(request.Hotel);
        }
        catch (Exception ex)
        {
            _logger.LogError($"An error occurred while creating the hotel: {ex.Message}");
            throw new Exception(ex.Message);
        }
    }
}

public class CreateHotelEndpoint : IEndpointHandler
{
    public static void MapEndpoint(IEndpointRouteBuilder builder)
    {
        builder.MapPost("api/v1/hotel/create", HandleAsync)
            .WithName("CreateHotel")
            .Produces<CreateHotelResponse>(statusCode: StatusCodes.Status201Created, contentType: "application/json")
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithOpenApi(operation => new Microsoft.OpenApi.Models.OpenApiOperation
            {
                Tags = new List<OpenApiTag> { new OpenApiTag { Name = "Hotels" } },
                RequestBody = new OpenApiRequestBody
                {
                    Content = new Dictionary<string, OpenApiMediaType>
                    {
                        ["application/json"] = new OpenApiMediaType
                        {
                            Schema = new OpenApiSchema
                            {
                                Reference = new OpenApiReference
                                    { Type = ReferenceType.Schema, Id = "CreateHotelRequest" }
                            }
                        }
                    },
                    Required = true
                }
            });
    }

    private static async Task<IResult> HandleAsync(IMediator dispatcher, [FromBody] CreateHotelRequest request,
        IMapper mapper)
    {
        try
        {
            var hotel = mapper.Map<Entities.Hotel>(request);

            var validator = new HotelValidator();

            var result = validator.Validate(hotel);

            if (result.IsValid)
            {
                await dispatcher.Send(new CreateHotelCommand { Hotel = hotel });

                var response = new SuccessResponseModel
                {
                    StatusCode = StatusCodes.Status201Created,
                    Message = Messages.HotelAddedSuccessfully,
                    Data = new CreateHotelResponse
                    {
                        HotelId = hotel.Id,
                    }
                };

                return Results.Created($"api/v1/hotel/{response.Data}", response);
            }
            else
            {
                var errorDetails = new ErrorResponseModel
                {
                    StatusCode = StatusCodes.Status400BadRequest,
                    Message = Messages.InvalidHotelRequestMessage,
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