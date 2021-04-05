using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NerdStore.Core.Message;

namespace NerdStore.Core.Data.EventSourcing
{
    public interface IEventSourcingRepository
    {
        Task SalvarEvento<T>(T evento) where T : Event;
        Task<IEnumerable<StoredEvent>> ObterEventos(Guid aggregateId);
    }
}