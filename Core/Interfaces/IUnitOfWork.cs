namespace Core.Interfaces;
public interface IUnitOfWork
{
    IPaisInterface Paises {get;}
    ITipoPersona TipoPersonas {get;}
    IRegion Regiones {get;}
    Task<int> SaveAsync();
}
