using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.ExceptionHandling
{
    // Exception Class'ı dışında farklı yetenekler uygulamak istiyor yani örneğin mesajları yakalayıp "Loglama" yapmak istersek burada yapabiliriz.
    public class ExceptionBase : Exception
    {
        public ExceptionBase()
        {

        }

        // AOP sistem uyguluyor ve Base "Exception" class'ına gönderiyoruz.
        public ExceptionBase(string message) : base(message)
        {

        }

        // AOP sistem uyguluyor ve Base "Exception" class'ına gönderiyoruz.
        public ExceptionBase(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
