using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Data.Repository
{
    public interface IInsertableRepositoryAsync<T> : IRepository<T> where T : class, IEntity
    {
        Task AddAsync(T item);
        Task AddRangeAsync(List<T> items);
    }
}
