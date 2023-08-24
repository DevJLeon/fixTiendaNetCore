namespace Core.Entities
{
    public class Producto : BaseEntity
    {
        public string ? Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaCreacion { get; set; }

        
    }
}