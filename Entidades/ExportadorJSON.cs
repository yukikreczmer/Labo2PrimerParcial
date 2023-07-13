using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ExportadorJSON
    {
        public static string SerializarListaToJson<T>(List<T> dataList)
        {
            string json = JsonConvert.SerializeObject(dataList);
 
            return json;
        }
    }
}
