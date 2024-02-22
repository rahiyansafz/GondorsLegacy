using System.ComponentModel.DataAnnotations;

namespace GondorsLegacy.Domain.Entities;

public class Entity<TKey> : IHasKey<TKey>, ITrackable
{
    [Key] public TKey Id { get; set; }

    [Timestamp] public byte[] RowVersion { get; set; }

    public DateTimeOffset CreatedDateTime { get; set; }

    public DateTimeOffset UpdatedDateTime { get; set; }
}