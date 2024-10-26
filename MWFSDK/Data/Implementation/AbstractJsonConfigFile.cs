using MWFSDK.Data.Interfaces;
using MWFSDK.Data.Types.PackItems;
using MWFSDK.Data.Types.RenderConfigs;
using MWFSDK.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Implementation
{
    public abstract class AbstractJsonConfigFile : IJsonConfigFile, ISafeJsonSerializable
    {
        [JsonIgnore]
        public AbstractContentPackItem Item { get; private set; }

        private string _originalJsonString;

        protected AbstractJsonConfigFile(AbstractContentPackItem item)
        {
            this.Item = item;
        }

        public string GetOriginalJsonString()
        {
            return _originalJsonString;
        }
        public string GetModifiedJsonString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public virtual void Load()
        {
            string filePath = GetFilePath();
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                if(!string.IsNullOrEmpty(json))
                {
                    _originalJsonString = json;
                    JsonConvert.PopulateObject(json, this);
                }
            }
            else
            {
                CreateDefaultConfiguration();
            }
        }

        public virtual void Save()
        {
            string filePath = GetFilePath();
            SerializationHelper.SerializeToFile(filePath, this);
        }

        public abstract string GetFilePath();

        public abstract void CreateDefaultConfiguration();
    }
}
