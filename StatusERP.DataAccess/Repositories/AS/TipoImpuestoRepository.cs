using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class TipoImpuestoRepository : StatusERPContextBase<TipoImpuesto>, ITipoImpuestoRepository
{
    public TipoImpuestoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<TipoImpuesto>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<TipoImpuesto>(page, rows);
    }

    public async Task<TipoImpuesto?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<TipoImpuesto>(id);
    }

    public async Task<int> CreateAsync(TipoImpuesto tipoImpuesto)
    {
        return await _dbContext.InsertAsync(tipoImpuesto);
    }

    public async Task<int> UpdateAsync(TipoImpuesto tipoImpuesto)
    {
        //await _dbContext.UpdateAsync(tipoImpuesto,Mapper);
        //return tipoImpuesto.Id;

        try
        {
            var registro = await _dbContext.Set<TipoImpuesto>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == tipoImpuesto.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = tipoImpuesto.Id;
            registro.CodTipoImpuesto = tipoImpuesto.CodTipoImpuesto;
            registro.Descripcion = tipoImpuesto.Descripcion;
            registro.Activo = registro.Activo; 
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = tipoImpuesto.Updatedby;
            registro.UpdateDate = tipoImpuesto.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<TipoImpuesto>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return tipoImpuesto.Id;

    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new TipoImpuesto
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<TipoImpuesto?> BuscarCodTipoImpuestoAsync(string codTipoImpuesto)
    {
        return await _dbContext.TiposImpuesto 
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoImpuesto == codTipoImpuesto);
    }
}