using EDP.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.TestConsole.Exception
{
    public class ExceptionManager
    {

        public string GetExceptionMessage(ExceptionBase exbs)
        {

            if (exbs is ModelNotValidException)
            {
                var mnve = (ModelNotValidException)exbs;

                string message = "";
                foreach (var item in mnve.ValidationMessage)
                {
                    message += item + " \n\r";
                }

                return message;
            }

            return "";
        }
    }
}
