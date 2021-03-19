using MediatR;
using NerdStore.Core.Mediator;
using NerdStore.Core.Message;
using NerdStore.Core.Message.CommonMessages.Notifications;
using NerdStore.Vendas.Application.Events;
using NerdStore.Vendas.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Commands
{
    // classe que manipula o comando AdicionarItemPedidoCommand
    public class PedidoCommandHandler : IRequestHandler<AdicionarItemPedidoCommand, bool>
    {
        private readonly IPedidoRepository _IPedidoRepository;
        private readonly IMediateHandler _IMediateHandler;
        public PedidoCommandHandler(IPedidoRepository IPedidoRepository, IMediateHandler IMediateHandler)
        {
            _IPedidoRepository = IPedidoRepository;
            _IMediateHandler = IMediateHandler;
        }
        // ele sempre retorna uma task poque ele funciona com base assincrona 
        public async Task<bool> Handle(AdicionarItemPedidoCommand message, CancellationToken cancellationToken)
        {
            // antes de seguir em frente sempre vou validar se meu comando é válido
            if (!ValidarComando(message)) return false;

            var pedido = await _IPedidoRepository.ObterPedidoRascunhoPorClienteId(message.ClienteId);
            var pedidoItem = new PedidoItem(message.ProdutoId, message.Nome, message.Quantidade, message.ValorUnitario);

            if (pedido == null)
            {
                pedido =  Pedido.PedidoFactory.NovoPedidoRascunho(message.ClienteId);
                pedido.AdicionarItem(pedidoItem);

                _IPedidoRepository.Adicionar(pedido);
                pedido.AdicionarEvento(new PedidoRascunhoIniciadoEvent(message.ClienteId, message.ProdutoId));
            }
            else{
                var pedidoItemExistente = pedido.PedidoItemExistente(pedidoItem);
                pedido.AdicionarItem(pedidoItem);

                if (pedidoItemExistente)
                {
                    _IPedidoRepository.AtualizarItem(pedido.PedidoItems.FirstOrDefault(p => p.ProdutoId == pedidoItem.ProdutoId ));
                }
                else
                {
                    _IPedidoRepository.AdicionarItem(pedidoItem);
                }

                pedido.AdicionarEvento(new PedidoAtualizadoEvent(pedido.ClienteId, pedido.Id, pedido.ValorTotal));
            }
            pedido.AdicionarEvento(new PedidoAdicionadoEvent(pedido.ClienteId, pedido.Id, pedidoItem.ProdutoId, pedidoItem.ValorUnitario, pedidoItem.Quantidade,pedidoItem.ProdutoNome));
            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        private bool ValidarComando(Command message)
        {
            if (message.EhValido()) return true;

            foreach (var error in message.ValidationResult.Errors)
            {
                _IMediateHandler.PublicarNotificacao(new DomainNotification(message.MessageType, error.ErrorMessage));
            }

            return false;
        }
    }
}
