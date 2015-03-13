using System.Threading.Tasks;
using Windows.Storage.Streams;

namespace HomeGenie.SDK.Contracts
{
    public interface IHttpService
    {
        Task<T> Get<T>(string url);
        Task<IRandomAccessStream> GetImageStream(string url);
    }
}