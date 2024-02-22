using GondorsLegacy.CrossCuttingCorners.Contracts;

namespace GondorsLegacy.Infrastructure.Contracts;

using Polly;

public class RetryPolicy<T> : IRetryPolicy<T>
{
    public T Execute(Func<T> action)
    {
        return Policy
            .Handle<Exception>()
            .Retry(3, (exception, retryCount) => { })
            .Execute(action);
    }

    public T Execute(Func<T> action, int retryCount)
    {
        return Policy
            .Handle<Exception>()
            .Retry(retryCount, (exception, retry) => { })
            .Execute(action);
    }

    public T Execute(Func<T> action, int retryCount, TimeSpan retryInterval)
    {
        return Policy
            .Handle<Exception>()
            .WaitAndRetry(retryCount, _ => retryInterval, (exception, timeSpan, retry, context) => { })
            .Execute(action);
    }

    public T Execute(Func<T> action, Func<Exception, bool> exceptionPredicate)
    {
        return Policy
            .Handle(exceptionPredicate)
            .Retry(3, (exception, retryCount) => { })
            .Execute(action);
    }

    public async Task<T> ExecuteAsync(Func<Task<T>> asyncAction)
    {
        return await Policy
            .Handle<Exception>()
            .RetryAsync(3, (exception, retryCount) => { })
            .ExecuteAsync(asyncAction);
    }

    public async Task<T> ExecuteAsync(Func<Task<T>> asyncAction, int retryCount)
    {
        return await Policy
            .Handle<Exception>()
            .RetryAsync(retryCount, (exception, retry) => { })
            .ExecuteAsync(asyncAction);
    }

    public async Task<T> ExecuteAsync(Func<Task<T>> asyncAction, int retryCount, TimeSpan retryInterval)
    {
        return await Policy
            .Handle<Exception>()
            .WaitAndRetryAsync(retryCount, _ => retryInterval, (exception, timeSpan, retry, context) => { })
            .ExecuteAsync(asyncAction);
    }

    public async Task<T> ExecuteAsync(Func<Task<T>> asyncAction, Func<Exception, bool> exceptionPredicate)
    {
        return await Policy
            .Handle(exceptionPredicate)
            .RetryAsync(3, (exception, retryCount) => { })
            .ExecuteAsync(asyncAction);
    }
}