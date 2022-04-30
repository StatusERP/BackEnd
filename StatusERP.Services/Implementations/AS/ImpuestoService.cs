using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;

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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_IMPUESTOADD", 9, userId);

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
                    CtrImp2Gen = request.CtrImp2Gen,
                    CtaImp2Gen = request.CtaImp2Gen,
                    CtrImp1GenVts = request.CtrImp1GenVts,
                    CtaImp1GenVts = request.CtaImp1GenVts,
                    CtrImp2GenVts = request.CtrImp2GenVts,
                    CtaImp2GenVts = request.CtaImp2GenVts,
                    CtrImp1DesComp = request.CtrImp1DesComp,
                    CtaImp1DesComp = request.CtaImp1DesComp,
                    CtrImp2DesComp = request.CtrImp2DesComp,
                    CtaImp2DesComp = request.CtaImp2DesComp,
                    CtrImp1DevComp = request.CtrImp1DevComp,
                    CtaImp1DevComp = request.CtaImp1DesComp,
                    CtrImp2DevComp = request.CtrImp2DevComp,
                    CtaImp2DevComp = request.CtaImp2DevComp,
                    CtrImp1DevVentas = request.CtrImp1DevVentas,
                    CtaImp1DevVentas = request.CtaImp1DevVentas,
                    CtrImp2DevVentas = request.CtrImp2DevVentas,
                    CtaImp2DevVentas = request.CtaImp2DevVentas,
                    TipoImpuesto1 = request.TipoImpuesto1,
                    TipoImpuesto2 = request.TipoImpuesto2,
                    TipoTarifa1 = request.TipoTarifa1,
                    TipoTarifa2 = request.TipoTarifa2,
                    Activo = true,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now,
                    CentroCuentaId = request.CtroCtaImp1
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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_IMPUESTODEL", 9, userId);

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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_IMPUESTOS", 9, userId);

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
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_IMPUESTOMOD", 9, userId);

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
                    CtrImp2Gen = request.CtrImp2Gen,
                    CtaImp2Gen = request.CtaImp2Gen,
                    CtrImp1GenVts = request.CtrImp1GenVts,
                    CtaImp1GenVts = request.CtaImp1GenVts,
                    CtrImp2GenVts = request.CtrImp2GenVts,
                    CtaImp2GenVts = request.CtaImp2GenVts,
                    CtrImp1DesComp = request.CtrImp1DesComp,
                    CtaImp1DesComp = request.CtaImp1DesComp,
                    CtrImp2DesComp = request.CtrImp2DesComp,
                    CtaImp2DesComp = request.CtaImp2DesComp,
                    CtrImp1DevComp = request.CtrImp1DevComp,
                    CtaImp1DevComp = request.CtaImp1DesComp,
                    CtrImp2DevComp = request.CtrImp2DevComp,
                    CtaImp2DevComp = request.CtaImp2DevComp,
                    CtrImp1DevVentas = request.CtrImp1DevVentas,
                    CtaImp1DevVentas = request.CtaImp1DevVentas,
                    CtrImp2DevVentas = request.CtrImp2DevVentas,
                    CtaImp2DevVentas = request.CtaImp2DevVentas,
                    TipoImpuesto1 = request.TipoImpuesto1,
                    TipoImpuesto2 = request.TipoImpuesto2,
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