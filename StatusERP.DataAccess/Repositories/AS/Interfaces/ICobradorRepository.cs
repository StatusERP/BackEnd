using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface ICobradorRepository
    {
        Task<ICollection<Cobrador>> GetCollectionAsync();
        Task<Cobrador?> GetByIdAsync(int id);
        Task<int> CreateAsync(Cobrador cobrador);
        Task<int> UpdateAsync(Cobrador cobrador);
        Task<int> DeleteAsync(int id,string userId);
        Task<Cobrador?> BuscarCodCobradorAsync(string codCobrador);
    }
}
