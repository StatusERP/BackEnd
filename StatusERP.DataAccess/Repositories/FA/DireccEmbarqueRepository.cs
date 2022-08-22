using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.FA.Tablas;
using StatusERP.DataAccess.Repositories.FA.Interfaces;

namespace StatusERP.DataAccess.Repositories.FA
{
    public class DireccEmbarqueRepository : StatusERPContextBase<DireccEmbarque>, IDireccEmbarqueRepository
    {

        public DireccEmbarqueRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<DireccEmbarque?> BuscarDireccEmbarqueAsync(int clienteId, string direccion)
        {
            return await _dbContext.DireccEmbarques
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.ClienteId == clienteId && t.Direccion == direccion);
        }

        public async Task<int> CreateAsync(DireccEmbarque direccionEmbarque)
        {
            return await _dbContext.InsertAsync(direccionEmbarque);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new DireccEmbarque
            {
                Id = id,
                Updatedby = userId
            });     
            return id;
        }

        public async Task<DireccEmbarque?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<DireccEmbarque>(id);
        }

        public async Task<ICollection<DireccEmbarque>> GetCollectionAsync()

        {

            return await _dbContext.DireccEmbarques
              .Where(p => !p.IsDeleted)
              .AsNoTracking()
              .ToListAsync();
        }

        public async Task<int> UpdateAsync(DireccEmbarque direccEmbarque)
        {

            try
            {
                var registro = await _dbContext.Set<DireccEmbarque>()
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == direccEmbarque.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }

                registro.Id = direccEmbarque.Id;
                registro.ClienteId = direccEmbarque.ClienteId;
                registro.Direccion = direccEmbarque.Direccion;
                registro.DetalleDireccionId = direccEmbarque.DetalleDireccionId;
                registro.Descripcion = direccEmbarque.Descripcion;
                registro.Contacto = direccEmbarque.Contacto;
                registro.Cargo = direccEmbarque.Cargo;
                registro.Telefono1 = direccEmbarque.Telefono1;
                registro.Telefono2 = direccEmbarque.Telefono2;
                registro.Fax = direccEmbarque.Fax;
                registro.Email = direccEmbarque.Email;
                registro.IsDeleted = registro.IsDeleted;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;
                registro.Updatedby = direccEmbarque.Updatedby;
                registro.UpdateDate = direccEmbarque.UpdateDate;

                _dbContext.Set<DireccEmbarque>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }

            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return direccEmbarque.Id;
        }
    }
}