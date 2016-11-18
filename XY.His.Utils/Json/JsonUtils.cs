using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XY.His.Utils.Json
{
    public class JsonUtils
    {
        public static T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public static string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
