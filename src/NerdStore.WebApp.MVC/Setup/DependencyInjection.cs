using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Data;
using NerdStore.Catalogo.Data.Repository;
using NerdStore.Catalogo.Domain;
using NerdStore.Catalogo.Domain.Events;
using NerdStore.Catalogo.Domain.Services;
using NerdStore.Core.Mediator;
using NerdStore.Core.Message.CommonMessages.Notifications;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Domain;
using NerdStore.Vendas.Infraestructure;
using NerdStore.Vendas.Infraestructure.Repoditory;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Mediator
            services.AddScoped<IMediateHandler, MediateHandler>();

            // Notifications
            services.AddSingleton<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueServices>();
            services.AddDbContext<CatalogoContext>();

            // Toda vez que ProdutoAbaixoEstoqueEvent for lançado o ProdutoEventHandler que ira pegar
            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();

            // Vendas
            services.AddDbContext<VendasContext>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
        }
    }
}
