using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class ZonaRepository : StatusERPContextBase<Zona>, IZonaRepository
{
    public ZonaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Zona>> GetCollectionAsync()
    {
        return await _dbContext.Zonas
        .Where(p => !p.IsDeleted)
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<Zona?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Zona>(id);
    }

    public async Task<int> CreateAsync(Zona zona)
    {
        return await _dbContext.InsertAsync(zona);
    }

    public async Task<int> UpdateAsync(Zona zona)
    {

        try
        {
            var registro = await _dbContext.Set<Zona>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == zona.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = zona.Id;
            registro.CodZona = zona.CodZona;
            registro.Descripcion = zona.Descripcion;
            registro.Activa = zona.Activa;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = zona.Updatedby;
            registro.UpdateDate = zona.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<Zona>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return zona.Id;

    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Zona
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<Zona?> BuscarCodZonaAsync(string codZona)
    {
        return await _dbContext.Zonas
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodZona == codZona);
    }
}