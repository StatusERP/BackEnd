using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IPedidoEncRepository
{
    Task<ICollection<PedidoEnc>> GetCollectionAsync(); 
    Task<PedidoEnc?> GetByIdAsync(int id);
    Task<int> CreateAsync(PedidoEnc pedidoEnc);
    Task<int> UpdateAsync(PedidoEnc pedidoEnc);
    Task<int> DeleteAsync(int id,string userId);
    Task<PedidoEnc?> BuscarPedidoAsync(string pedido);
}