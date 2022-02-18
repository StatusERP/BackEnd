using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS
{
    public class VendedorService : IVendedorService

    {
        private readonly IVendedorRepository _repository;

        public VendedorService(IVendedorRepository repository)
        {
            _repository = repository;
        }
        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoVendedor request)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponseGeneric<int>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public  async Task<BaseResponseGeneric<ICollection<Vendedor>>> GetAsync(int conjunto)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponseGeneric<Vendedor>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoVendedor request)
        {
            throw new NotImplementedException();
        }
    }
}
