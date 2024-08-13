using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SimpleReaderTools.Core.Utilities
{
    public class JsonOperations
    {
        public static string SerializeXmlNode(XmlDocument doc)
        {
            return JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented);
        }
        public static string GetFormattedJson(string text, Newtonsoft.Json.Formatting formatting)
        {
            return GetFormattedJson(GetDeserialize<object>(text), formatting);
        }

        public static string GetFormattedJson(object obj, Newtonsoft.Json.Formatting formatting)
        {
            return JsonConvert.SerializeObject(obj, formatting);
        }

        public static T GetDeserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string JsonPropertiesOrder(string json, Newtonsoft.Json.Formatting formatting)
        {
            var jobj = JObject.Parse(json);
            var target = KeySort(jobj);
            return GetFormattedJson(target, formatting);
        }

        private static SortedDictionary<string, object> KeySort(JObject obj)
        {
            if (obj == null) return null;

            var res = new SortedDictionary<string, object>();

            foreach (var x in obj)
            {
                try
                {
                    if (x.Value is JValue) res.Add(x.Key, x.Value);
                    else if (x.Value is JObject) res.Add(x.Key, KeySort((JObject)x.Value));
                    else if (x.Value is JArray)
                    {
                        var tmp = new SortedDictionary<string, object>[x.Value.Count()];
                        for (var i = 0; i < x.Value.Count(); i++)
                        {
                            tmp[i] = x.Value[i].HasValues ? KeySort((JObject)x.Value[i]) : null;
                        }
                        res.Add(x.Key, tmp);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error Key - {x.Key} - {ex.Message}");
                }
            }

            return res;
        }
    }
}
