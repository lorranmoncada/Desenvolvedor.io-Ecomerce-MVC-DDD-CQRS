﻿using MediatR;
using NerdStore.Core.DomainObjects.DTO;
using NerdStore.Core.Extensions;
using NerdStore.Core.Mediator;
using NerdStore.Core.Message;
using NerdStore.Core.Message.CommonMessages.Notifications;
using NerdStore.Core.Messages.CommonMessages.IntegrationEvents;
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
    // classe manipuladora dos meus comands referentes ao pedido 
    // comandos que aplicam as regras de negocios referente a pedidos
    public class PedidoCommandHandler :
        IRequestHandler<AdicionarItemPedidoCommand, bool>,
        IRequestHandler<AtualizarItemPedidoCommand, bool>,
        IRequestHandler<RemoverItemPedidoCommand, bool>,
        IRequestHandler<AplicarVoucherPedidoCommand, bool>,
        IRequestHandler<IniciarPedidoCommand, bool>,
        IRequestHandler<FinalizarPedidoCommand, bool>,
        IRequestHandler<CancelarProcessamentoPedidoEstornarEstoqueCommand, bool>,
        IRequestHandler<CancelarProcessamentoPedidoCommand, bool>

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
                pedido = Pedido.PedidoFactory.NovoPedidoRascunho(message.ClienteId);
                pedido.AdicionarItem(pedidoItem);

                _IPedidoRepository.Adicionar(pedido);
                pedido.AdicionarEvento(new PedidoRascunhoIniciadoEvent(message.ClienteId, message.ProdutoId));
            }
            else
            {
                var pedidoItemExistente = pedido.PedidoItemExistente(pedidoItem);
                pedido.AdicionarItem(pedidoItem);

                if (pedidoItemExistente)
                {
                    _IPedidoRepository.AtualizarItem(pedido.PedidoItems.FirstOrDefault(p => p.ProdutoId == pedidoItem.ProdutoId));
                }
                else
                {
                    _IPedidoRepository.AdicionarItem(pedidoItem);
                }

                pedido.AdicionarEvento(new PedidoAtualizadoEvent(pedido.ClienteId, pedido.Id, pedido.ValorTotal));
            }
            pedido.AdicionarEvento(new PedidoAdicionadoEvent(pedido.ClienteId, pedido.Id, pedidoItem.ProdutoId, pedidoItem.ValorUnitario, pedidoItem.Quantidade, pedidoItem.ProdutoNome));
            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        public async Task<bool> Handle(AtualizarItemPedidoCommand message, CancellationToken cancellationToken)
        {
            if (!ValidarComando(message)) return false;

            var pedido = await _IPedidoRepository.ObterPedidoRascunhoPorClienteId(message.ClienteId);

            if (pedido == null)
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Pedido não encontrado"));
                return false;
            }

            var pedidoItem = await _IPedidoRepository.ObterItemPorPedido(pedido.Id, message.ProdutoId);

            if (!pedido.PedidoItemExistente(pedidoItem))
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Produto não encontrado"));
                return false;
            }

            pedido.AtualizarUnidades(pedidoItem, message.Quantidade);

            pedido.AdicionarEvento(new PedidoAtualizadoEvent(message.ClienteId, pedido.Id, pedido.ValorTotal));

            pedido.AdicionarEvento(new PedidoProdutoAtualizadoEvent(message.ClienteId, pedido.Id, pedidoItem.ProdutoId, pedidoItem.Quantidade));

            _IPedidoRepository.AtualizarItem(pedidoItem);

            // se eu quisersse não precisaria chamar esse método porque o meu proprimo pedidoitem esta ligado ao pedido o changetracker do EF atualizaria automaticamente
            // mas é sempre bom chamar pra ficar explicito no código o que esta acontecendo
            _IPedidoRepository.Atualizar(pedido);

            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        public async Task<bool> Handle(RemoverItemPedidoCommand message, CancellationToken cancellationToken)
        {
            if (!ValidarComando(message)) return false;

            var pedido = await _IPedidoRepository.ObterPedidoRascunhoPorClienteId(message.ClienteId);

            if (pedido == null)
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Pedido não encontrado"));
                return false;
            }

            var pedidoItem = await _IPedidoRepository.ObterItemPorPedido(pedido.Id, message.ProdutoId);

            if (!pedido.PedidoItemExistente(pedidoItem))
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Produto não encontrado"));
                return false;
            }

            pedido.RemoverItem(pedidoItem);

            pedido.AdicionarEvento(new PedidoAtualizadoEvent(message.ClienteId, pedido.Id, pedido.ValorTotal));
            pedido.AdicionarEvento(new PedidoProdutoRemovidoEvent(message.ClienteId, pedido.Id, pedidoItem.Id));

            _IPedidoRepository.RemoverItem(pedidoItem);

            // se eu quisersse não precisaria chamar esse método porque o meu priprimo pedidoitem esta ligaod ao pedido o changetracker do EF atualiaria altomaticamente
            // mas é sempre bom chamar pra ficar explicito no código o que esta acontecendo
            _IPedidoRepository.Atualizar(pedido);

            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        public async Task<bool> Handle(AplicarVoucherPedidoCommand message, CancellationToken cancellationToken)
        {
            if (!ValidarComando(message)) return false;

            var pedido = await _IPedidoRepository.ObterPedidoRascunhoPorClienteId(message.ClienteId);

            if (pedido == null)
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Pedido não encontrado"));
                return false;
            }

            var voucher = await _IPedidoRepository.ObterVoucherPorCodigo(message.CodigoVoucher);

            if (voucher == null)
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("voucher", "Voucher não encontrado"));
                return false;
            }

            // esse método quem manipula se o voucher é aplicavel ou não é minha classe agreagteRoot que no caso é a classe de Pedido
            var voucherAplicavelValidation = pedido.AplicarVoucher(voucher);

            if (!voucherAplicavelValidation.IsValid)
            {
                foreach (var errorVoucher in voucherAplicavelValidation.Errors)
                {
                    await _IMediateHandler.PublicarNotificacao(new DomainNotification(message.MessageType, errorVoucher.ErrorMessage));
                }

                return false;
            }

            pedido.AdicionarEvento(new PedidoAtualizadoEvent(message.ClienteId, pedido.Id, pedido.ValorTotal));
            pedido.AdicionarEvento(new VoucherAplicadoPedidoEvent(message.ClienteId, pedido.Id, voucher.Id));

            _IPedidoRepository.Atualizar(pedido);

            //Cenário real teria que debitar o quantidade de voucher utilizado
            //voucher.DebitarQuantidadeVoucherUtilizado();

            //_IPedidoRepository.AtualizarVoucher(voucher);
            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        public async Task<bool> Handle(IniciarPedidoCommand message, CancellationToken cancellationToken)
        {
            if (!ValidarComando(message)) return false;

            var pedido = await _IPedidoRepository.ObterPedidoRascunhoPorClienteId(message.ClienteId);

            if (pedido == null)
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Pedido não encontrado"));
                return false;
            }

            pedido.IniciarPedido();

            var itemList = new List<Item>();

            pedido.PedidoItems.ForEach(p => itemList.Add(new Item { Id = p.ProdutoId, Quantidade = p.Quantidade }));

            var listaProdutosPedido = new ListaProdutosPedido() { PedidoId = pedido.Id, Itens = itemList };

            pedido.AdicionarEvento(new PedidoIniciadoEvent(pedido.Id, pedido.ClienteId, listaProdutosPedido, pedido.ValorTotal, message.NomeCartao, message.NumeroCartao, message.ExpiracaoCartao, message.CvvCartao));

            _IPedidoRepository.Atualizar(pedido);

            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        public async Task<bool> Handle(FinalizarPedidoCommand message, CancellationToken cancellationToken)
        {
            var pedido = await _IPedidoRepository.ObterPorId(message.PedidoId);

            if (pedido == null)
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Pedido não encontrado!"));
                return false;
            }

            pedido.FinalizarPedido();
            // aqui eu poderia também gerar nota fiscal 
            pedido.AdicionarEvento(new PedidoFinalizadoEvent(message.PedidoId));
            // eu nã precisaria chamar o atualizar pedido pois ao alterar o status de pagamento dele e rodando o commit o proprio EF atualizaria minha entidade 
            _IPedidoRepository.Atualizar(pedido);
            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        public async Task<bool> Handle(CancelarProcessamentoPedidoEstornarEstoqueCommand message, CancellationToken cancellationToken)
        {
            var pedido = await _IPedidoRepository.ObterPorId(message.PedidoId);

            if (pedido == null)
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Pedido não encontrado!"));
                return false;
            }

            var itensList = new List<Item>();
            pedido.PedidoItems.ForEach(i => itensList.Add(new Item { Id = i.ProdutoId, Quantidade = i.Quantidade }));
            var listaProdutosPedido = new ListaProdutosPedido { PedidoId = pedido.Id, Itens = itensList };

            // Evento de integração, porque meu context de catálogo manipula esse vento
            pedido.AdicionarEvento(new PedidoProcessamentoCanceladoEvent(pedido.Id, pedido.ClienteId, listaProdutosPedido));
            pedido.TornarRascunho();

            return await _IPedidoRepository.IUnitOfWork.Commit();
        }

        public async Task<bool> Handle(CancelarProcessamentoPedidoCommand message, CancellationToken cancellationToken)
        {
            var pedido = await _IPedidoRepository.ObterPorId(message.PedidoId);

            if (pedido == null)
            {
                await _IMediateHandler.PublicarNotificacao(new DomainNotification("pedido", "Pedido não encontrado!"));
                return false;
            }

            pedido.TornarRascunho();

            //aqui eu poderia chama ro atualizar mas o proprio Ef percebe que minha entidade pedido mudou de status e ao rodar o commit ele alterara minha entidade no banco
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
