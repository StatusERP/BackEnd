using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface ITipoTarjetaRepository
    {
        Task<ICollection<TipoTarjeta>> GetCollectionAsync();
        Task<TipoTarjeta?> GetByIdAsync(int id);
        Task<int> CreateAsync(TipoTarjeta tipoTarjeta);
        Task<int> UpdateAsync(TipoTarjeta tipoTarjeta);
        Task<int> DeleteAsync(int id, string userId);
        Task<TipoTarjeta?> BuscarCodTipoTarjetaAsync(string codTipoTarjeta);
    }
}