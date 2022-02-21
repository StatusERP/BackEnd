using StatusERP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusERP.DataAccess
{
    public class StatusERPContextBase<TEntityBase>
        where TEntityBase : EntityBase,new()
    { 
        protected  readonly StatusERPDBContext _dbContext;
        public StatusERPContextBase( StatusERPDBContext context)
        {
            _dbContext = context;
        }
    }
}
