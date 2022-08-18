using AutoMapper;
using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using StatusERP.Entities;

namespace StatusERP.Services.Implementations.AS;

public class BodegaService:IBodegaService
{
    private readonly IBodegaRepository _repository;
    private readonly ILogger<BodegaService> _logger;
    private readonly ISucursalesRepository _sucursalesRepository;
    private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;
    private readonly IMapper _mapper;

    public BodegaService(IBodegaRepository repository,ILogger<BodegaService> logger ,ISucursalesRepository sucursalesRepository,IPrivilegioUsuarioRepository privilegioUsuarioRepository,IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _sucursalesRepository = sucursalesRepository;
        _privilegioUsuarioRepository = privilegioUsuarioRepository;
        _mapper = mapper;
    }
    public async Task<BaseResponseGeneric<ICollection<Bodega>>> GetAsync(int page, int rows, string userId)
    {
        var response = new BaseResponseGeneric<ICollection<Bodega>>();
        try
        {

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_BODEGAS", Constants.EmpresaId, userId);


            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para consultar bodegas.");
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

    public async Task<BaseResponseGeneric<Bodega>> GetByIdAsync(int id)
    {
        var response = new BaseResponseGeneric<Bodega>();
        try
        {
           


            response.Result = await _repository.GetByIdAsync(id) ?? new Bodega();
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

    public  async Task<BaseResponseGeneric<int>> CreateAsync(DtoBodega request, string userId,string codBodega)
    {
        //Constante de Accion para su validacion de privilegios 

        var response = new BaseResponseGeneric<int>();
        try
        {

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_BODEGAADD", Constants.EmpresaId,  userId);
            
           
            
            
            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene privilegios para crear bodegas.");
                response.Success = false;
                return response;
            }

           
            var buscarCodBodega = await _repository.BuscarCodBodegaAsync(codBodega);
            if (buscarCodBodega != null)
            {
                response.Errors.Add($"El código de bodega {buscarCodBodega.CodBodega} ya existe.");
                response.Success = false;
                return response;

              
            }
            
            response.Result = await _repository.CreateAsync(new Bodega
            {
                CodBodega = request.CodBodega,
                Nombre = request.Nombre,
                Tipo = request.Tipo,
                Activa = true,
                Telefono = request.Telefono,
                Direccion = request.Direccion,
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

    

    public async Task<BaseResponseGeneric<int>> UpdateAsync(int id,DtoBodega request, string userId)
    {
        var response = new BaseResponseGeneric<int>();

        try
        {

            var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("AS_BODEGAMOD", Constants.EmpresaId, userId);




            if (buscarPrivilegio == null)
            {
                response.Errors.Add($"No tiene Privilegios para Modificar Bodega");
                response.Success = false;
                return response;
            }

            
            response.Result = await _repository.UpdateAsync(new Bodega
            {
                Id = id,
                CodBodega=request.CodBodega,
                Nombre=request.Nombre,
                Tipo=request.Tipo,
                Activa=request.Activa,
                Telefono=request.Telefono,
                Direccion=request.Direccion,
                Updatedby=userId,
                UpdateDate=DateTime.Now,
            });
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

    public async Task<BaseResponseGeneric<int>> DesactivarAsync(int id, string userId)
    {
         var response = new BaseResponseGeneric<int>();
        try
        {
            await _repository.DesActivarAsync(id, userId);
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
}