using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public class VendedorRepository : StatusERPContextBase<Vendedor>, IVendedorRepository
{
    public VendedorRepository(StatusERPDBContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<ICollection<Vendedor>> GetCollectionAsync()
    {
        return await _dbContext.Vendedores
        .Where(p => !p.IsDeleted)
        .AsNoTracking()
        .ToListAsync();
    }

    public async Task<Vendedor?> GetByIdAsync(int id)
    {
        return await _dbContext.SelectAsync<Vendedor>(id);
    }

    public async Task<int> CreateAsync(Vendedor Vendedor)
    {
        return await _dbContext.InsertAsync(Vendedor);
    }

    public async Task<int> UpdateAsync(Vendedor Vendedor)
    {

        try
        {
            var registro = await _dbContext.Set<Vendedor>()
        .AsNoTracking()
        .SingleOrDefaultAsync(x => x.Id == Vendedor.Id && !x.IsDeleted);

            if (registro == null)
            {
                return 0;
            }

            registro.Id = Vendedor.Id;
            registro.CodVendedor = Vendedor.CodVendedor;
            registro.Nombre = Vendedor.Nombre;
            registro.Email = Vendedor.Email;
            registro.Activo = Vendedor.Activo;
            registro.Telefono = Vendedor.Telefono;
            registro.IsDeleted = registro.IsDeleted;
            registro.Updatedby = Vendedor.Updatedby;
            registro.UpdateDate = Vendedor.UpdateDate;
            registro.Createdby = registro.Createdby;
            registro.CreateDate = registro.CreateDate;

            _dbContext.Set<Vendedor>().Attach(registro);
            _dbContext.Entry(registro).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        catch (Exception ex)
        {
            Console.Write(ex);
        }

        return Vendedor.Id;

    }

    public async Task<int> DeleteAsync(int id, string userId)
    {
        await _dbContext.DeleteAsync(new Vendedor
        {
            Id = id,
            Updatedby = userId
        });
        return id;
    }

    public async Task<Vendedor?> BuscarCodVendedorAsync(string codVendedor)
    {
        return await _dbContext.Vendedores
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.CodVendedor == codVendedor);
    }
}