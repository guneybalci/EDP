using EDP.Data.EFBase;
using EDP.TestConsole.Data.Entity;
using EDP.TestConsole.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Data.EF
{
    public class CategoryRepository : EFBaseRepository<NorthwindContext, Category>, ICategoryRepository
    {
        public CategoryRepository()
        {

        }

        public CategoryRepository(NorthwindContext context) : base(context)
        {

        }
    }
}
