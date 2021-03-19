﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Core.Mediator;
using NerdStore.Core.Message.CommonMessages.Notifications;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Controllers
{
    public class CarrinhoController : ControllerBase
    {
        private readonly IProdutoAppService _produtoAppService;
        private readonly IMediateHandler _IMediateHandler;
        private readonly IPedidoQueries _IPedidoQueries;
        public CarrinhoController(IProdutoAppService produtoAppService,
            INotificationHandler<DomainNotification> DomainNotificationHandler,
            IMediateHandler IMediateHandler,
            IPedidoQueries IPedidoQueries)
            : base(DomainNotificationHandler, IMediateHandler)
        {
            _produtoAppService = produtoAppService;
            _IMediateHandler = IMediateHandler;
            _IPedidoQueries = IPedidoQueries;
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
            await _IMediateHandler.EnviarComando(command);

            if (OperacaoValida())
            {
                return RedirectToAction("Index");
            }

            // Esta sendo usado o TempData porque estou usando o redirectToAction toda ves que uso esse redirection eu perco o 
            //estado do meu request anterior,então eu preciso persistir minha msg de erro no meu temp data
            TempData["Erro"] = "Produto Indisponível";
            // Esse redirect é um novo request
            return RedirectToAction("ProdutoDetalhe", "Vitrine", new { id });
        }

        [Route("meu-carrinho")]
        public async Task<IActionResult> Index()
        {
            return View(await _IPedidoQueries.ObterCarrinhoCliente(ClienteId));
        }

        //[HttpPost]
        //[Route("remover-item")]
        //public async Task<IActionResult> RemoverItem(Guid id)
        //{
        //    var produto = await _produtoAppService.ObterPorId(id);
        //    if (produto == null) return BadRequest();

        //    var command = new RemoverItemPedidoCommand(ClienteId, id);
        //    await _mediatorHandler.EnviarComando(command);

        //    if (OperacaoValida())
        //    {
        //        return RedirectToAction("Index");
        //    }

        //   return View("Index", await _pedidoQueries.ObterCarrinhoCliente(ClienteId));
        //}
    }
}
