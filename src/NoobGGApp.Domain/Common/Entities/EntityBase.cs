using NoobGGApp.Domain.Common.Events;

namespace NoobGGApp.Domain.Common.Entities;

public abstract class EntityBase<TKey> : IEntity<TKey>, IModifiedByEntity, ICreatedByEntity where TKey : struct
{
    public TKey Id { get; set; }

    public virtual string CreatedByUserId { get; set; }
    public virtual DateTimeOffset CreatedAt { get; set; }
    public virtual string? ModifiedByUserId { get; set; }
    public virtual DateTimeOffset? ModifiedAt { get; set; }
    private readonly List<IDomainEvent> _domainEvents = [];
    protected IReadOnlyList<IDomainEvent> GetDomainEvents => _domainEvents.AsReadOnly();
    protected void RaiseDomainEvent(IDomainEvent domainEvent)=>_domainEvents.Add(domainEvent);
    protected void ClearDomainEvents()=>_domainEvents.Clear();
}
