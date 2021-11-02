using EDP.TestConsole.Data.Entity;
using EDP.TestConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Mapper
{

    //Third-Party: AutoMapper
    // Category & CategoryModel'i alacak ve Category olarak döndürecek.
    public class CategoryMapper
    {

        public CategoryModel Map(Category category)
        {
            //Object initializer yapıoruz tamamen.. Neden? Sürekli DataManager'a veri gönderdiğim için Database'deki Poco(Entity) istediği içindir. Birkez uyguluyoruz.

            CategoryModel model = new CategoryModel()
            {
                CategoryID = category.CategoryID,
                CategoryName = category.CategoryName,
                Description = category.Description
            };

            return model;
        }

        public Category Map(CategoryModel model)
        {
            //Object initializer yapıoruz tamamen.. Neden? Sürekli DataManager'a veri gönderdiğim için Database'deki Poco(Entity) istediği içindir. Birkez uyguluyoruz.

            Category c = new Category()
            {
                CategoryID = model.CategoryID,
                CategoryName = model.CategoryName,
                Description = model.Description
            };

            return c;
        }

    }
}
