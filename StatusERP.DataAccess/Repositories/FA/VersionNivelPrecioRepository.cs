using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class VersionNivelPrecioRepository : StatusERPContextBase<NivelPrecio>, IVersionNivelPrecioRepository
{
    public VersionNivelPrecioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<VersionNivelPrecio>> GetCollectionAsync()
    {
        return await _dbContext.VersionesNivelPrecio
        .Include(p => p.NivelPrecio)
        .Where(p => !p.IsDeleted)
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<VersionNivelPrecio?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<VersionNivelPrecio>(id);
    }

    public async Task<int> CreateAsync(VersionNivelPrecio versionNivelPrecio)
    {
        return await _dbContext.InsertAsync(versionNivelPrecio);
    }

    public async Task<int> UpdateAsync(VersionNivelPrecio versionNivelPrecio)
    {

        try
        {
         var registro = await _dbContext.Set<VersionNivelPrecio>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == versionNivelPrecio.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = versionNivelPrecio.Id;
            registro.NivelPrecioId = versionNivelPrecio.NivelPrecioId;
            registro.Version = versionNivelPrecio.Version;
            registro.FechaInicio = versionNivelPrecio.FechaInicio;
            registro.FechaCorte = versionNivelPrecio.FechaCorte;
            registro.Estado = versionNivelPrecio.Estado;
            registro.UsuarioCreacion = versionNivelPrecio.UsuarioCreacion;
            registro.FechaHoraCreacion = versionNivelPrecio.FechaHoraCreacion;
            registro.UsuarioUltModif = versionNivelPrecio.UsuarioUltModif;
            registro.FechaHoraUltModif = versionNivelPrecio.FechaHoraUltModif;
            registro.UsuarioAprobacion = versionNivelPrecio.UsuarioAprobacion;
            registro.FechaHoraAprobacion = versionNivelPrecio.FechaHoraAprobacion;
            registro.UsuarioAnulacion = versionNivelPrecio.UsuarioAnulacion;
            registro.FechaHoraAnulacion = versionNivelPrecio.FechaHoraAnulacion;
            registro.Identificador = versionNivelPrecio.Identificador;
            registro.Impuesto1Incluido = versionNivelPrecio.Impuesto1Incluido;
            registro.PrecioReferenciaDE = versionNivelPrecio.PrecioReferenciaDE;
            registro.SincMovil = versionNivelPrecio.SincMovil;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = versionNivelPrecio.Updatedby;
            registro.UpdateDate = versionNivelPrecio.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;


            _dbContext.Set<VersionNivelPrecio>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return versionNivelPrecio.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new VersionNivelPrecio
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<VersionNivelPrecio?> BuscarVersionNivelPrecioIdAsync(int nivelPrecioId, int version)
    {
        return await _dbContext.VersionesNivelPrecio
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.NivelPrecioId == nivelPrecioId && t.Version == version);
    }
}