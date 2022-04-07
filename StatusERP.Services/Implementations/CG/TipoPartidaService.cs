using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.CG;
using StatusERP.Dto.Request.CG;
using StatusERP.Dto.Response;
using StatusERP.Entities.CG.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Services.Implementations.CG
{
    public class TipoPartidaService : ITipoPartidaService
    {
        private readonly ITipoPartidaRepository _repository;
        private readonly ILogger<TipoPartidaService> _logger;

        public TipoPartidaService(ITipoPartidaRepository repository,ILogger<TipoPartidaService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoTipoPartida request, string userId, string codTipoPartida)
        {
            
            var response = new BaseResponseGeneric<int>();
            try
            {
                var buscarCodTipoPartida = await _repository.BuscarCodTipoPartidaAsync(codTipoPartida);
                if (buscarCodTipoPartida != null)
                {
                    throw new Exception($"El codigo de Tipo Partida {buscarCodTipoPartida.CodTipoPartida} ya Existe");
                }
                response.Result = await _repository.CreateAsync(new TipoPartida
                {
                    CodTipoPartida = request.codTipoPartida,
                    Descripcion = request.Descripcion,
                    IsDeleted=false,
                    Updatedby = userId,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
                    CreateDate = DateTime.Now
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

        public async Task<BaseResponseGeneric<ICollection<TipoPartida>>> GetAsync(int page, int rows)
        {
            var response = new BaseResponseGeneric<ICollection<TipoPartida>>();
            try
            {
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

        public async Task<BaseResponseGeneric<TipoPartida>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<TipoPartida>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new TipoPartida();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoTipoPartida request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {

                response.Result = await _repository.UpdateAsync(new TipoPartida
                {
                    Id = id,
                    CodTipoPartida = request.codTipoPartida,
                    Descripcion = request.Descripcion,
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
    }
}
