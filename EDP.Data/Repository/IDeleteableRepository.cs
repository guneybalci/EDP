using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Data.Repository
{
    public interface IDeleteableRepository<T> : IRepository<T> where T : class, IEntity
    {
        void Delete(T item);
    }
}
