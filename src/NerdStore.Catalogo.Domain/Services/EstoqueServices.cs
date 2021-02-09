using NerdStore.Catalogo.Domain.Events;
using NerdStore.Core.DomainObjects;
using NerdStore.Core.Mediator;
using System;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Services
{
    public class EstoqueServices : IEstoqueService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMediateHandler _bus;

        public EstoqueServices(IProdutoRepository produtoRepository, IMediateHandler bus)
        {
            _produtoRepository = produtoRepository;
            _bus = bus;
        }

        public async Task<bool> DebitarEstoque(Guid produtoId, int quantidade)
        {
            Produto produto = await _produtoRepository.ObterPorId(produtoId);

            if (produto == null) return false;
            if (!produto.PossuiEstoque(quantidade)) return false;


            produto.DebitarEstoque(quantidade);

            //Evento disparado 
            // Parametrizar a quantidade de esto baixo
            if (produto.QuantidadeEstoque < 10)
            {
                await _bus.PublicarEvento(new ProdutoAbaixoEstoqueEvent(produto.Id, produto.QuantidadeEstoque));
            }

            _produtoRepository.Atualizar(produto);
            return await _produtoRepository.IUnitOfWork.Commit();
        }

        public async Task<bool> ReporEstoque(Guid produtoId, int quantidade)
        {
            Produto produto = await _produtoRepository.ObterPorId(produtoId);

            if (produto == null) return false;
            produto.ReporEstoque(quantidade);

            _produtoRepository.Atualizar(produto);
            return await _produtoRepository.IUnitOfWork.Commit();
        }

        public void Dispose()
        {
            _produtoRepository.Dispose();
        }
    }
}
