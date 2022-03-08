﻿using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS;

public interface IBodegaRepository
{
    Task<ICollection<Bodega>> GetCollectionAsync(int page, int rows); 
    Task<Bodega?> GetByIdAsync(int id);
    Task<int> CreateAsync(Bodega bodega);
    Task<int> UpdateAsync(Bodega bodega);
    Task<int> DeleteAsync(int id,string userId);
}