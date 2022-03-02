using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.DataAccess
{
    public static class DbContextExtensions
    {
        public static async Task<ICollection< TEntityBase>> SelectAsync<TEntityBase>( this DbContext context ,int conjunto ,int page , int rows)
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
        public static async Task UpdateAsync<TEntityBase>(this DbContext context, TEntityBase entity,IMapper mapper)
            where TEntityBase : EntityBase
        {
            var registro = await context.Set<TEntityBase>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == entity.Id);
            if (registro == null) return;

            registro = mapper.Map<TEntityBase>(entity);
            context.Entry(registro).State = EntityState.Modified;
            
            await context.SaveChangesAsync();
        }
        public static async Task DeleteAsync<TEntityBase>(this DbContext context, TEntityBase entity)
           where TEntityBase : EntityBase
        {
            var registro = await context.Set<TEntityBase>()
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == entity.Id);
            if (registro == null) return;

            registro.IsDeleted = true;
            
            context.Set<EntityBase>().Attach(registro);
            context.Entry(registro).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
