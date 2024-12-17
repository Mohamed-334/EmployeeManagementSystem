using EmployeeManagementDatabase.Entities;
using System.Linq.Expressions;

namespace Repository
{
    public interface IRepository<TModel,TIdType>
    {
        IEnumerable<TModel> GetAll();
        TModel GetById(TIdType id);
        void Update(TModel entity);
        void Delete(TModel entity);
        void Add(TModel entity);
    }
}