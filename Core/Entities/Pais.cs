using System.Runtime.Intrinsics.Arm.Arm64;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Pais : BaseEntity
{
    [Key] 
    public string? CodPais { get; set; }
    public string? NombrePais { get; set; }
    public ICollection<Estado>? Estados { get; set; }
}
