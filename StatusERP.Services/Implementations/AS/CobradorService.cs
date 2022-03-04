using Microsoft.Extensions.Logging;
using StatusERP.DataAccess.Repositories.AS;
using StatusERP.Dto.Request.AS;
using StatusERP.Dto.Response;
using StatusERP.Entities.AS.Tablas;
using StatusERP.Services.Interfaces.AS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.Services.Implementations.AS
{
    public class CobradorService : ICobradorService
    {
        private readonly ICobradorRepository _repository;
        private readonly ILogger<CobradorService> _logger;
        public CobradorService(ICobradorRepository repository,ILogger<CobradorService> logger )
        {
            _repository = repository;
            _logger = logger;
        }

    

        public async Task<BaseResponseGeneric<int>> CreateAsync(DtoCobrador request, string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                response.Result = await _repository.CreateAsync(new Cobrador
                {
                     CodCobrador = request.CodCobrador,
                    Nombre = request.Nombre,
                    Email = request.Email,
                    Activo = true,
                    Updatedby = userId,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    Createdby = userId,
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
            var response = new BaseResponseGeneric<int>();
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

        public async Task<BaseResponseGeneric<ICollection<Cobrador>>> GetAsync(int page, int rows)
        {
            var response = new BaseResponseGeneric<ICollection<Cobrador>>();
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

        public async Task<BaseResponseGeneric<Cobrador>> GetByIdAsync(int id)
        {
            var response = new BaseResponseGeneric<Cobrador>();
            try
            {
                response.Result = await _repository.GetByIdAsync(id) ?? new Cobrador();
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

        public async Task<BaseResponseGeneric<int>> UpdateAsync(int id, DtoCobrador request ,string userId)
        {
            var response = new BaseResponseGeneric<int>();
            try
            {
                response.Result = await _repository.UpdateAsync(new Cobrador
                {
                    Id = id,
                    Nombre = request.Nombre,
                    Email = request.Email,
                    Activo = request.Activo,
                    CodCobrador = request.CodCobrador,
                    UpdateDate=DateTime.Now,
                    Updatedby=userId
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
