using System.Threading.Tasks;

namespace HomeGenie.SDK.Contracts
{
    public interface IHttpService
    {
        Task<T> Get<T>(string url);
    }
}