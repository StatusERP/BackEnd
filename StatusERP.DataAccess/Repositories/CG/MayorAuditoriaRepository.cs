using AutoMapper;
using StatusERP.Entities.CG.Tablas;

namespace StatusERP.DataAccess.Repositories.CG
{
    public class MayorAuditoriaRepository : StatusERPContextBase<MayorAuditoria>, IMayorAuditoriaRepository
    {

        public MayorAuditoriaRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<int> CreateAsync(MayorAuditoria MayorAuditoria)
        {
            return await _dbContext.InsertAsync(MayorAuditoria);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new MayorAuditoria
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<MayorAuditoria?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<MayorAuditoria>(id);
        }

        public async Task<ICollection<MayorAuditoria>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<MayorAuditoria>(page, rows);
        }

        public async Task<int> UpdateAsync(MayorAuditoria MayorAuditoria)
        {
            await _dbContext.UpdateAsync(MayorAuditoria);
            return MayorAuditoria.Id;
        }
    }
}