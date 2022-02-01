using System.ComponentModel.DataAnnotations;

namespace CCDelivery.Domain.Entities;

public abstract class BaseEntity
{
    [Key]
    public int ID { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.Now;
}
