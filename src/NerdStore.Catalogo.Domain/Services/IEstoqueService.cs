using System;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Services
{
    public interface IEstoqueService: IDisposable
    {
        Task<bool> DebitarEstoque(Guid produto, int quantidade);
        Task<bool> ReporEstoque(Guid produto, int quantidade);
    }
}
