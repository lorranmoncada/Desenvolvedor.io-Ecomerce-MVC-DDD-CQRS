using NerdStore.Core.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{  // Repositorio por agregação ex IagregateRoot
    public interface IProdutoRepository : IRepository<Produto>
    {
        // Task sera utilizado para pesquisas asincronas
        Task<IEnumerable<Produto>> ObterProdutos();
        Task<Produto> ObterPorId(Guid id);
        Task<IEnumerable<Produto>> ObterPorCategoria(int codigo);
        Task<IEnumerable<Categoria>> ObterCategorias();
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Adicionar(Categoria categoria);
        void Atualizar(Categoria categoria);
    }
}
