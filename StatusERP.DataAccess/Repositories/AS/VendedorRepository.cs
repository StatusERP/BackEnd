using StatusERP.Entities.AS.Tablas;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class VendedorRepository :StatusERPContextBase<Vendedor> , IVendedorRepository
    {
        public VendedorRepository(StatusERPDBContext context,IMapper mapper)
            : base(context,mapper)
        {
        }

        public async Task<ICollection<Vendedor>> GetCollectionAsync( int page, int rows)
        {
            return await _dbContext.SelectAsync<Vendedor>( page, rows);
                
        }

        public async Task<Vendedor?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Vendedor>(id);
        }
        public async Task<int> CreateAsync(Vendedor vendedor)
        {
            return await _dbContext.InsertAsync(vendedor);   
        }

        public async Task<Vendedor?> BuscarCodVendedorAsync(string codVendedor)
        {
            return await _dbContext.Vendedores
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.CodVendedor == codVendedor );
        }
        public  async Task<int> DeleteAsync(int id,string userId)
        {
            await _dbContext.DeleteAsync(new Vendedor
            {
                Id = id,
                Updatedby = userId,
                
            });
            return id;
        }

        public async Task<int> UpdateAsync(Vendedor vendedor)
        {
            await _dbContext.UpdateAsync(vendedor, Mapper);
            return vendedor.Id;
        }
    }
}
