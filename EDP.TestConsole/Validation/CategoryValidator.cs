using EDP.TestConsole.Model;
using EDP.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Validation
{
    public class CategoryValidator : ValidatorBase<CategoryModel>
    {

        public CategoryValidator(CategoryModel model) : base(model)
        {

        }

        public override void OnValidate()
        {
            // Eğer string is null or empty ise;
            if (string.IsNullOrEmpty(Model.CategoryName))
            {
                IsValid = false;
                ValidationMessages.Add("Kategori adı boş geçilemez.");
            }

            if (Model.CategoryName.Length < 2)
            {
                IsValid = false;
                ValidationMessages.Add("Kategori adı en az iki karakter olmalıdır.");
            }

            if (string.IsNullOrEmpty(Model.Description))
            {
                IsValid = false;
                ValidationMessages.Add("Açıklama alanı boş geçilemez.");
            }
        }
    }
}
