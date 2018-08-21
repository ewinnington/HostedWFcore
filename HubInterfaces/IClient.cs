using System;
using System.Threading.Tasks;

namespace HubInterfaces
{
    public interface IClient
    {
        Task NewMessage(string message);
    }
}
