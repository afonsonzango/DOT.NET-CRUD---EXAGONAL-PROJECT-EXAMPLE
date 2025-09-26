using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APPOINTMENT_SERVICE_API.Main.Root.Core.Database.Schemas.Entities;

public abstract class BaseEntity
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    
    public Guid Uuid { get; set; } = Guid.NewGuid();
    
    public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    
    public DateTime? DeletedOn { get; set; }
}