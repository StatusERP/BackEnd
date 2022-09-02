using StatusERP.Entities.CC.Tablas;

namespace StatusERP.DataAccess.Repositories.CC.Interfaces;

public interface ISubTipoDocCCRepository
{
    Task<ICollection<SubTipoDocCC>> GetCollectionAsync();
    Task<SubTipoDocCC?> GetByIdAsync(int id);
    Task<int> CreateAsync(SubTipoDocCC subTipoDocCC);
    Task<int> UpdateAsync(SubTipoDocCC subTipoDocCC);
    Task<int> DeleteAsync(int id, string userId);
    Task<SubTipoDocCC?> BuscarSubTipoDocCCAsync(string tipo, int subTipo);
}