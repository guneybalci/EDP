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
    public class ProductRepository : EFBaseRepository<NorthwindContext, Product>, IProductRepository
    {
        public ProductRepository()
        {

        }

        public ProductRepository(NorthwindContext context) : base(context)
        {

        }
    }
}
