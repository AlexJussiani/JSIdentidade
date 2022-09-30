using JS.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JS.Core.Data.EventSourcing
{
    public interface IEventSourcingRepository
    {
        Task SalvarEvento<TEvent>(TEvent evento) where TEvent : Event;
        Task<IEnumerable<StoredEvent>> ObterEventos(Guid aggregateId);      
    }
}
