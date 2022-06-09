using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities;

namespace StatusERP.DataAccess
{
    public static class DbContextExtensions
    {
        public static async Task<ICollection< TEntityBase>> SelectAsync<TEntityBase>( this DbContext context ,int page , int rows)
        where TEntityBase : EntityBase
        {
            return await context.Set<TEntityBase>()
                .Where(p => !p.IsDeleted)
                .AsNoTracking()
                 .Skip((page - 1) * rows)
                .Take(rows)
                .ToListAsync();
        }
        public static async Task<TEntityBase?> SelectAsync<TEntityBase>(this DbContext context, int id)
        where TEntityBase : EntityBase
        {
            return await context.Set<TEntityBase>()
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Id == id &&  !t.IsDeleted);
        }
        
        public static async Task<int> InsertAsync<TEntityBase>(this DbContext context, TEntityBase entity)
            where TEntityBase : EntityBase
        {
            bool success;
            try
            {
                await context.Database.BeginTransactionAsync();
                await context.Set<TEntityBase>().AddAsync(entity);
                context.Entry(entity).State = EntityState.Added;
                
                success = await context.SaveChangesAsync() > 0;
                await context.Database.CommitTransactionAsync();
            }
            catch (Exception)
            {

                await context.Database.RollbackTransactionAsync();
                throw;
            }

            

            return success ? entity.Id : 0;
        }
        public static async Task UpdateAsync<TEntityBase>(this DbContext context, TEntityBase entity, IMapper mapper)
           where TEntityBase : EntityBase
        {
            var registro = await context.Set<TEntityBase>()
                .AsTracking()
                .SingleOrDefaultAsync(x => x.Id == entity.Id);
            if (registro == null) return;

            mapper.Map(entity, registro);

            // context.Entry(registro).State = EntityState.Modified;

            await context.SaveChangesAsync();
        }
        public static async Task Update2Async<TEntityBase>(this DbContext context, TEntityBase entity)
           where TEntityBase : EntityBase
        {
            
             context.Set<TEntityBase>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            // context.Entry(registro).State = EntityState.Modified;

            await context.SaveChangesAsync();
        }

        public static async Task DeleteAsync<TEntityBase>(this DbContext context, TEntityBase entity)
           where TEntityBase : EntityBase
        {
            try
            {
                var registro = await context.Set<TEntityBase>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == entity.Id && !x.IsDeleted);
                if (registro == null) return;

                registro.IsDeleted = true;
                registro.UpdateDate = DateTime.Now;
                registro.Updatedby = entity.Updatedby;


                context.Set<TEntityBase>().Attach(registro);
                //    context.Entry(registro).State = EntityState.Modified;
                context.Entry(registro).State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        
        }
    }
}
