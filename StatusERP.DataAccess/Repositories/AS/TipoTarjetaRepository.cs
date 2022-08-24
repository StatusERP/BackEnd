using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class TipoTarjetaRepository : StatusERPContextBase<TipoTarjeta>, ITipoTarjetaRepository
{
    public TipoTarjetaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<TipoTarjeta>> GetCollectionAsync()
    {
        return await _dbContext.TiposTarjeta
        .Where(p => !p.IsDeleted)
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<TipoTarjeta?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<TipoTarjeta>(id);
    }

    public async Task<int> CreateAsync(TipoTarjeta tipoTarjeta)
    {
        return await _dbContext.InsertAsync(tipoTarjeta);
    }

    public async Task<int> UpdateAsync(TipoTarjeta tipoTarjeta)
    {

        try
        {
            var registro = await _dbContext.Set<TipoTarjeta>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == tipoTarjeta.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = tipoTarjeta.Id;
            registro.CodTipoTarjeta = tipoTarjeta.CodTipoTarjeta;
            registro.TipoCobro = tipoTarjeta.TipoCobro;
            registro.AssemblyInvocation = registro.AssemblyInvocation;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = tipoTarjeta.Updatedby;
            registro.UpdateDate = tipoTarjeta.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<TipoTarjeta>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return tipoTarjeta.Id;

    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new TipoTarjeta
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<TipoTarjeta?> BuscarCodTipoTarjetaAsync(string codTipoTarjeta)
    {
        return await _dbContext.TiposTarjeta
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodTipoTarjeta == codTipoTarjeta);
    }
}