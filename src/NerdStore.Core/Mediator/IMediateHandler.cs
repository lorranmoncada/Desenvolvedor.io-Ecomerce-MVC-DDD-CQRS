using NerdStore.Core.Message;
using System.Threading.Tasks;

namespace NerdStore.Core.Mediator
{
    public interface IMediateHandler
    {
        Task PublicarEvento<T>(T evento) where T : Event;

        Task EnviarComando<T>(T comando) where T : Command;
    }
}
