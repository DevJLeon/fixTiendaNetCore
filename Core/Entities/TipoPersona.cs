using System.ComponentModel.DataAnnotations;
namespace Core.Entities;

public class TipoPersona
{
    [Key]
    public string? Descripcion { get; set; }
    
    
}
