using EDP.TestWeb.Models;
using EDP.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDP.TestWeb.Validators
{
    public class CategoryValidator : ValidatorBase<CategoryModel>
    {
        public CategoryValidator(CategoryModel model) : base(model)
        {
        }

        public override void OnValidate()
        {
            if (string.IsNullOrEmpty(Model.CategoryName))
            {
                IsValid = false;
                ValidationMessages.Add("Kategori adı boş geçilemez");
            }

            if (Model.CategoryName != null)
            {
                if (Model.CategoryName.Length < 2)
                {
                    IsValid = false;
                    ValidationMessages.Add("Kategori adı en az iki karakter olmalıdır");
                }
            }

            if (string.IsNullOrEmpty(Model.Description))
            {
                IsValid = false;
                ValidationMessages.Add("Açıklama boş geçilemez");
            }
        }
    }
}
