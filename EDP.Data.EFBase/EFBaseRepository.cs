using EDP.Data.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Data.EFBase
{
    // Abstract class: İçerisindeki tüm methodlar uygulanmak zorundadır. "new" lenmez nasıl newlerim "new()"lerim.
    // ORM olarak EntityFramework, Oracle , ADO.NET , NHiberNate gibi kullanacağımız var ise "Abstract Factory Pattern" kullanılabilir.
    public abstract class EFBaseRepository<TContext, TEntity> :
        IInsertableRepository<TEntity>,
        IInsertableRepositoryAsync<TEntity>,
        ISelectableRepository<TEntity>,
        ISelectableRepositoryAsync<TEntity>,
        IUpdatetableRepository<TEntity>,
        IDeleteableRepository<TEntity>
        where TEntity : class, IEntity where TContext : DbContext, new()
    {
        private readonly TContext _context;

        /// Context nesnesi dışarıdan verilerek DTC ve UOF sistemine uyumlandırlmıştır. 
        /// <param name="context">DbContext</param>
        public EFBaseRepository(TContext context)
        {
            _context = context;
        }

        // DBContext'den türemeyen bir class var ise burası çalışacaktır.
        /// Context nesnesi içeride otomatik yaratılacaktır. 
        public EFBaseRepository()
        {
            _context = new TContext();
        }

        public TEntity Add(TEntity item)
        {
            // Database pogo class'ında tuttup kaydetme işlemi yapacaktır.
            // Temel CRUD işlemleri olduğu için Disposible Pattern kullanmakdık. Örn: (using context = new TContext())
            _context.Set<TEntity>().Add(item);
            return item;
        }

        public async Task AddAsync(TEntity item)
        {
            await _context.Set<TEntity>().AddAsync(item);
        }

        public List<TEntity> AddRange(List<TEntity> items)
        {
            _context.Set<TEntity>().AddRange(items);
            return items;
        }

        public async Task AddRangeAsync(List<TEntity> items)
        {
            await _context.Set<TEntity>().AddRangeAsync(items);
        }

        public void Delete(TEntity item)
        {
            _context.Set<TEntity>().Remove(item);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public TEntity GetByID(object id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetByID(Func<TEntity, bool> condition)
        {
            return _context.Set<TEntity>().Where(condition).ToList();
        }

        public async Task<TEntity> GetByIDAsync(object id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.Set<TEntity>().Attach(item);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
