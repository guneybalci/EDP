using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.ExceptionHandling
{
    public class ModelNotValidException : ExceptionBase
    {
        // 10 karakter kuralı, farklı karakter girilemez gibi doğrulama işlemleri yapılabilir.
        public ModelNotValidException(List<string> validationMessage)
        {
            ValidationMessage = validationMessage;
        }

        public ModelNotValidException(List<string> validationMessage, string message) : base(message)
        {
            ValidationMessage = validationMessage;
        }

        public ModelNotValidException(List<string> validationMessage, string message, Exception innerException) : base(message, innerException)
        {

        }

        public List<string> ValidationMessage { get; set; }
    }
}
