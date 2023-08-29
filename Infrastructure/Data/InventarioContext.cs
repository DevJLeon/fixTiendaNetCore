using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class InventarioContext : DbContext
{
    public InventarioContext(DbContextOptions<InventarioContext> options) : base(options)
    {
        
    }
}