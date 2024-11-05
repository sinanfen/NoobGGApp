using Microsoft.AspNetCore.Identity;
using NoobGGApp.Domain.Common.Entities;

namespace NoobGGApp.Domain.Identity;

public class ApplicationUser : IdentityUser<Guid>, IEntity<Guid>, ICreatedByEntity, IModifiedByEntity
{
    public Guid Id { get; set; }
    public string CreatedByUserId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public string? ModifiedByUserId { get; set; }
    public DateTimeOffset? ModifiedAt { get; set; }
}
