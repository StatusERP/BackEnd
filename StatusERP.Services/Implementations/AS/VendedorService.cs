using Microsoft.Extensions.Logging;
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
        private readonly ILogger<VendedorService> _logger;

        public VendedorService(IVendedorRepository repository, ILogger<VendedorService> logger) 
        {
            _repository = repository;
            _logger = logger;   
        }
        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoVendedor request)
        {
            var response =new BaseResponseGeneric<int>();
            try
            {
                response.Result = await _repository.CreateAsync(new Vendedor
                {
                    CodVendedor = request.CodVendedor,
                    Nombre = request.Nombre,
                    Email = request.Email,
                    Activo = true,
                    ConjuntoId = request.ConjutoId,
                    Updatedby = "SA",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Createdby = "SA",
                });
                response.Success = true;

            }
            catch (Exception ex)
            {

                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            }
            return response;
        }

        public async Task<BaseResponseGeneric<int>> DeleteAsync(int id)
        {
            var response =new BaseResponseGeneric<int>();
            try
            {
                await _repository.DeleteAsync(id);
                response.Success = true;
                response.Result = id;
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);

            }
            return response;
        }

        public  async Task<BaseResponseGeneric<ICollection<Vendedor>>> GetAsync(int conjunto,int page,int rows)
        {
            var response =new BaseResponseGeneric<ICollection <Vendedor>>();
            try
            {
                response.Result = await _repository.GetCollectionAsync(conjunto, page, rows);
                response.Success=true;

            }
            catch (Exception ex)
            {

                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            }
            return response;
        }

        public async Task<BaseResponseGeneric<Vendedor>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Vendedor>();
            try
            {
                response.Result= await _repository.GetByIdAsync(id)?? new Vendedor();
                response.Success=true;
            }
            catch (Exception ex)
            {

                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            }
            return response;
        }

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoVendedor request)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                response.Result = await _repository.UpdateAsync(new Vendedor
                {
                    Id = id,
                    Nombre = request.Nombre,
                    Email = request.Email,
                    Activo=request.Activo,
                    CodVendedor = request.CodVendedor,
            });
            }
            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
                throw;
            }
            return response;
        }
    }
}
