using MediatR;
using NerdStore.Core.Data.EventSourcing;
using NerdStore.Core.Message;
using NerdStore.Core.Message.CommonMessages.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Mediator
{
    public class MediateHandler : IMediateHandler
    {

        private IMediator _mediator;
        private readonly IEventSourcingRepository _eventSourcingRepository;

        public MediateHandler(IMediator mediator, IEventSourcingRepository eventSourcingRepository)
        {
            _mediator = mediator;
            _eventSourcingRepository = eventSourcingRepository;
        }

        public async Task EnviarComando<T>(T comando) where T : Command
        {
            // Send é porque estou enviando um comando algo que ira alterar minha base de dados
            await _mediator.Send(comando);
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            // Publish é usado porque não necessáriamente irei alterar minha base de dado mais sim notificar alguma coisa                
            await _mediator.Publish(evento);

            //GetType pega o nome da minha classe filha, o BaseType pega o nome da minha classe base que é a classe que esta sendo herdada pela minha classe filha
            if (!evento.GetType().BaseType.Name.Equals("DomainEvent")) await _eventSourcingRepository.SalvarEvento(evento);
        }

        public async Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification
        {
            await _mediator.Publish(notificacao);
        }
    }
}