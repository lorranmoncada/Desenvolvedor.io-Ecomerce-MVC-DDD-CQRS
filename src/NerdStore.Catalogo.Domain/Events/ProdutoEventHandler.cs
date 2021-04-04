using MediatR;
using NerdStore.Catalogo.Domain.Services;
using NerdStore.Core.Mediator;
using NerdStore.Core.Messages.CommonMessages.IntegrationEvents;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Events
{
    // Ira manipular o produto abaixo do estoque
    public class ProdutoEventHandler :
        INotificationHandler<ProdutoAbaixoEstoqueEvent>,
        INotificationHandler<PedidoIniciadoEvent>,
        INotificationHandler<PedidoProcessamentoCanceladoEvent>
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IEstoqueService _estoqueService;
        private readonly IMediateHandler _mediateHandler;
        public ProdutoEventHandler(IProdutoRepository produtoRepository, IEstoqueService estoqueService, IMediateHandler mediateHandler)
        {
            _produtoRepository = produtoRepository;
            _estoqueService = estoqueService;
            _mediateHandler = mediateHandler;
        }

        // método task é um método void
        public async Task Handle(ProdutoAbaixoEstoqueEvent message, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.ObterPorId(message.AggregateId);

            // Exemplo enviaria um e-mail solicitando a compra de mais produto para repor estoque ou então abrirria um ticket de solicitação
        }

        public async Task Handle(PedidoIniciadoEvent message, CancellationToken cancellationToken)
        {
            var result = await _estoqueService.DebitarListaProdutosPedido(message.ProdutosPedido);

            // Lembrando que os eventos são disparados em relação ao passado a alguma coisa que ja aconteceu
            if (result)
            {
                await _mediateHandler.PublicarEvento(new PedidoEstoqueConfirmadoEvent(message.PedidoId, message.ClienteId, message.Total, message.ProdutosPedido, message.NomeCartao, message.NumeroCartao, message.ExpiracaoCartao, message.CvvCartao));
            }
            else
            {
                await _mediateHandler.PublicarEvento(new PedidoEstoqueRejeitadoEvent(message.PedidoId, message.ClienteId));
            }
        }

        public async Task Handle(PedidoProcessamentoCanceladoEvent message, CancellationToken cancellationToken)
        {
            await _estoqueService.ReporListaProdutosPedido(message.ProdutosPedido);
        }
    }
}
