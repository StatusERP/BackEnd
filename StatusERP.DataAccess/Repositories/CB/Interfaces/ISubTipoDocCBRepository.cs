using StatusERP.Entities.CB.Tablas;


namespace StatusERP.DataAccess.Repositories.CB.Interfaces;

public interface ISubTipoDocCBRepository
{
    Task<ICollection<SubTipoDocCB>> GetCollectionAsync();
    Task<SubTipoDocCB?> GetByIdAsync(int id);
    Task<int> CreateAsync(SubTipoDocCB subTipoDocCB );
    Task<int> UpdateAsync(SubTipoDocCB subTipoDocCB);
    Task<int> DeleteAsync(int id, string userId);
    Task<SubTipoDocCB?> BuscarSubTipoDocCBAsync(string tipo, int subTipo);
}