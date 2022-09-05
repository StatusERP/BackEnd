using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.FA.Interfaces;
using StatusERP.Entities.FA.Tablas;

namespace StatusERP.DataAccess.Repositories.FA;

public class ConsecutivoFARepository : StatusERPContextBase<ConsecutivoFA>, IConsecutivoFARepository
{
    public ConsecutivoFARepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<ConsecutivoFA>> GetCollectionAsync()
    {
        return await _dbContext.ConsecutivosFA
         .Where(p => !p.IsDeleted)
         .AsNoTracking()
         .ToListAsync();
    }

    public async Task<ConsecutivoFA?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<ConsecutivoFA>(id);
    }

    public async Task<int> CreateAsync(ConsecutivoFA consecutivoFA)
    {
        return await _dbContext.InsertAsync(consecutivoFA);
    }

    public async Task<int> UpdateAsync(ConsecutivoFA consecutivoFA)
    {

        try
        {
            var registro = await _dbContext.Set<ConsecutivoFA>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == consecutivoFA.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = consecutivoFA.Id;
            registro.CodConsecutivo = consecutivoFA.CodConsecutivo;
            registro.UsuarioUlt = consecutivoFA.UsuarioUlt;
            registro.Descripcion = consecutivoFA.Descripcion;
            registro.Tipo = consecutivoFA.Tipo;
            registro.Longitud = consecutivoFA.Longitud;
            registro.ValorConsecutivo = consecutivoFA.ValorConsecutivo;
            registro.Mascara = consecutivoFA.Mascara;
            registro.FechaHoraUlt = consecutivoFA.FechaHoraUlt;
            registro.Formato = consecutivoFA.Formato;
            registro.ValorMaximo = consecutivoFA.ValorMaximo;
            registro.NumeroCopias = consecutivoFA.NumeroCopias;
            registro.Original = consecutivoFA.Original;
            registro.Copia1 = consecutivoFA.Copia1;
            registro.Copia2 = consecutivoFA.Copia2;
            registro.Copia3 = consecutivoFA.Copia3;
            registro.Copia4 = consecutivoFA.Copia4;
            registro.Copia5 = consecutivoFA.Copia5;
            registro.Reimpresion = consecutivoFA.Reimpresion;
            registro.Resolucion = consecutivoFA.Resolucion;
            registro.Serie = consecutivoFA.Serie;
            registro.DeConsRPT = consecutivoFA.DeConsRPT;
            registro.ValorInicial = consecutivoFA.ValorInicial;
            registro.DeCCRPT = consecutivoFA.DeCCRPT;
            registro.MatriculaMercantil = consecutivoFA.MatriculaMercantil;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = consecutivoFA.Updatedby;
            registro.UpdateDate = consecutivoFA.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;


            _dbContext.Set<ConsecutivoFA>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return consecutivoFA.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new ConsecutivoFA
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<ConsecutivoFA?> BuscarCodConsecutivoFAAsync(string codConsecutivo)
    {
        return await _dbContext.ConsecutivosFA
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodConsecutivo == codConsecutivo);
    }
}