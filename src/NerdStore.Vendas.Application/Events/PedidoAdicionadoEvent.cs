using NerdStore.Core.Message;
using System;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoAdicionadoEvent : Event
    {
        public Guid PedidoId { get; private set; }
        public Guid ClienteId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public decimal ValorUnitario { get; private set; }
        public int Quantidade { get; private set; }
        public string NomeProduto { get; private set; }

        public PedidoAdicionadoEvent(Guid clienteId, Guid pedidoId, Guid produtoId, decimal valorUnitario, int quantidade,string nomeProduto)
        {
            // adicionando o id da minha raiz de agreçação 
            AggregateId = pedidoId;

            PedidoId = pedidoId;
            ClienteId = clienteId;
            ProdutoId = produtoId;
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            NomeProduto = nomeProduto;
        }
    }
}
