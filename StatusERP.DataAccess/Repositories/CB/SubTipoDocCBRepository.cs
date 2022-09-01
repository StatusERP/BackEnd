using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.CB.Interfaces;
using StatusERP.Entities.CB.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class SubTipoDocCBRepository : StatusERPContextBase<SubTipoDocCB>, ISubTipoDocCBRepository
{
    public SubTipoDocCBRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<SubTipoDocCB>> GetCollectionAsync()
    {
        return await _dbContext.SubTiposDocCB
         .Include(p => p.centroCuenta)
         .Include(p => p.paqueteContable)
         .Include(p => p.tipoPartida)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<SubTipoDocCB?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<SubTipoDocCB>(id);
    }

    public async Task<int> CreateAsync(SubTipoDocCB subTipoDocCB)
    {
        return await _dbContext.InsertAsync(subTipoDocCB);
    }

    public async Task<int> UpdateAsync(SubTipoDocCB subTipoDocCB)
    {

        try
        {
            var registro = await _dbContext.Set<SubTipoDocCB>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == subTipoDocCB.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Tipo  = subTipoDocCB.Tipo;
            registro.SubTipo = subTipoDocCB.SubTipo;
            registro.Descripcion = subTipoDocCB.Descripcion;
            registro.CentroCuentaId = subTipoDocCB.CentroCuentaId;
            registro.PaqueteId = subTipoDocCB.PaqueteId;
            registro.TipoPartidaId = subTipoDocCB.TipoPartidaId;
            registro.DocumentoGlobal = subTipoDocCB.DocumentoGlobal;
            registro.RubroCF = subTipoDocCB.RubroCF;
            registro.RubroPadre = subTipoDocCB.RubroPadre;
            registro.FlujoCaja = subTipoDocCB.FlujoCaja;
            registro.NaturalezaCF = subTipoDocCB.NaturalezaCF;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = subTipoDocCB.Updatedby;
            registro.UpdateDate = subTipoDocCB.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;


            _dbContext.Set<SubTipoDocCB>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return subTipoDocCB.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new SubTipoDocCB
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<SubTipoDocCB?> BuscarSubTipoDocCBAsync(string tipo, int subTipo)
    {
        return await _dbContext.SubTiposDocCB 
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Tipo == tipo && t.SubTipo == subTipo);
    }
}
