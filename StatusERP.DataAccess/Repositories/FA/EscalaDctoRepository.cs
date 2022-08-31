using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class EscalaDctoRepository : StatusERPContextBase<EscalaDcto>, IEscalaDctoRepository
{
    public EscalaDctoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<EscalaDcto>> GetCollectionAsync()
    {
        return await _dbContext.EscalasDcto
         .Include(p => p.VersionNivelPrecio)
         .Include(p => p.Articulo)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<EscalaDcto?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<EscalaDcto>(id);
    }

    public async Task<int> CreateAsync(EscalaDcto escalaDcto)
    {
        return await _dbContext.InsertAsync(escalaDcto);
    }

    public async Task<int> UpdateAsync(EscalaDcto escalaDcto)
    {

        try
        {
            var registro = await _dbContext.Set<EscalaDcto>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == escalaDcto.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = escalaDcto.Id;
            registro.VersionNivelId = escalaDcto.VersionNivelId;
            registro.ArticuloId = escalaDcto.ArticuloId;
            registro.NumEscalaDcto = escalaDcto.NumEscalaDcto;
            registro.VersionDcto = escalaDcto.VersionDcto;
            registro.MinUnidFact = escalaDcto.MinUnidFact;
            registro.MaxUnidFact = escalaDcto.MaxUnidFact;
            registro.FechaInicioEsc = escalaDcto.FechaInicioEsc;
            registro.FechaFinEsc = escalaDcto.FechaFinEsc;
            registro.PorcDcto = escalaDcto.PorcDcto;
            registro.FechaUltModif = escalaDcto.FechaUltModif;
            registro.UsuarioUltModif = escalaDcto.UsuarioUltModif;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = escalaDcto.Updatedby;
            registro.UpdateDate = escalaDcto.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;


            _dbContext.Set<EscalaDcto>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return escalaDcto.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new EscalaDcto
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<EscalaDcto?> BuscarNumEscalaDctoAsync(int versionNivelId, int articuloId, int numEscalaDcto, int versionDcto)
    {
        return await _dbContext.EscalasDcto
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.VersionNivelId == versionNivelId && t.ArticuloId == articuloId && t.NumEscalaDcto == numEscalaDcto && t.VersionDcto == versionDcto);
    }
}