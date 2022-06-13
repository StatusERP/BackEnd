using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.DataAccess.Repositories.AS.Interfaces;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class DocTributarioRepository:StatusERPContextBase<DocTributario>,IDocTributarioRepository
{
    public DocTributarioRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<DocTributario>> GetCollectionAsync(int page, int rows)
    {
        return await _dbContext.SelectAsync<DocTributario>(page, rows);
    }

    public  async Task<DocTributario?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<DocTributario>(id);
    }

    public async Task<int> CreateAsync(DocTributario docTributario)
    {
        return await _dbContext.InsertAsync(docTributario);
    }

    public async Task<int> UpdateAsync(DocTributario docTributario)
    {
        await _dbContext.UpdateAsync(docTributario,Mapper);
        return docTributario.Id;
    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new DocTributario
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<DocTributario?> BuscarDocTributarioAsync(string codDocTributario)
    {
        return await _dbContext.DocTributarios
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodDocTributario == codDocTributario );
    }
}