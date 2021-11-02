﻿using EDP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Data.Entity
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int SupplierID { get; set; }

        public decimal UnitPrice { get; set; }

        public int CategoryID { get; set; }
    }
}
