using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Data.Repository
{
    public interface ISelectableRepositoryAsync<T> : IRepository<T> where T : class, IEntity
    {

        Task<List<T>> GetAllAsync();
        Task<T> GetByIDAsync(object id);
    }
}
