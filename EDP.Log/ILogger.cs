using EDP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Log
{
    // NLog & Log4Net kullanabiliriz Ancak AOP bilgisi olan bir kişi yapıyı kurabilir. Third-part kullanmanıza gerek yoktur.
    public interface ILogger<T> where T : class, IModel
    {
        void DoLog(T model);
    }
}
