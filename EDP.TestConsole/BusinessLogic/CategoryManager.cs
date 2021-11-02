using EDP.ExceptionHandling;
using EDP.Log;
using EDP.TestConsole.Data;
using EDP.TestConsole.Mapper;
using EDP.TestConsole.Model;
using EDP.TestConsole.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EDP.TestConsole.BusinessLogic
{
    public class CategoryManager
    {
        public void AddCategory(CategoryModel model)
        {
            // Bir sıkıntı olursa geriye sarma işlemi olduğu için 
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    // Validation
                    CategoryValidator cv = new CategoryValidator(model);
                    // Validasyonda bir sıkıntı var ise;
                    if (!cv.IsValid)
                    {
                        ModelNotValidException mnve = new ModelNotValidException(cv.ValidationMessages, "CategoryModel not valid");
                        throw mnve;
                    }

                    // Log
                    //Bu dakikadan sonra yapman gereken iş "Log'la" 
                    var logger = new JsonLogger<CategoryModel>(model.CategoryID.ToString());
                    logger.DoLog(model);

                    // Data
                    //DataManager ile çalışacaz.
                    DataManager dataManager = new DataManager();
                    var repo = dataManager.GetCategoryRepository();

                    var entity = (new CategoryMapper()).Map(model);
                    repo.Add(new CategoryMapper().Map(model));
                    dataManager.SaveChanges();

                    ts.Complete();

                    // Cache
                    //Cache'e yazacağımız alan burası olacakdı

                }
                catch (ExceptionBase)
                {
                    throw;
                }

                catch (System.Exception ex)
                {
                    throw new BusinessLogicException("Genel olarak bir hata yakalanmıştır.", ex);
                }
            }
        }
    }
}
