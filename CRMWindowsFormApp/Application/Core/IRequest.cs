namespace CRMWindowsFormApp.Application.Core
{
    public interface IRequest<out TResponse> where TResponse : IResponse
    {
    }
}
