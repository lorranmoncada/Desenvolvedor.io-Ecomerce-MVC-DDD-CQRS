using NerdStore.Core.DomainObjects;
using NerdStore.Core.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Infraestructure
{
    // È uma classe estatica porque é um método de extensão
    public static class MediatorExtension
    {
        public static async Task PublicarEventos(this IMediateHandler mediator, VendasContext ctx)
        {
            // Ira pegar todas as minhas entidades que estiverem no meu change tracker onde minha entrada seja do tipo Entity
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.Notificacoes != null && x.Entity.Notificacoes.Any());

            var domainEvents = domainEntities
                .SelectMany(x => x.Entity.Notificacoes)
                .ToList();

            domainEntities.ToList()
                .ForEach(entity => entity.Entity.LimparEvento());

            var tasks = domainEvents
                .Select(async (domainEvent) =>
                {
                    await mediator.PublicarEvento(domainEvent);
                });

            // esse await so vai voltar quando todos os meus eventos forem lançados
           
            await Task.WhenAll(tasks);
        }
    }
}
