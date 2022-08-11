using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class CentroCuentaRepository : StatusERPContextBase<CentroCuenta>, ICentroCuentaRepository
    {

        public CentroCuentaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<CentroCuenta?> BuscarCentroCuentaAsync(int CentroCostoId, int CentroCuentaId)
        {
            return await _dbContext.CentroCuenta
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CentroCostoId == CentroCostoId && t.CuentaContableId == CentroCuentaId);
        }

        public async Task<int> CreateAsync(CentroCuenta CentroCuenta)
        {
            return await _dbContext.InsertAsync(CentroCuenta);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new CentroCuenta
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<CentroCuenta?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<CentroCuenta>(id);
        }

        public async Task<ICollection<CentroCuenta>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<CentroCuenta>(page, rows);
        }

        public async Task<int> UpdateAsync(CentroCuenta centroCuenta)
        {
            //await _dbContext.UpdateAsync(CentroCuenta,Mapper);
            //return CentroCuenta.Id;

            try
            {
                var registro = await _dbContext.Set<CentroCuenta>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == centroCuenta.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.CentroCostoId = centroCuenta.CentroCostoId;
                registro.CuentaContableId = centroCuenta.CuentaContableId;
                registro.CodCentroCosto = centroCuenta.CodCentroCosto;
                registro.CodCuentaContable = centroCuenta.CodCuentaContable;
                registro.Activo = centroCuenta.Activo;
                registro.IsDeleted = centroCuenta.IsDeleted;
                registro.Updatedby = centroCuenta.Updatedby;
                registro.UpdateDate = centroCuenta.UpdateDate;
                registro.Createdby = centroCuenta.Createdby;
                registro.CreateDate = centroCuenta.CreateDate;

                _dbContext.Set<CentroCuenta>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return centroCuenta.Id;

        }
    }
}
