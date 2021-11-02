using EDP.TestConsole.Data.Entity;
using EDP.TestConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Mapper
{
    public class ProductMapper
    {
        public ProductModel Map(Product product)
        {
            //Object initializer yapıoruz tamamen.. Neden? Sürekli DataManager'a veri gönderdiğim için Database'deki Poco(Entity) istediği içindir. Birkez uyguluyoruz.

            return new ProductModel()
            {
                CategoryID = product.CategoryID,
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                SupplierID = product.SupplierID,
                UnitPrice = product.UnitPrice
            };
        }

        public Product Map(ProductModel model)
        {
            //Object initializer yapıoruz tamamen.. Neden? Sürekli DataManager'a veri gönderdiğim için Database'deki Poco(Entity) istediği içindir. Birkez uyguluyoruz.

            return new Product()
            {
                CategoryID = model.CategoryID,
                ProductID = model.ProductID,
                ProductName = model.ProductName,
                SupplierID = model.SupplierID,
                UnitPrice = model.UnitPrice
            };
        }
    }
}
