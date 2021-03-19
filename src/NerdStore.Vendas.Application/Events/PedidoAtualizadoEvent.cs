using NerdStore.Core.Message;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoAtualizadoEvent : Event
    {
        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public decimal ValorTotal { get; private set; }

        public PedidoAtualizadoEvent(Guid clienteId, Guid pedidoId,decimal valorTotal)
        {
            // adicionando o id da minha raiz de agreçação 
            AggregateId = pedidoId;

            PedidoId = pedidoId;
            ClienteId = clienteId;
            ValorTotal = valorTotal;
        }
    }
}
