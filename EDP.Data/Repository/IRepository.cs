using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Data.Repository
{
    // IRepository Generic yapısına gelecek olan T(Type)'i bir class olmalıdır ve IEntity interfacesinden inherit edilmiş olması gerekiyordur.
    public interface IRepository<T> where T : class, IEntity
    {
        // UnitOfWork:Mesela Insert-Update-Delete yani unit-unit nasıl olması gerektiği işlemdir.
        void SaveChanges();
    }
}
