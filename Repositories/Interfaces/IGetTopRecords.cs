using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IGetTopRecords<TModel>
    {
        IEnumerable<TModel> GetTopRecords(int RecordsNumber);
    }
}
