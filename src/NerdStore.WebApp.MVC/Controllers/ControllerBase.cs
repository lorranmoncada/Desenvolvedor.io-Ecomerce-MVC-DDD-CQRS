using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Mediator;
using NerdStore.Core.Message.CommonMessages.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        private readonly DomainNotificationHandler _DomainNotificationHandler;
        private readonly IMediateHandler _IMediatorHandler;
        protected Guid ClienteId = Guid.Parse("4885e451-b0e4-4490-b959-04fabc806d32");

        protected ControllerBase(INotificationHandler<DomainNotification> DomainNotificationHandler, IMediateHandler IMediatorHandler)
        {
            _DomainNotificationHandler = (DomainNotificationHandler)DomainNotificationHandler;
            _IMediatorHandler = IMediatorHandler;
        }

        protected bool OperacaoValida()
        {
            return !_DomainNotificationHandler.TemNotificacao();
        }

        protected void NotificarErro(string codigo, string mensagem)
        {
            _IMediatorHandler.PublicarNotificacao(new DomainNotification(codigo, mensagem));
        }

        protected void LimparMensagens()
        {
            _DomainNotificationHandler.Dispose();
        }
    }
}
