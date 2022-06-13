using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class UnidadMedidaRepository:StatusERPContextBase<UnidadMedida>,IUnidadMedidaRepository
{
    public UnidadMedidaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<UnidadMedida>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<UnidadMedida>(page, rows);
    }

    public async Task<UnidadMedida?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<UnidadMedida>(id);
    }

    public async Task<int> CreateAsync(UnidadMedida unidadMedida)
    {
        return await _dbContext.InsertAsync(unidadMedida);
    }

    public async Task <int> UpdateAsync(UnidadMedida unidadMedida)
    {

        var registro = await _dbContext.Set<UnidadMedida>()
              .AsTracking()
              .SingleOrDefaultAsync(x => x.Id == unidadMedida.Id);
        //if (registro == null) return;

        Mapper.Map(registro,unidadMedida);

        // context.Entry(registro).State = EntityState.Modified;

        await _dbContext.SaveChangesAsync();


      //  await _dbContext.UpdateAsync(unidadMedida,Mapper);
        return unidadMedida.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new UnidadMedida
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<UnidadMedida?> BuscarCodUnidadMedidaAsync(string codUnidadMedida)
    {
        return await _dbContext.UnidadesMedida
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodUnidadMedida == codUnidadMedida );
    }
}