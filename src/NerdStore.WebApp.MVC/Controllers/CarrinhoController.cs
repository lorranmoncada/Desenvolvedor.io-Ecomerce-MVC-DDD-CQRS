using Microsoft.AspNetCore.Mvc;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Core.Mediator;
using NerdStore.Vendas.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Controllers
{
    public class CarrinhoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;
        private readonly IMediateHandler _bus;
        public CarrinhoController(IProdutoAppService produtoAppService, IMediateHandler bus)
        {
            _produtoAppService = produtoAppService;
            _bus = bus;
        }

        [HttpPost]
        [Route("meu-carrinho")]
        public async Task<IActionResult> AdicionarItem(Guid id, int quantidade)
        {
            var produto = await _produtoAppService.ObterPorId(id);
            if (produto == null) return BadRequest();

            if (produto.QuantidadeEstoque < quantidade)
            {
                TempData["Erro"] = "Produto com estoque insuficiente";
                return RedirectToAction("ProdutoDetalhe", "Vitrine", new { id });
            }

            var command = new AdicionarItemPedidoCommand(ClienteId, produto.Id, produto.Nome, quantidade, produto.Valor);
            await _bus.EnviarComando(command);

            //if (OperacaoValida())
            //{
            //    return RedirectToAction("Index");
            //}

          
            return RedirectToAction("ProdutoDetalhe", "Vitrine", new { id });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
