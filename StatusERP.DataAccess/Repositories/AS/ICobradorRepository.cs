﻿using StatusERP.Entities.AS.Tablas;

namespace StatusERP.DataAccess.Repositories.AS
{
    public interface ICobradorRepository
    {
        Task<ICollection<Cobrador>> GetCollectionAsync(int page, int rows);
        Task<Cobrador?> GetByIdAsync(int id);
        Task<int> CreateAsync(Cobrador cobrador);
        Task<int> UpdateAsync(Cobrador cobrador);
        Task<int> DeleteAsync(int id);
    }
}