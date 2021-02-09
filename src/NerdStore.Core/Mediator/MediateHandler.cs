using MediatR;
using NerdStore.Core.Message;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Mediator
{
    public class MediateHandler : IMediateHandler
    {

        private IMediator _mediator;

        public MediateHandler(IMediator mediator)
        {
            _mediator = mediator;
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
        }
    }
}