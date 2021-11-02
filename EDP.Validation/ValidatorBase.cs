using EDP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Validation
{
    public abstract class ValidatorBase<TModel> where TModel : class, IModel
    {
        public ValidatorBase(TModel model)
        {
            Model = model;

            ValidationMessages = new List<string>();

            IsValid = true;

            OnValidate();
        }



        // Biz set edilme işlemi yapmıyacağız. Sistem alt yapı kendisi yapıcak ve kimse ulaşıp değiştirmesini engelliyoruz.
        public TModel Model { get; private set; }

        // Küçüklük-Büyüklük, null, boşluk işlemlerini yakalamak bir liste yani tutacağız.
        public List<string> ValidationMessages { get; private set; }

        // procted olması: bunu kontrol eden method yok. Abstract Class olduğu için nasıl validate edildiği bilgisi olacak "true" mu "false" mu inherit edildiği yerden vericek; bizde bir abstract method oluştururuz "OnValidate"
        public bool IsValid { get; protected set; }


        // Neden böyle yaptık ? bu sınıfı kullanmak isterken test de bu class ' ı "new" leyip bu methodu çalıştırmamız gerekiyordu. Ancak böylece ctor da direk olarak çalışacaktır.
        public abstract void OnValidate();

    }
}
