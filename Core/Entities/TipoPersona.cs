using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class TipoPersona : BaseEntity
{
    [Key]
    public string? Descripcion { get; set; }
    
    
}
