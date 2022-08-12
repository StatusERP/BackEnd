using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class CondicionPagoRepository:StatusERPContextBase<CondicionPago>,ICondicionPagoRepository
{
    public CondicionPagoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<CondicionPago>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<CondicionPago>(page, rows);
    }

    public  async Task<CondicionPago?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<CondicionPago>(id);
    }

    public async Task<int> CreateAsync(CondicionPago condicionPago)
    {
        return await _dbContext.InsertAsync(condicionPago);
    }

    public async Task<int> UpdateAsync(CondicionPago condicionPago)
    {
        //await _dbContext.UpdateAsync(condicionPago,Mapper);
        //return condicionPago.Id;

        try
        {
            var registro = await _dbContext.Set<CondicionPago>()
           .AsNoTracking()
           .SingleOrDefaultAsync(x => x.Id == condicionPago.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }
            registro.Id = condicionPago.Id;
            registro.CodCondicionPago = condicionPago.CodCondicionPago;
            registro.Descripcion = condicionPago.Descripcion;
            registro.DiasNeto = condicionPago.DiasNeto;
            registro.PagosParciales = condicionPago.PagosParciales;
            registro.DescuentoContado = condicionPago.DescuentoContado;
            registro.TipoCondPago = condicionPago.TipoCondPago;
            registro.PlazoCondPago = condicionPago.PlazoCondPago;
            registro.Activa = condicionPago.Activa;
            registro.IsDeleted = registro.IsDeleted;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;
            registro.Updatedby = condicionPago.Updatedby;
            registro.UpdateDate = condicionPago.UpdateDate;

            _dbContext.Set<CondicionPago>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return condicionPago.Id;


    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new CondicionPago
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<CondicionPago?> BuscarCodCondicionPagoAsync(string codCondicionPago)
    {
        return await _dbContext.CondicionesPago
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodCondicionPago == codCondicionPago );
    }
}