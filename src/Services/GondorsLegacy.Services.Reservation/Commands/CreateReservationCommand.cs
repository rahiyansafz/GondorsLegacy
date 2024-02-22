using Castle.DynamicProxy;
using GondorsLegacy.Application.Common.Services;
using GondorsLegacy.CrossCuttingCorners.Caching;
using GondorsLegacy.Infrastructure.Interceptors;
using MediatR;
using Newtonsoft.Json;

namespace GondorsLegacy.Services.Reservation.Commands;

public class CreateReservationCommand : IRequest
{
    public Entities.Reservation Reservation { get; set; }
}

public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
{
    private readonly ICrudService<Entities.Reservation> _reservationService;
    private readonly ICache _cacheService;
    private readonly ILogger<CreateReservationCommand> _logger;
    private readonly IProxyGenerator _proxyGenerator;
    private readonly LoggingInterceptor _interceptor;


    public CreateReservationCommandHandler(
        ICrudService<Entities.Reservation> reservationService,
        ICache cacheService,
        ILogger<CreateReservationCommand> logger,
        IProxyGenerator proxyGenerator,
        LoggingInterceptor interceptor)
    {
        _reservationService = reservationService;
        _cacheService = cacheService;
        _logger = logger;
        _proxyGenerator = proxyGenerator;
        _interceptor = interceptor;
    }

    public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var proxy = _proxyGenerator.CreateInterfaceProxyWithTarget(_reservationService, _interceptor);

            await proxy.AddAsync(request.Reservation);


            var exitDate = request.Reservation.CheckOutDate;
            var timeSpan = exitDate - DateTime.Now;

            var reservationJson = JsonConvert.SerializeObject(request.Reservation);

            //_logger.LogInformation("Reservation created by customer {Id}: {Reservation}", request.Reservation.CustomerId, reservationJson);

            var cacheKey = $"Reservation_{request.Reservation.CustomerId}";
            _cacheService.Add(cacheKey, reservationJson, timeSpan);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}