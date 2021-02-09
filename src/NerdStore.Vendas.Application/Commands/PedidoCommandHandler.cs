using MediatR;
using NerdStore.Core.Message;
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
        public PedidoCommandHandler(IPedidoRepository IPedidoRepository)
        {
            _IPedidoRepository = IPedidoRepository;
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

               
            }

            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        private bool ValidarComando(Command message)
        {
            if (message.EhValido()) return true;

            foreach (var error in message.ValidationResult.Errors)
            {
                // Lançar evento de erro e não um exception
            }

            return false;
        }
    }
}
