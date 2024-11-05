namespace NoobGGApp.Domain.Common.Entities;

public interface IModifiedByEntity
{
    string? ModifiedByUserId { get; set; }
    DateTimeOffset? ModifiedAt { get; set; }
}
