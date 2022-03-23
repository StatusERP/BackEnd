using AutoMapper;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class UsuarioBodegaRepository:StatusERPContextBase<UsuarioBodega>,IUsuarioBodegaRepository
{
    public UsuarioBodegaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<UsuarioBodega>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<UsuarioBodega>(page, rows);
    }

    public async Task<UsuarioBodega?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<UsuarioBodega>(id);
    }

    public async Task<int> CreateAsync(UsuarioBodega usuarioBodega)
    {
        return await _dbContext.InsertAsync(usuarioBodega);
    }

    public async Task<int> UpdateAsync(UsuarioBodega usuarioBodega)
    {
        await _dbContext.UpdateAsync(usuarioBodega,Mapper);
        return usuarioBodega.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new UsuarioBodega
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }


}