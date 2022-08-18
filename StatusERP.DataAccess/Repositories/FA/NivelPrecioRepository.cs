using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class NivelPrecioRepository:StatusERPContextBase<NivelPrecio>,INivelPrecioRepository
{
    public NivelPrecioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<NivelPrecio>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<NivelPrecio>(page, rows);
    }

    public async Task<NivelPrecio?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<NivelPrecio>(id);
    }

    public async Task<int> CreateAsync(NivelPrecio nivelPrecio)
    {
        return await _dbContext.InsertAsync(nivelPrecio);
    }

    public async Task<int> UpdateAsync(NivelPrecio nivelPrecio)
    {
        //await _dbContext.UpdateAsync(nivelPrecio,Mapper);
        //return nivelPrecio.Id;

        try
        {
            var registro = await _dbContext.Set<NivelPrecio>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == nivelPrecio.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.CodNivelPrecio = nivelPrecio.CodNivelPrecio;
            registro.Id = nivelPrecio.Id;
            registro.CondicionPagoId = nivelPrecio.CondicionPagoId;
            registro.Moneda = nivelPrecio.Moneda;
            registro.EsquemaTrabajo = nivelPrecio.EsquemaTrabajo;
            registro.Descuentos = nivelPrecio.Descuentos;
            registro.SugerirDescuento = nivelPrecio.SugerirDescuento;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = nivelPrecio.Updatedby;
            registro.UpdateDate = nivelPrecio.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;


            _dbContext.Set<NivelPrecio>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return nivelPrecio.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new NivelPrecio
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<NivelPrecio?> BuscarCodNivelPrecioAsync(string codNivelPrecio)
    {
        return await _dbContext.NivelesPrecio
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodNivelPrecio == codNivelPrecio );
    }
}