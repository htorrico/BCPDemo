using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sales.Domain.Base
{
    public abstract class BaseEntity
    {
        private List<BaseDomainEvent> _events;
        public IReadOnlyList<BaseDomainEvent> Events => _events.AsReadOnly();

        protected void AddEvent(BaseDomainEvent @event)
        {
            _events.Add(@event);
        }

        protected void RemoveEvent(BaseDomainEvent @event)
        {
            _events.Remove(@event);
        }
    }

    public abstract class BaseEntity<TKey> : BaseEntity
    {
        [Key]
        public TKey? Id { get; set; }
        

    }
}