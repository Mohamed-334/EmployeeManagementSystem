using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IGetByForeignKeyRepository<TModel>
    {
        IEnumerable<TModel> GetByForeignKey(Func<TModel,bool> filter);
    }
}
