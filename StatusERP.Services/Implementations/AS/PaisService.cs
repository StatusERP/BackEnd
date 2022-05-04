using AutoMapper;
using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

namespace StatusERP.Services.Implementations.AS
{
    public class PaisService : IPaisService
    {
        private readonly IPaisRepository _repository;
        private readonly ILogger<PaisService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;
        private readonly IMapper _mapper;

        public PaisService(IPaisRepository repository, ILogger<PaisService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoPais request, string userId, string codPais)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {

                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_PAISADD", 9, userId);




                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene Privilegios para Crear Pais");
                    response.Success = false;
                    return response;
                }


                var buscarCodBodega = await _repository.BuscarCodPaisAsync(codPais);
                if (buscarCodBodega != null)
                {
                    response.Errors.Add($"El codigo de Pais {buscarCodBodega.CodPais} ya Existe");
                    response.Success = false;
                    return response;


                }

                response.Result = await _repository.CreateAsync(new Pais
                {
                    CodPais = request.codPais,
                    Nombre = request.nombre,
                    Createdby = userId,
                    CreateDate = DateTime.Now,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now

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
    

         public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
    {
        var response = new BaseResponseGeneric<int>();
        try
        {
            await _repository.DeleteAsync(id, userId);
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

        public async Task<BaseResponseGeneric<ICollection<Pais>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<Pais>>();
            try
            {

                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_PAISES", 9, userId);


                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene Privilegios para ver Paises");
                    response.Success = false;
                    return response;
                }

                response.Result = await _repository.GetCollectionAsync(page, rows);
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

        public async Task<BaseResponseGeneric<Pais>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Pais>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new Pais();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoPais request, string userId)
        {
            var response = new BaseResponseGeneric<int>();

            try
            {

                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_PAISMOD", 9, userId);




                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene Privilegios para Modificar Pais");
                    response.Success = false;
                    return response;
                }

                // response.Result = await _repository.UpdateAsync(_mapper.Map<Bodega>(request));
                response.Success = true;
                //{
                //    Id = id,
                //    CodBodega = request.CodBodega,
                //    Nombre = request.Nombre,
                //    Tipo = request.Tipo,
                //    Activa = request.Activa,
                //    Direccion = request.Direccion,
                //    Updatedby = userId,
                //    UpdateDate = DateTime.Now
                //});
            }

            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            }
            return response;
        }
    }
}
