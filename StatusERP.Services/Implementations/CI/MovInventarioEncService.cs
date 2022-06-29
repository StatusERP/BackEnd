using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CI;
using StatusERP.DataAccess.Repositories.ERPADMIN.Interfaces;
using StatusERP.Dto.Request.CI;
using StatusERP.Dto.Response;
using StatusERP.Entities.CI.Tablas;
using StatusERP.Services.Interfaces.CI;


namespace StatusERP.Services.Implementations.CI
{
    public class MovInventarioEncService : IMovInventarioEncService
    {
        private readonly IMovInventarioEncRepository _repository;
        private readonly ILogger<MovInventarioEncService> _logger;
        private readonly IPrivilegioUsuarioRepository _privilegioUsuarioRepository;
        private readonly IMovInventarioDetRepository _midRepository;
        private readonly IConsecutivoInvRepository _ciRepository;

        //Int32 IdentificadorConsecutivo;

        public MovInventarioEncService(IMovInventarioEncRepository repository, ILogger<MovInventarioEncService> logger, IPrivilegioUsuarioRepository privilegioUsuarioRepository, IMovInventarioDetRepository midRepository, IConsecutivoInvRepository ciRepository)
        {
            _repository = repository;
            _logger = logger;
            _privilegioUsuarioRepository = privilegioUsuarioRepository;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoMovInventarioEnc request, string userId, int id)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                //Comprobación de privilegio para crear encabezados de movimientos de inventario
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para crear movimientos de inventario.");
                    response.Success = false;
                    return response;
                }

                //Comprobación de que el código de movimiento a utilizar no ha sido utilizado aún.
                var buscarIdMovInventarioEnc = await _repository.BuscarIdMovInventarioEncAsync(id) ;
                if (buscarIdMovInventarioEnc != null)
                {
                    throw new Exception($"El código de movimiento de inventario {buscarIdMovInventarioEnc.Id} ya existe.");
                }

                // Ejecución de la inserción del registro
                response.Result = await _repository.CreateAsync(new MovInventarioEnc
                {
                    ConsecutivoId = request.ConsecutivoId,
                    Usuario = request.Usuario,
                    FechaHora = request.FechaHora,
                    ModuloOrigen = request.ModuloOrigen,
                    Aplicacion = request.Aplicacion,
                    Referencia = request.Referencia,
                    Asiento = request.Asiento, 
                    UsuarioAprob = request.UsuarioAprob,
                    FechaHoraAprob = request.FechaHoraAprob,
                    PaqueteInventario = request.PaqueteInventario,
                    IsDeleted = false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now
                });
                response.Success = true;


                //Inserción detalle de movimientos
                //foreach (var DetalleMov in DetallesMov)
                //{
                //    decExistenciaTotal = decExistenciaTotal + Existencia.CantDisponible;
                //}




                //Actualización de consecutivo
                var BuscarIdConsecutivo = await _ciRepository.GetByIdAsync(5);
                if (request.ConsecutivoId != null)

                {
                    int _consecutivoId;
                    _consecutivoId  = (int) request.ConsecutivoId;
                    //var BuscarIdConsecutivo = await _ciRepository.GetByIdAsync(5);
                    var ciresponse = new BaseResponseGeneric<int>();

                   try
                   {
                        ciresponse.Result = await _ciRepository.UpdateAsync(new ConsecutivoInv
                        {
                            Id = BuscarIdConsecutivo.Id, 
                            CodConsecutivo = BuscarIdConsecutivo.CodConsecutivo,
                            UltimoUsuario = BuscarIdConsecutivo.UltimoUsuario,
                            Descripcion = BuscarIdConsecutivo.Descripcion,
                            Mascara = BuscarIdConsecutivo.Mascara,
                            SiguienteConsec = SigConsecutivo(BuscarIdConsecutivo.SiguienteConsec),
                            Editable = BuscarIdConsecutivo.Editable,
                            MultiplesTrans = BuscarIdConsecutivo.MultiplesTrans,
                            FormatoImp = BuscarIdConsecutivo.FormatoImp,
                            UltFechaHora = BuscarIdConsecutivo.UltFechaHora,
                            TodasTrans = BuscarIdConsecutivo.TodasTrans,
                            Tipo = BuscarIdConsecutivo.Tipo,
                            UsaTraslado = BuscarIdConsecutivo.UsaTraslado,
                            EmailCFDI = BuscarIdConsecutivo.EmailCFDI,
                            IsDeleted = BuscarIdConsecutivo.IsDeleted,
                            Updatedby = userId,
                            UpdateDate = DateTime.Now,
                            Createdby = BuscarIdConsecutivo.Createdby,
                            CreateDate = BuscarIdConsecutivo.CreateDate,
                        });

                        ciresponse.Success = true;
                   }

                   catch (Exception ex)
                   {
                        _logger.LogCritical(ex.StackTrace);
                        ciresponse.Success = false;
                        ciresponse.Errors.Add(ex.Message);
                   }  
                } //Fin del if (ConsecutivoId != null)

            }  //Fin del try para la creación del Encabezado de Movimiento Inv

            catch (Exception ex)
            {
                _logger.LogCritical(ex.StackTrace);
                response.Success = false;
                response.Errors.Add(ex.Message);
            } // Fin del catch para la creación del Encabezado de Movimiento Inv

            return response;
        } 

        public async Task<BaseResponseGeneric<int>> DeleteAsync(int id, string userId)
        {

            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para eliminar movimientos de inventario.");
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

        public async Task<BaseResponseGeneric<ICollection<MovInventarioEnc>>> GetAsync(int page, int rows, string userId)
        {
            var response = new BaseResponseGeneric<ICollection<MovInventarioEnc>>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para consultar movimientos de inventario.");
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

        public async Task<BaseResponseGeneric<MovInventarioEnc>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<MovInventarioEnc>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new MovInventarioEnc();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoMovInventarioEnc request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarPrivilegio = await _privilegioUsuarioRepository.GetPrivilegioUsuario("CI_CONS_ENC", 9, userId);

                if (buscarPrivilegio == null)
                {
                    response.Errors.Add($"No tiene privilegios para modificar movimientos de inventario.");
                    response.Success = false;
                    return response;
                }


                response.Result = await _repository.UpdateAsync(new MovInventarioEnc
                {
                    Id = id,
                    ConsecutivoId = request.ConsecutivoId,
                    Usuario = request.Usuario,
                    FechaHora = request.FechaHora,
                    ModuloOrigen = request.ModuloOrigen,
                    Aplicacion = request.Aplicacion,
                    Referencia = request.Referencia,
                    Asiento = request.Asiento,
                    UsuarioAprob = request.UsuarioAprob,
                    FechaHoraAprob = request.FechaHoraAprob,
                    PaqueteInventario = request.PaqueteInventario,
                    IsDeleted = false,
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


        public static string SigConsecutivo(string consecutivoActual)
        {
            string ConsecCompleto = consecutivoActual;
            var elements = ConsecCompleto.Split('-');
            var element2 = elements[0];
            string element1 = elements[1];
            Int32 ParteNumerica = Convert.ToInt32(element1) + 1;
            string SigConsec = element2 + "-" + ParteNumerica.ToString("0000");

            return SigConsec;

        }



    }
}
