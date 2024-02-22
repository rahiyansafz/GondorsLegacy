﻿using MediatR;

namespace GondorsLegacy.Services.HotelInformation.Features.Hotel.GetHotel;

public class GetHotelQuery : IRequest<Entities.Hotel>
{
    public Guid Id { get; set; }
    public bool ThrowNotFoundIfNull { get; set; }
}