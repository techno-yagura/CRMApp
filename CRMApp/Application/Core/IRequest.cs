﻿namespace CRMApp.Application.Core
{
    public interface IRequest<out TResponse> where TResponse : IResponse
    {
    }
}
