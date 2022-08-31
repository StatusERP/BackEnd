using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class EscalaBonifRepository : StatusERPContextBase<EscalaBonif>, IEscalaBonifRepository
{
    public EscalaBonifRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<EscalaBonif>> GetCollectionAsync()
    {
        return await _dbContext.EscalasBonif
         .Include(p => p.VersionNivelPrecio)
         .Include(p => p.Articulo)
         .Include(p => p.ArticuloBonif)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<EscalaBonif?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<EscalaBonif>(id);
    }

    public async Task<int> CreateAsync(EscalaBonif escalaBonif)
    {
        return await _dbContext.InsertAsync(escalaBonif);
    }

    public async Task<int> UpdateAsync(EscalaBonif escalaBonif)
    {

        try
        {
            var registro = await _dbContext.Set<EscalaBonif>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == escalaBonif.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = escalaBonif.Id;
            registro.VersionNivelId = escalaBonif.VersionNivelId;
            registro.ArticuloId = escalaBonif.ArticuloId;
            registro.NumEscalaBonif = escalaBonif.NumEscalaBonif;
            registro.VersionBonif = escalaBonif.VersionBonif;
            registro.ArticuloBonifId = escalaBonif.ArticuloBonifId;
            registro.MinArtFact = escalaBonif.MinArtFact;
            registro.MaxArtFact = escalaBonif.MaxArtFact;
            registro.UnidadesBonif = escalaBonif.UnidadesBonif;
            registro.FechaInicioEsc = escalaBonif.FechaInicioEsc;
            registro.FechaFinEsc = escalaBonif.FechaFinEsc;
            registro.FactorBonif = escalaBonif.FactorBonif;
            registro.FechaUltModif = escalaBonif.FechaUltModif;
            registro.UsuarioUltModif = escalaBonif.UsuarioUltModif;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = escalaBonif.Updatedby;
            registro.UpdateDate = escalaBonif.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;


            _dbContext.Set<EscalaBonif>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return escalaBonif.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new EscalaBonif
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<EscalaBonif?> BuscarNumEscalaBonifAsync(int versionNivelId, int articuloId, int numEscalaBonif, int versionBonif)
    {
        return await _dbContext.EscalasBonif
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.VersionNivelId == versionNivelId  && t.ArticuloId == articuloId && t.NumEscalaBonif == numEscalaBonif && t.VersionBonif == versionBonif);
    }
}