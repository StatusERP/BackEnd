using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class MetodoPagoRepository : StatusERPContextBase<MetodoPago>, IMetodoPagoRepository
{
    public MetodoPagoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<MetodoPago>> GetCollectionAsync()
    {
        return await _dbContext.MetodosPago
        .Where(p => !p.IsDeleted)
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<MetodoPago?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<MetodoPago>(id);
    }

    public async Task<int> CreateAsync(MetodoPago metodoPago)
    {
        return await _dbContext.InsertAsync(metodoPago);
    }

    public async Task<int> UpdateAsync(MetodoPago metodoPago)
    {

        try
        {
            var registro = await _dbContext.Set<MetodoPago>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == metodoPago.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = metodoPago.Id;
            registro.CodMetodoPago = metodoPago.CodMetodoPago;
            registro.Descripcion = metodoPago.Descripcion;
            registro.Activo = metodoPago.Activo;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = metodoPago.Updatedby;
            registro.UpdateDate = metodoPago.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<MetodoPago>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return metodoPago.Id;

    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new MetodoPago
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<MetodoPago?> BuscarCodMetodoPagoAsync(string codMetodoPago)
    {
        return await _dbContext.MetodosPago
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodMetodoPago == codMetodoPago);
    }
}