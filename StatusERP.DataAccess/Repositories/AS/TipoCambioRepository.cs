using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class TipoCambioRepository:StatusERPContextBase<TipoCambio>,ITipoCambioRepository
{
    public TipoCambioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<TipoCambio>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<TipoCambio>(page, rows);
    }

    public async Task<TipoCambio?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<TipoCambio>(id);
    }

    public async Task<int> CreateAsync(TipoCambio tipoCambio)
    {
        return await _dbContext.InsertAsync(tipoCambio);
    }

    public async Task<int> UpdateAsync(TipoCambio tipoCambio)
    {
        //await _dbContext.UpdateAsync(tipoCambio,Mapper);
        //return tipoCambio.Id;

        try
        {
            var registro = await _dbContext.Set<TipoCambio>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == tipoCambio.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.CodTipoCambio = tipoCambio.CodTipoCambio;
            registro.Descripcion = tipoCambio.Descripcion;
            registro.Createdby = tipoCambio.Createdby;
            registro.IsDeleted = tipoCambio.IsDeleted;
            registro.Updatedby = tipoCambio.Updatedby;
            registro.UpdateDate = tipoCambio.UpdateDate;
            registro.Createdby = tipoCambio.Createdby;
            registro.CreateDate = tipoCambio.CreateDate;



            _dbContext.Set<TipoCambio>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return tipoCambio.Id;


    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new TipoCambio
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<TipoCambio?> BuscarCodTipoCambioAsync(string codTipoCambio)
    {
        return await _dbContext.TiposCambio
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoCambio == codTipoCambio );


    }
}