using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IRepository<TModel,Type> where TModel : class
    {
        void Add(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        TModel GetById(Type id);
        IEnumerable<TModel> GetAll();
    }
}
