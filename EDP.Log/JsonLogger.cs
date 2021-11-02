using EDP.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDP.Log
{
    // ILogger'daki T > JsonLogger'da T yerine geçicektir otamatikmen!
    public class JsonLogger<T> : ILogger<T> where T : class, IModel
    {
        // C:\Files klasöründe dosya olarak oluşturarak içerisine yazıcaz.
        //Teknolojiye göre ayarlardan okunmalı _path kullanımı yanlıştır. Düz MVC'de webconfig'den okumalıyız MVCCore ile appsettings.json'dan okuyabiliriz. Yolu kimse görmemelidir.
        private readonly string _fileName;

        // Ayardan okunabilir.
        private string _path = "C:\\Files";


        public JsonLogger(string fileName)
        {
            _fileName = fileName + ".json";
        }

        public void DoLog(T model)
        {
            // Serilize edip atıcaz. Serialize 
            string strJson = JsonConvert.SerializeObject(model);

            string fullPath = Path.Combine(_path, _fileName);

            File.WriteAllText(fullPath, strJson);
        }
    }
}
