using EDP.TestConsole.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using repo = EDP.TestConsole.Data.EF;

namespace EDP.TestConsole.Data
{
    // Unit of work 
    // UnitOfWork Pattern'dir. CRUD işlemleri yapıcağız ama nereye neye göre yapıcaz sorusunun cevabı buradadır. Diğer yapıda biz RAM üzerinde tutuyoruz.
    // DataManager = EF + Entity + Infrastructure birleştirdiğimiz kısımdır.
    public class DataManager
    {

        public DataManager()
        {
            Context = new repo.NorthwindContext();
        }


        public repo.NorthwindContext Context { get; private set; }


        public ICategoryRepository GetCategoryRepository()
        {
            return new repo.CategoryRepository(Context);
        }

        public IProductRepository GetProductRepository()
        {
            return new repo.ProductRepository(Context);
        }


        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
