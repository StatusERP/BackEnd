using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public class ImpuestoRepository : StatusERPContextBase<Impuesto>, IImpuestoRepository
    {

        public ImpuestoRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public async Task<Impuesto?> BuscarCodImpuestoAsync(string CodImpuesto)
        {
            return await _dbContext.Impuestos
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodImpuesto == CodImpuesto);
        }

        public async Task<int> CreateAsync(Impuesto Impuesto)
        {
            return await _dbContext.InsertAsync(Impuesto);
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            await _dbContext.DeleteAsync(new Impuesto
            {
                Id = id,
                Updatedby = userId
            });
            return id;
        }

        public async Task<Impuesto?> GetByIdAsync(int id)
        {
            return await _dbContext.SelectAsync<Impuesto>(id);
        }

        public async Task<ICollection<Impuesto>> GetCollectionAsync(int page, int rows)
        {
            return await _dbContext.SelectAsync<Impuesto>(page, rows);
        }

        public async Task<int> UpdateAsync(Impuesto impuesto)
        {
            //await _dbContext.UpdateAsync(impuesto,Mapper);
            //return impuesto.Id;

            try
            {
                var registro = await _dbContext.Set<Impuesto>()
               .AsNoTracking()
               .SingleOrDefaultAsync(x => x.Id == impuesto.Id && !x.IsDeleted);

                if (registro == null)
                {
                    return 0;
                }
                registro.Id = impuesto.Id;
                registro.CodImpuesto = impuesto.CodImpuesto;
                registro.Descripcion = impuesto.Descripcion;
                registro.Impuesto1 = impuesto.Impuesto1;
                registro.Impuesto2 = impuesto.Impuesto2;
                registro.UsaImpuesto2Cantidad = impuesto.UsaImpuesto2Cantidad;
                registro.Impuesto2Cantidad = impuesto.Impuesto2Cantidad;
                registro.CalculoImp2 = impuesto.CalculoImp2;
                registro.TipoContabImp1 = impuesto.TipoContabImp1;
                registro.TipoContabImp2 = impuesto.TipoContabImp2;
                registro.ContabDevImp1 = impuesto.ContabDevImp1;
                registro.ContabDevImp2 = impuesto.ContabDevImp2;
                registro.CtroCtaImp1GenId = impuesto.CtroCtaImp1GenId;
                registro.CtroCtaImp2GenId = impuesto.CtroCtaImp2GenId;
                registro.CtroCtaImp1GenVtsId = impuesto.CtroCtaImp1GenVtsId;
                registro.CtroCtaImp2GenVtsId = impuesto.CtroCtaImp2GenVtsId;
                registro.CtroCtaImp1DescCompId = impuesto.CtroCtaImp1DescCompId;
                registro.CtroCtaImp2DescCompId = impuesto.CtroCtaImp2DescCompId;
                registro.CtroCtaImp1DevCompId = impuesto.CtroCtaImp1DevCompId;
                registro.CtroCtaImp2DevCompId = impuesto.CtroCtaImp2DevCompId;
                registro.CtroCtaImp1DevVtsId = impuesto.CtroCtaImp1DevVtsId;
                registro.CtroCtaImp2DevVtsId = impuesto.CtroCtaImp2DevVtsId;
                registro.TipoImpuesto1Id = impuesto.TipoImpuesto1Id;
                registro.TipoImpuesto2Id = impuesto.TipoImpuesto2Id;
                registro.TipoTarifa1 = impuesto.TipoTarifa1;
                registro.TipoTarifa2 = impuesto.TipoTarifa2;
                registro.Activo = impuesto.Activo;
                registro.IsDeleted = registro.IsDeleted;
                registro.Createdby = registro.Createdby;
                registro.CreateDate = registro.CreateDate;
                registro.Updatedby = impuesto.Updatedby;
                registro.UpdateDate = impuesto.UpdateDate;

                _dbContext.Set<Impuesto>().Attach(registro);
                _dbContext.Entry(registro).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            return impuesto.Id;


        }
    }
}