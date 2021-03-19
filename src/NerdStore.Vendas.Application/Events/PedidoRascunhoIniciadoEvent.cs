using NerdStore.Core.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoRascunhoIniciadoEvent : Event
    {
        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }

        public PedidoRascunhoIniciadoEvent(Guid clienteId, Guid pedidoId)
        {
            // adicionando o id da minha raiz de agreçação 
            AggregateId = pedidoId;

            PedidoId = pedidoId;
            ClienteId = clienteId;
        }
    }
}
