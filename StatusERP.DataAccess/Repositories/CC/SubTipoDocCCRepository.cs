using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.CC.Interfaces;
using StatusERP.Entities.CC.Tablas;

namespace StatusERP.DataAccess.Repositories.CC;

public class SubTipoDocCCRepository : StatusERPContextBase<SubTipoDocCC>, ISubTipoDocCCRepository
{
    public SubTipoDocCCRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<SubTipoDocCC>> GetCollectionAsync()
    {
        return await _dbContext.SubTiposDocCC
         .Include(p => p.subTipoDocCB)
         .Include(p => p.centroCuenta)
         .Include(p => p.paqueteContable)
         .Include(p => p.tipoPartida)
         .Include(p => p.consecutivoFA)
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<SubTipoDocCC?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<SubTipoDocCC>(id);
    }

    public async Task<int> CreateAsync(SubTipoDocCC subTipoDocCC)
    {
        return await _dbContext.InsertAsync(subTipoDocCC);
    }

    public async Task<int> UpdateAsync(SubTipoDocCC subTipoDocCC)
    {

        try
        {
            var registro = await _dbContext.Set<SubTipoDocCC>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == subTipoDocCC.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }
            registro.Id = subTipoDocCC.Id;
            registro.Tipo = subTipoDocCC.Tipo;
            registro.Subtipo= subTipoDocCC.Subtipo;
            registro.Descripcion = subTipoDocCC.Descripcion;
            registro.CalculaImp2 = subTipoDocCC.CalculaImp2;
            registro.DocumentoGlobal = subTipoDocCC.DocumentoGlobal;
            registro.ConceptoNC = subTipoDocCC.ConceptoNC;
            registro.ConceptoFAC = subTipoDocCC.ConceptoFAC;
            registro.ConceptoND = subTipoDocCC.ConceptoND;
            registro.TipoDoc = subTipoDocCC.TipoDoc;
            registro.TipoOperacFac = subTipoDocCC.TipoOperacFac;
            registro.TipoOperacNC = subTipoDocCC.TipoOperacNC;
            registro.TipoOperacND = subTipoDocCC.TipoOperacND;
            registro.CentroCuentaId = subTipoDocCC.CentroCuentaId;
            registro.ConsecutivoFacId = subTipoDocCC.ConsecutivoFacId;
            registro.PaqueteId = subTipoDocCC.PaqueteId;
            registro.SubTipoCBId = subTipoDocCC.SubTipoCBId;
            registro.TipoPartidaId = subTipoDocCC.TipoPartidaId;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = subTipoDocCC.Updatedby;
            registro.UpdateDate = subTipoDocCC.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;


            _dbContext.Set<SubTipoDocCC>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return subTipoDocCC.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new SubTipoDocCC
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<SubTipoDocCC?> BuscarSubTipoDocCCAsync(string tipo, int subTipo)
    {
        return await _dbContext.SubTiposDocCC
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Tipo == tipo && t.Subtipo == subTipo);
    }
}