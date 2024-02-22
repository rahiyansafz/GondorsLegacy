﻿using GondorsLegacy.Application.Common.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GondorsLegacy.Application.Decorators.DatabaseRetry;

[Mapping(Type = typeof(DatabaseRetryAttribute))]
public class DatabaseRetryQueryDecorator<TQuery, TResult> : DatabaseRetryDecoratorBase, IQueryHandler<TQuery, TResult>
    where TQuery : IQuery<TResult>
{
    private readonly IQueryHandler<TQuery, TResult> _handler;

    public DatabaseRetryQueryDecorator(IQueryHandler<TQuery, TResult> handler, DatabaseRetryAttribute options)
    {
        DatabaseRetryOptions = options;
        _handler = handler;
    }

    public async Task<TResult> HandleAsync(TQuery query, CancellationToken cancellationToken = default)
    {
        Task<TResult> result = default;

        await WrapExecutionAsync(() => result = _handler.HandleAsync(query, cancellationToken));

        return await result;
    }
}