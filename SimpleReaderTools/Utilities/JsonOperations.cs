using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReaderTools.Utilities
{
    public class JsonOperations
    {
        public static string GetFormattedJson(string text, Formatting formatting)
        {
            return GetFormattedJson(GetDeserialize<object>(text), formatting);
        }

        public static string GetFormattedJson(object obj, Formatting formatting)
        {
            return JsonConvert.SerializeObject(obj, formatting);
        }

        public static T GetDeserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
