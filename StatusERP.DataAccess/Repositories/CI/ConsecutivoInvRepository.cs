using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ConsecutivoInvRepository : StatusERPContextBase<ConsecutivoInv>, IConsecutivoInvRepository
    {

        public ConsecutivoInvRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ConsecutivoInv?> BuscarCodConsecutivoInvAsync(string CodConsecutivo)
        {
            return await _dbContext.ConsecutivosInv
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodConsecutivo == CodConsecutivo);
        }

        public async Task<int> CreateAsync(ConsecutivoInv consecutivoInv)
        {
            return await _dbContext.InsertAsync(consecutivoInv);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ConsecutivoInv
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ConsecutivoInv?> GetByIdAsync(int id)
        {

            return await _dbContext.SelectAsync<ConsecutivoInv>(id);
        }


        public async Task<ICollection<ConsecutivoInv>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<ConsecutivoInv>(page, rows);
        }

        public async Task<int> UpdateAsync(ConsecutivoInv consecutivoInv)
        {
            //await _dbContext.UpdateAsync(consecutivoInv,Mapper);
            //return consecutivoInv.Id;

            try
            {
                var registro = await _dbContext.Set<ConsecutivoInv>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == consecutivoInv.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                //registro.Id = consecutivoInv.Id;
                registro.CodConsecutivo = consecutivoInv.CodConsecutivo;
                registro.UltimoUsuario = consecutivoInv.UltimoUsuario;
                registro.Descripcion  = consecutivoInv.Descripcion;
                registro.Mascara = consecutivoInv.Mascara;
                registro.SiguienteConsec  = consecutivoInv.SiguienteConsec;
                registro.Editable = consecutivoInv.Editable;
                registro.MultiplesTrans = consecutivoInv.MultiplesTrans;
                registro.FormatoImp = consecutivoInv.FormatoImp;
                registro.UltFechaHora = consecutivoInv.UltFechaHora;
                registro.TodasTrans = consecutivoInv.TodasTrans;
                registro.Tipo = consecutivoInv.Tipo;
                registro.UsaTraslado = consecutivoInv.UsaTraslado;
                registro.EmailCFDI = consecutivoInv.EmailCFDI;
                registro.IsDeleted = consecutivoInv.IsDeleted;
                registro.Updatedby = consecutivoInv.Updatedby;
                registro.UpdateDate = consecutivoInv.UpdateDate;
                registro.Createdby = consecutivoInv.Createdby;
                registro.CreateDate = consecutivoInv.CreateDate;

                _dbContext.Set<ConsecutivoInv>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return consecutivoInv.Id;
        }
    }

}
