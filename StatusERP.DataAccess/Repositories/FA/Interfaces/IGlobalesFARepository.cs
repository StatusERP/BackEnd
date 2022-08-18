using StatusERP.Entities.FA.Tablas;
namespace StatusERP.DataAccess.Repositories.FA.Interfaces;

public interface IGlobalesFARepository
{
    Task<int> CreateAsync(GlobalesFA globalesFA);
    Task<int> UpdateAsync(GlobalesFA globalesFA);
    Task<ICollection<GlobalesFA>> GetAllAsync();
}