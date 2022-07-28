namespace CRMWinFormsApp.ApplicationLayer.Core
{
    public interface IRequest<out TResponse> where TResponse : IResponse
    {
    }
}
