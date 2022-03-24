using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces;

public interface IUnidadMedidaRepository
{
    Task<ICollection<UnidadMedida>> GetCollectionAsync(int page, int rows); 
    Task<UnidadMedida?> GetByIdAsync(int id);
    Task<int> CreateAsync(UnidadMedida unidadMedida);
    Task<int> UpdateAsync(UnidadMedida unidadMedida );
    Task<int> DeleteAsync(int id,string userId);
    Task<UnidadMedida?> BuscarCodUnidadMedidaAsync(string codUnidadMedida);
}