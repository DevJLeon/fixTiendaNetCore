using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly TiendaContext context;

    private PaisRepository _paises;

    //private TipoPersonaRepository _tipoPersonas;
    
    //private RegionRepository _regiones;

    public UnitOfWork (TiendaContext _context)
    {
        context = _context;
    }

    public IPais Paises
    {
        get{
            if(_paises == null){
                _paises = new PaisRepository(context);
            }
            return _paises;
        }
    }

    /*public ITipoPersona TipoPersonas
    {
        get{
            if(_tipoPersonas == null){
                _tipoPersonas = new TipoPersonasRepository(context);
            }
            return _paises;
        }
    }*/

    public void Dispose ()
    {
        context.Dispose();
    }
    public async Task <int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}
