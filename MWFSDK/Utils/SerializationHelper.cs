using MWFSDK.Data.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MWFSDK.Utils
{
    public class SerializationHelper
    {
        public static void SerializeToFile(string filePath, ISafeJsonSerializable serializable)
        {
            if (!filePath.EndsWith(".json"))
                filePath += ".json";

            string json;
            if(serializable.GetOriginalJsonString() != null)
            {
                json = PatchJson(serializable.GetModifiedJsonString(), serializable.GetOriginalJsonString());
            }
            else
            {
                json = JsonConvert.SerializeObject(serializable, Formatting.Indented);
            }


            string directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            File.WriteAllText(filePath, json);
        }

        public static string PatchJson(string from, string to)
        {
            JObject target = JObject.Parse(to);
            JObject source = JObject.Parse(from);
            UpdateCommonValues(target, source);
            return target.ToString(Formatting.Indented);
        }

        static void UpdateCommonValues(JObject target, JObject source)
        {
            foreach (var property in source.Properties())
            {
                JToken targetValue;
                if (target.TryGetValue(property.Name, out targetValue))
                {
                    if (targetValue is JObject && property.Value is JObject)
                    {
                        UpdateCommonValues((JObject)targetValue, (JObject)property.Value);
                    }
                    else
                    {
                        target[property.Name] = property.Value;
                    }
                }
            }
        }
    }
}
