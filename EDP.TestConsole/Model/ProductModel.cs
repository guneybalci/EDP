using EDP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Model
{
    public class ProductModel : IModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int SupplierID { get; set; }

        public decimal UnitPrice { get; set; }

        public int CategoryID { get; set; }
    }
}
