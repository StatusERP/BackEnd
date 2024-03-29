﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.CI.Tablas;

namespace StatusERP.DataAccess.Repositories.CI
{
    public class ConsecutivoInvUsuarioRepository : StatusERPContextBase<ConsecutivoInvUsuario>, IConsecutivoInvUsuarioRepository
    {

        public ConsecutivoInvUsuarioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<ConsecutivoInvUsuario?> BuscarConsecutivoInvUsuarioAsync(int consecutivo, int usuario)
        {
            return await _dbContext.ConsecutivosInvUsuarios
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Consecutivo == consecutivo && t.Usuario == usuario);
        }

        public async Task<int> CreateAsync(ConsecutivoInvUsuario consecutivoInvUsuario)
        {
            return await _dbContext.InsertAsync(consecutivoInvUsuario);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new ConsecutivoInvUsuario
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<ConsecutivoInvUsuario?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<ConsecutivoInvUsuario>(id);
        }

        public async Task<ICollection<ConsecutivoInvUsuario>> GetCollectionAsync()
        {

            return await _dbContext.Set<ConsecutivoInvUsuario>()
               .Where(p => !p.IsDeleted)
              .AsNoTracking()
              .ToListAsync();
            
        }

        public async Task<int> UpdateAsync(ConsecutivoInvUsuario consecutivoInvUsuario)
        {
            await _dbContext.UpdateAsync(consecutivoInvUsuario,Mapper);
            return consecutivoInvUsuario.Id;
        }
    }

}
