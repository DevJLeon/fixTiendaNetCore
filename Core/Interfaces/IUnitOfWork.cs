

namespace Core.Interfaces;

public interface IUnitOfWork
{
    IPais Paises {get;}

    /*ITipoPersona TipoPersonas {get;}
    IRegion Regiones {get;}*/
    Task<int> SaveAsync();
}
