using MediatR;
using System;

namespace CqrsEsExample.Core.Messages.CommonMessages.DomainEvents
{
    public abstract class DomainEvent : Message, INotification
    {
        public DateTime Timestamp { get; private set; }

        protected DomainEvent(Guid aggregateId)
        {
            Timestamp = DateTime.Now;
            AggregateId = aggregateId;
        }
    }
}
