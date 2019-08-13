using System.Threading.Tasks;

namespace TalkServer.Hubs.Interfaces
{
    public interface ILoginHub
    {
        Task ReceiveLoginAsync(string token);
    }
}