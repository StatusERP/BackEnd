using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class MovInventarioDetRepository : StatusERPContextBase<MovInventarioDet>, IMovInventarioDetRepository
    {

        public MovInventarioDetRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<MovInventarioDet?> BuscarMovInventarioDetAsync(int movInventarioEncId, int articuloId)
        {
            return await _dbContext.MovsInventarioDet
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.MovInventarioEncId == movInventarioEncId && t.ArticuloId == articuloId);
        }

        public async Task<int> CreateAsync(MovInventarioDet movInventarioDet)
        {
            //return await _dbContext.InsertAsync(movInventarioDet);
            using (var dbContextTransaction = _dbContext.Database.BeginTransactionAsync())
            {
                bool success; 
                try
                {
                    await _dbContext.Set<MovInventarioDet>().AddAsync(movInventarioDet);
                    _dbContext.Entry(movInventarioDet).State = EntityState.Added;
                    success = await _dbContext.SaveChangesAsync() > 0;

                    // Poner aquí la inclinación adecuada para la operación que sigue.

                    //await _dbContext.Set<ExistenciaBodega>().AddAsync(existenciaBodega);
                    //_dbContext.Entry(ExistenciaBodega).State = EntityState.Modified;
                    
                    await _dbContext.Database.CommitTransactionAsync();
                }
                catch (Exception)
                {

                    await _dbContext.Database.RollbackTransactionAsync();
                    throw;
                }
                return success ? movInventarioDet.Id : 0;

            }   
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new MovInventarioDet
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<MovInventarioDet?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<MovInventarioDet>(id);
        }

        public async Task<ICollection<MovInventarioDet>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<MovInventarioDet>(page, rows);
        }

        public async Task<int> UpdateAsync(MovInventarioDet movInventarioDet)
        {
            await _dbContext.UpdateAsync(movInventarioDet,Mapper);
            return movInventarioDet.Id;
        }
    }
}
