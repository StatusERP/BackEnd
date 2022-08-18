using AutoMapper;
using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;

public class CondicionPagoService : ICondicionPagoService
{
    private readonly ICondicionPagoRepository _repository;
    private readonly ILogger<CondicionPagoService> _logger;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;
    private readonly IMapper _mapper;

    public CondicionPagoService(ICondicionPagoRepository repository, ILogger<CondicionPagoService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
        _mapper = mapper;
    }
    public async Task<BaseResponseGeneric<ICollection<CondicionPago>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<CondicionPago>>();
        try
        {

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CONDICIONPAGO", Constants.EmpresaId, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar condiciones de pago.");
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

    public async Task<BaseResponseGeneric<CondicionPago>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<CondicionPago>();
        try
        {

            response.Result = await _repository.GetByIdAsync(id) ?? new CondicionPago();
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

    public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCondicionPago request, string userId, string codCondicionPago)
    {

        var response = new BaseResponseGeneric<int>();
        try
        {

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CONDICIONPAGO", Constants.EmpresaId, userId);

            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear condiciones de pago.");
                response.Success = false;
                return response;
            }


            var buscarCodCondPago = await _repository.BuscarCodCondicionPagoAsync(codCondicionPago);
            if (buscarCodCondPago != null)
            {
                response.Errors.Add($"El código de condición de pago {buscarCodCondPago.CodCondicionPago} ya existe.");
                response.Success = false;
                return response;
            }

            response.Result = await _repository.CreateAsync(new CondicionPago
            {
                CodCondicionPago = request.CodCondicionPago,
                Descripcion = request.Descripcion,
                DiasNeto = request.DiasNeto,
                PagosParciales = request.PagosParciales,
                DescuentoContado = request.DescuentoContado,
                TipoCondPago = request.TipoCondPago,
                PlazoCondPago = request.PlazoCondPago,
                Activa = true,
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



    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCondicionPago request, string userId)
    {
        var response = new BaseResponseGeneric<int>();

        try
        {

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_CONDICIONPAGO", Constants.EmpresaId, userId);




            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para modificar condiciones de pago.");
                response.Success = false;
                return response;
            }


            response.Result = await _repository.UpdateAsync(new CondicionPago
            {
                Id = id,
                CodCondicionPago = request.CodCondicionPago,
                Descripcion = request.Descripcion,
                DiasNeto = request.DiasNeto,
                PagosParciales = request.PagosParciales,
                DescuentoContado = request.DescuentoContado,
                TipoCondPago = request.TipoCondPago,
                PlazoCondPago = request.PlazoCondPago,
                Activa = request.Activa,
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

    //public async Task<BaseResponseGeneric<int>> DesactivarAsync(int id, string userId)
    //{
    //    var response = new BaseResponseGeneric<int>();
    //    try
    //    {
    //        await _repository.DesActivarAsync(id, userId);
    //        response.Success = true;
    //        response.Result = id;
    //    }
    //    catch (Exception ex)
    //    {
    //        _logger.LogCritical(ex.StackTrace);
    //        response.Success = false;
    //        response.Errors.Add(ex.Message);
    //    }
    //    return response;
    //}
}