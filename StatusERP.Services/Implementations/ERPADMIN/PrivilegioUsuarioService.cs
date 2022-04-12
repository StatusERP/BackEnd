using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.ERPADMIN;
using StatusERP.Dto.Response;
using StatusERP.Entities.ERPADMIN.Tablas;
using StatusERP.Services.Interfaces.ERPADMIN;

namespace StatusERP.Services.Implementations.ERPADMIN
{
    public class PrivilegioUsuarioService : IPrivilegioUsuarioService
    {
        
        private readonly IPrivilegioUsuarioRepository _repository;
        private readonly ILogger<PrivilegioUsuarioService> _logger;

        public PrivilegioUsuarioService(IPrivilegioUsuarioRepository repository,ILogger<PrivilegioUsuarioService> logger)
        {
            _repository = repository;
            _logger = logger;
        }
        public Task<BaseResponseGeneric<int>> CreateAsync(DtoPrivilegioUsuario request, string userId, string codBodega)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseGeneric<ICollection<PrivilegioUsuario>>> GetAsync(int page, int rows)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponseGeneric<PrivilegioUsuario>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponseGeneric<PrivilegioUsuario>> GetPrivilegioUsuario(string constante, int conjuntoId,  string UsuarioId)
        {
            var response = new BaseResponseGeneric<PrivilegioUsuario>();
            try
            {
                
                response.Result = await _repository.GetPrivilegioUsuario(constante,conjuntoId,UsuarioId) ?? new PrivilegioUsuario();
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

        public Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPrivilegioUsuario request, string userId)
        {
            throw new NotImplementedException();
        }
    }
}
