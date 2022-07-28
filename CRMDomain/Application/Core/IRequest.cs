namespace CRMDomain.Application.Core
{
    public interface IRequest<out TResponse> where TResponse : IResponse
    {
    }
}
