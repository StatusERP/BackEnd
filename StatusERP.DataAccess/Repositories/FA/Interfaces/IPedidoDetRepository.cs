using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IPedidoDetRepository
{
    Task<ICollection<PedidoDet>> GetCollectionAsync(); 
    Task<PedidoDet?> GetByIdAsync(int id);
    Task<int> CreateAsync(PedidoDet pedidoDet);
    Task<int> UpdateAsync(PedidoDet pedidoDet);
    Task<int> DeleteAsync(int id,string userId);
    Task<PedidoDet?> BuscarPedidoDetAsync(int pedidoId, Int16 pedidoLinea);
}