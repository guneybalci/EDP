using EDP.TestConsole.Model;
using EDP.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Validation
{
    public class ProductValidator : ValidatorBase<ProductModel>
    {
        public ProductValidator(ProductModel model) : base(model)
        {
        }

        public override void OnValidate()
        {
            CategoryIdNotEmptyValidator();
            SupplierIdNotEmptyValidator();
            ProductNameNotEmptyValidator();
        }

        #region ModelValidatorParts

        private void ProductNameNotEmptyValidator()
        {
            if (string.IsNullOrEmpty(Model.ProductName))
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen ürün adını giriniz");
            }
        }

        private void SupplierIdNotEmptyValidator()
        {
            if (Model.SupplierID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen bir sağlayıcı id giriniz");
            }
        }

        private void CategoryIdNotEmptyValidator()
        {
            if (Model.CategoryID <= 0)
            {
                IsValid = false;
                ValidationMessages.Add("Lütfen bir kategori id giriniz");
            }

        }
        #endregion
    }
}
