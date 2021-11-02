using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Data.Repository
{
    public interface ISelectableRepository<T> : IRepository<T> where T : class, IEntity
    {
        // Gelişmiş projelerde; "int" olmaz object tutar ve unboxing olarak tutarız.
        T GetByID(object id);
        // Expression Func kullanımı: 17 farklı kullanımı vardır. Yani amacımız şartımızı belirlemektir
        // ToDo: Ado.Net ve türevi data access yapıları için kaldırılabilir ek interface e taşınabilir
        List<T> GetByID(Func<T, bool> condition);
        List<T> GetAll();



    }
}
