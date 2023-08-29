using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class PaisRepository : GenericRepository<Pais>, IPais
{
    protected readonly TiendaContext _context;
    public PaisRepository(TiendaContext context) : base (context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Pais>> GetAllAsync()
    {
        return await _context.Paises
            .Include(p => p.Estados)
            .ToListAsync();
    }
    public override async Task<Pais> GetByIdAsync(int id)
    {
        return await _context.Paises
            .Include(p => p.Estados)
            .FirstOrDefaultAsync(p =>  p.Id == id);
    }
}