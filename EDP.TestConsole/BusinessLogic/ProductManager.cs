using EDP.ExceptionHandling;
using EDP.Log;
using EDP.TestConsole.Data;
using EDP.TestConsole.Data.Entity;
using EDP.TestConsole.Model;
using EDP.TestConsole.Validation;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EDP.TestConsole.BusinessLogic
{
    public class ProductManager
    {
        public void AddNewProduct(ProductModel model)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    // Validation
                    ProductValidator validator = new ProductValidator(model);
                    if (!validator.IsValid)
                    {
                        throw new ModelNotValidException(validator.ValidationMessages);
                    }

                    // Business Logic


                    // Mapping
                    // Mapster ile yapılan map
                    var entity = model.Adapt<Product>();

                    // Map class ile yapılan map
                    //ProductMapper mapper = new ProductMapper();
                    //var entity = mapper.Map(model);

                    // Data
                    var dataManager = new DataManager();
                    var productRepo = dataManager.GetProductRepository();
                    productRepo.Add(entity);
                    dataManager.SaveChanges();

                    // Cache

                    // Log
                    var logger = new JsonLogger<ProductModel>(model.ProductName);
                    logger.DoLog(model);

                    ts.Complete();
                }
                catch (ExceptionBase)
                {
                    ts.Dispose();
                    throw;
                }
                catch (System.Exception ex)
                {
                    ts.Dispose();
                    throw new BusinessLogicException("Product eklemede hata", ex);
                }
            }
        }
    }
}
