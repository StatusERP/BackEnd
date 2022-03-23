using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Entities.ERPADMIN.Tablas;

namespace StatusERP.DataAccess.Repositories.ERPADMIN;

public class ModuloInstaladoRepository:StatusERPContextBase<ModuloInstalado>, IModuloInstaladoRepository
{
    public ModuloInstaladoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async  Task<ICollection<ModuloInstalado>> GetCollectionAsync(int conjunto)
    {
        return  await   _dbContext.Set<ModuloInstalado>()
            .AsNoTracking()
            .Where(p => p.ConjuntoId == conjunto && !p.IsDeleted)
            .Include(p=>p.Accion)
            .OrderBy(p=> p.Id)
            .ToListAsync();
    }                               

    public Task<ModuloInstalado?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateAsync(ModuloInstalado moduloInstalado)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAsync(ModuloInstalado moduloInstalado)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id, string userId)
    {
        throw new NotImplementedException();
    }
}