using Core.Entities;

namespace Core.Interfaces;
public interface IPais : IGenericRepo<Pais>
{
    Task<Pais> GetByIdAsync(string id);
}