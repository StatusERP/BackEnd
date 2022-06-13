using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class GlobalesCIRepository : StatusERPContextBase<GlobalesCI>, IGlobalesCIRepository
    {

        public GlobalesCIRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public async Task<int> CreateAsync(GlobalesCI GlobalesCI)
        {
            return await _dbContext.InsertAsync(GlobalesCI);
        }


        public async Task<int> UpdateAsync(GlobalesCI GlobalesCI)
        {
            await _dbContext.UpdateAsync(GlobalesCI,Mapper);
            return GlobalesCI.Id;
        }

        public async Task<ICollection<GlobalesCI>> GetAllAsync()
        {

            return await _dbContext.Set<GlobalesCI>()
                   .Where(p => !p.IsDeleted)
                   .AsNoTracking()
                   .ToListAsync();
        }
    }
}