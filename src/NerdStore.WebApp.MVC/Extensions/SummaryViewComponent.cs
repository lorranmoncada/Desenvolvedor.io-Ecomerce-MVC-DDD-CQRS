using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Message.CommonMessages.Notifications;
using System.Linq;
using System.Threading.Tasks;

namespace NerdStore.WebApp.MVC.Extensions
{
    // Mostra todos os problemas encontrados
    public class SummaryViewComponent: ViewComponent
    {
        private readonly DomainNotificationHandler _notification;

        public SummaryViewComponent(INotificationHandler<DomainNotification> notification)
        {
            _notification = (DomainNotificationHandler)notification;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var notificacoes = await Task.FromResult(_notification.ObterNotificacoes());
            notificacoes.ForEach(c => ViewData.ModelState.AddModelError(string.Empty, c.Value));

            if (notificacoes.Any()) {
                _notification.Dispose();
            }

            return View();
        }
    }
}
