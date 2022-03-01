using StatusERP.Entities.AS.Tablas;
using AutoMapper;
namespace StatusERP.DataAccess.Repositories.AS
{
    public class VendedorRepository :StatusERPContextBase<Vendedor> , IVendedorRepository
    {
        public VendedorRepository(StatusERPDBContext context,IMapper mapper)
            : base(context,mapper)
        {
        }

        public async Task<ICollection<Vendedor>> GetCollectionAsync(int conjunto, int page, int rows)
        {
            return await _dbContext.SelectAsync<Vendedor>(conjunto, page, rows);
                
        }

        public async Task<Vendedor?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Vendedor>(id);
        }
        public async Task<int> CreateAsync(Vendedor vendedor)
        {
            return await _dbContext.InsertAsync(vendedor);   
        }

        public  async Task<int> DeleteAsync(int id)
        {
            await _dbContext.DeleteAsync(new Vendedor
            {
                Id = id
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
