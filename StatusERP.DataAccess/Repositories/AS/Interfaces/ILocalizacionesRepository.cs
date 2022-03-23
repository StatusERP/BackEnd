﻿using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS.Interfaces
{
    public interface ILocalizacionesRepository
    {
        Task<ICollection<Localizacion>> GetCollectionAsync(int page, int rows);
        Task<Localizacion?> GetByIdAsync(int id);
        Task<int> CreateAsync( Localizacion localizacion);
        Task<int> UpdateAsync(Localizacion localizacion );
        Task<int> DeleteAsync(int id, string userId);
    }
}