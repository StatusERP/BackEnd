using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class ConsecutivoUsuarioRepository : StatusERPContextBase<ConsecutivoUsuario> ,IConsecutivoUsuarioRepository
{
    public ConsecutivoUsuarioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<ConsecutivoUsuario>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<ConsecutivoUsuario>(page, rows);
    }

    public async Task<ConsecutivoUsuario?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<ConsecutivoUsuario>(id);
    }

    public async Task<int> CreateAsync(ConsecutivoUsuario consecutivoUsuario)
    {
        return await _dbContext.InsertAsync(consecutivoUsuario);
    }

    public async Task<int> UpdateAsync(ConsecutivoUsuario consecutivoUsuario)
    {
        await _dbContext.UpdateAsync(consecutivoUsuario,Mapper);
        return consecutivoUsuario.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new ConsecutivoUsuario
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<ConsecutivoUsuario?> BuscarCodConsecutivoUsuarioAsync(string codConsecutivoUsuario)
    {
        return await _dbContext.ConsecutivoUsuario
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodConsecutivo == codConsecutivoUsuario );
    }
}