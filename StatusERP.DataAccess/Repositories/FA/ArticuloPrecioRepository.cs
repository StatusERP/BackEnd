using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class ArticuloPrecioRepository : StatusERPContextBase<ArticuloPrecio>, IArticuloPrecioRepository
{
    public ArticuloPrecioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<ArticuloPrecio>> GetCollectionAsync()
    {
        return await _dbContext.ArticuloPrecios
         .Include(p => p.VersionNivelPrecio)
         .Include(p => p.Articulo)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<ArticuloPrecio?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<ArticuloPrecio>(id);
    }

    public async Task<int> CreateAsync(ArticuloPrecio articuloPrecio)
    {
        return await _dbContext.InsertAsync(articuloPrecio);
    }

    public async Task<int> UpdateAsync(ArticuloPrecio articuloPrecio)
    {

        try
        {
            var registro = await _dbContext.Set<ArticuloPrecio>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == articuloPrecio.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = articuloPrecio.Id;
            registro.VersionNivelId = articuloPrecio.VersionNivelId;
            registro.ArticuloId = articuloPrecio.ArticuloId;
            registro.VersionArticulo = articuloPrecio.VersionArticulo;
            registro.Precio = articuloPrecio.Precio;
            registro.EsquemaTrabajo = articuloPrecio.EsquemaTrabajo;
            registro.MargenMULR = articuloPrecio.MargenMULR;
            registro.MargenUtilidad = articuloPrecio.MargenUtilidad;
            registro.FechaInicio = articuloPrecio.FechaInicio;
            registro.FechaFin = articuloPrecio.FechaFin;
            registro.FechaUltModif = articuloPrecio.FechaUltModif;
            registro.UsuarioUltModif = articuloPrecio.UsuarioUltModif;
            registro.MargenUtilidadMin = articuloPrecio.MargenUtilidadMin;
            registro.IsDeleted = articuloPrecio.IsDeleted;
            registro.Updatedby = articuloPrecio.Updatedby;
            registro.UpdateDate = articuloPrecio.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<ArticuloPrecio>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return articuloPrecio.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new ArticuloPrecio
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<ArticuloPrecio?> BuscarArticuloPrecioAsync(int versionNivelId, int articuloId, int versionArticulo)
    {
        return await _dbContext.ArticuloPrecios
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.VersionNivelId == versionNivelId && t.ArticuloId == articuloId && t.VersionArticulo == versionArticulo);
    }
}