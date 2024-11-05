namespace NoobGGApp.Domain.Common.Entities;

public interface ICreatedByEntity
{
    string CreatedByUserId { get; set; }
    DateTimeOffset CreatedAt { get; set; }
}
