using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NerdStore.Catalogo.Domain;
using NerdStore.Core.Data;

namespace NerdStore.Catalogo.Data.Repository
{   // AsNoTracking é utilizado para diminuir o consumo de recursos utilizado no entity framework
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly CatalogoContext _context;

        public ProdutoRepository(CatalogoContext context)
        {
            _context = context;
        }
        // O IUnitOfWork neste repositorio reflete o CatalogoContext que é o meu contexto de catálogo
        // meu contexto implementa a minha interface IUnitOfWork
        public IUnitOfWork IUnitOfWork => _context;

        public void Adicionar(Produto produto)
        {
            _context.Produtos.AddAsync(produto);
        }

        public void Adicionar(Categoria categoria)
        {
            _context.Categorias.AddAsync(categoria);
        }

        public void Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
        }

        public void Atualizar(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
        }

        public async Task<IEnumerable<Categoria>> ObterCategorias()
        {
            return await _context.Categorias.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterPorCategoria(int codigo)
        {
            return await _context.Produtos.AsNoTracking().Include(p => p.Categoria).Where(c => c.Categoria.Codigo == codigo).ToListAsync();
            //return await _context.Produtos.Where(p => p.Categoria.Codigo.Equals(codigo)).AsNoTracking().ToListAsync();
        }

        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _context.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutos()
        {
            return await _context.Produtos.AsNoTracking().ToListAsync();
        }
        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}