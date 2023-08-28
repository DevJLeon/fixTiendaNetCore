using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly InvenarioContext context;

    private PaisRepository _paises;

    private TipoPersonaRepository _tipoPersonas;
    
    private RegionRepository _regiones;

    public UnitOfWork (InventarioContext _context)
    {
        context = _context;
    }

    public IPaisInterface Paises
    {
        get{
            if(_paises == null){
                _paises = new PaisRepository(context);
            }
            return _paises;
        }
    }

    public ITipoPersona TipoPersonas
    {
        get{
            if(_tipoPersonas == null){
                _tipoPersonas = new TipoPersonasRepository(context);
            }
            return _paises;
        }
    }
}
