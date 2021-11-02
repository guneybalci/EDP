using EDP.Data.Repository;
using EDP.TestConsole.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Data.Infrastructure
{
    // Ben bu kategori ile ilgili hangi işlemleri yapıcam? CRUD işlemleri dışına çıktığımız alanda burasıdır. UI'dan buraya gelicektir buradan Repository'e gidicektir.
    public interface ICategoryRepository :
        ISelectableRepository<Category>,
        IInsertableRepository<Category>
    {
    }
}
