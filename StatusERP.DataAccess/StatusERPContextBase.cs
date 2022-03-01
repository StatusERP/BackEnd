using AutoMapper;
using StatusERP.Entities;

namespace StatusERP.DataAccess
{
    public class StatusERPContextBase<TEntityBase>
        where TEntityBase : EntityBase,new()
    { 
        protected  readonly StatusERPDBContext _dbContext;
        public readonly IMapper Mapper;

        public StatusERPContextBase( StatusERPDBContext context,IMapper mapper)
        {
            _dbContext = context;
            Mapper = mapper;
        }
    }
}
