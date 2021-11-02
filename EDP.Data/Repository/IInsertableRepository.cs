using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Data.Repository
{
    // SQL Insert komutu kısaca veritabanı içinde herhangi bir tabloya veri eklemek için kullanılan bir SQL DML (Data Manipulation Language) yani Veri İşleme Dili komutudur.
    public interface IInsertableRepository<T> : IRepository<T> where T : class, IEntity
    {

        T Add(T item);

        List<T> AddRange(List<T> items);
    }
}
