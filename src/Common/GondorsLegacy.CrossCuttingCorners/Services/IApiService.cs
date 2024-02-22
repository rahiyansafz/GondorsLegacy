using Refit;

namespace GondorsLegacy.CrossCuttingCorners.Services;

public interface IApiService
{
    [Get("/{endpoint}")]
    Task<T> GetAsync<T>(string endpoint);

    [Post("/{endpoint}")]
    Task<T> PostAsync<T>(string endpoint, [Body] object data);

    [Put("/{endpoint}")]
    Task<T> PutAsync<T>(string endpoint, [Body] object data);

    [Delete("/{endpoint}")]
    Task DeleteAsync(string endpoint);

    [Get("/{endpoint}")]
    Task<IEnumerable<T>> GetListAsync<T>(string endpoint);

    [Post("/{endpoint}")]
    Task<TResponse> PostAsync<TRequest, TResponse>(string endpoint, [Body] TRequest data);

    [Put("/{endpoint}")]
    Task<TResponse> PutAsync<TRequest, TResponse>(string endpoint, [Body] TRequest data);
}