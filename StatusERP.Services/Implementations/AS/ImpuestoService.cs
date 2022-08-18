using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS
{
    public class ImpuestoService : IImpuestoService
    {
        private readonly IImpuestoRepository _repository;
        private readonly ILogger<ImpuestoService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;

        public ImpuestoService(IImpuestoRepository repository, ILogger<ImpuestoService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoImpuesto request, string userId, string codImpuesto)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_IMPUESTOADD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear impuestos.");
                    response.Success = false;
                    return response;
                }

                var buscarCodImpuesto = await _repository.BuscarCodImpuestoAsync(codImpuesto);
                if (buscarCodImpuesto != null)
                {
                    throw new Exception($"El código de impuesto {buscarCodImpuesto.CodImpuesto} ya existe.");
                }
                response.Result = await _repository.CreateAsync(new Impuesto
                {
                    CodImpuesto = request.CodImpuesto,
                    Descripcion = request.Descripcion,
                    Impuesto1 = request.Impuesto1,
                    Impuesto2 = request.Impuesto2,
                    UsaImpuesto2Cantidad = request.UsaImpuesto2Cantidad,
                    Impuesto2Cantidad = request.Impuesto2Cantidad,
                    CalculoImp2 = request.CalculoImp2,
                    TipoContabImp1 = request.TipoContabImp1,
                    TipoContabImp2 = request.TipoContabImp2,
                    ContabDevImp1 = request.ContabDevImp1,
                    ContabDevImp2 = request.ContabDevImp2,
                    CtroCtaImp1GenId = request.CtroCtaImp1GenId,
                    CtroCtaImp2GenId = request.CtroCtaImp2GenId,
                    CtroCtaImp1GenVtsId = request.CtroCtaImp1GenVtsId,
                    CtroCtaImp2GenVtsId = request.CtroCtaImp2GenVtsId,
                    CtroCtaImp1DescCompId = request.CtroCtaImp1DescCompId,
                    CtroCtaImp2DescCompId = request.CtroCtaImp2DescCompId,
                    CtroCtaImp1DevCompId = request.CtroCtaImp1DevCompId,
                    CtroCtaImp2DevCompId = request.CtroCtaImp2DevCompId,
                    CtroCtaImp1DevVtsId = request.CtroCtaImp1DevVtsId,
                    CtroCtaImp2DevVtsId = request.CtroCtaImp2DevVtsId,
                    TipoImpuesto1Id = request.TipoImpuesto1Id,
                    TipoImpuesto2Id = request.TipoImpuesto2Id,
                    TipoTarifa1 = request.TipoTarifa1,
                    TipoTarifa2 = request.TipoTarifa2,
                    Activo = request.Activo,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now,
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_IMPUESTODEL", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar impuestos.");
                    response.Success = false;
                    return response;
                }


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

        public async Task<BaseResponseGeneric<ICollection<Impuesto>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<Impuesto>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_IMPUESTOS", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar impuestos.");
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

        public async Task<BaseResponseGeneric<Impuesto>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Impuesto>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new Impuesto();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoImpuesto request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_IMPUESTOMOD", Constants.EmpresaId, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar impuestos.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new Impuesto
                {
                    Id = id,
                    CodImpuesto = request.CodImpuesto,
                    Descripcion = request.Descripcion,
                    Impuesto1 = request.Impuesto1,
                    Impuesto2 = request.Impuesto2,
                    UsaImpuesto2Cantidad = request.UsaImpuesto2Cantidad,
                    Impuesto2Cantidad = request.Impuesto2Cantidad,
                    CalculoImp2 = request.CalculoImp2,
                    TipoContabImp1 = request.TipoContabImp1,
                    TipoContabImp2 = request.TipoContabImp2,
                    ContabDevImp1 = request.ContabDevImp1,
                    ContabDevImp2 = request.ContabDevImp2,
                    CtroCtaImp1GenId = request.CtroCtaImp1GenId,
                    CtroCtaImp2GenId = request.CtroCtaImp2GenId,
                    CtroCtaImp1GenVtsId = request.CtroCtaImp1GenVtsId,
                    CtroCtaImp2GenVtsId = request.CtroCtaImp2GenVtsId,
                    CtroCtaImp1DescCompId = request.CtroCtaImp1DescCompId,
                    CtroCtaImp2DescCompId = request.CtroCtaImp2DescCompId,
                    CtroCtaImp1DevCompId = request.CtroCtaImp1DevCompId,
                    CtroCtaImp2DevCompId = request.CtroCtaImp2DevCompId,
                    CtroCtaImp1DevVtsId = request.CtroCtaImp1DevVtsId,
                    CtroCtaImp2DevVtsId = request.CtroCtaImp2DevVtsId,
                    TipoImpuesto1Id = request.TipoImpuesto1Id,
                    TipoImpuesto2Id = request.TipoImpuesto2Id,
                    TipoTarifa1 = request.TipoTarifa1,
                    TipoTarifa2 = request.TipoTarifa2,
                    Activo = request.Activo,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
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
    }
}