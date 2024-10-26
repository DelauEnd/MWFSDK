using MWFSDK.Data.Implementation;
using MWFSDK.Data.Types.PackItems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.ItemConfigs
{
    public abstract class AbstractItemConfig : AbstractJsonConfigFile
    {     
        [JsonProperty("internalName")]
        public string InternalName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        public AbstractItemConfig(AbstractContentPackItem item) : base(item)
        {
        }

        public override abstract void CreateDefaultConfiguration();

        public override string GetFilePath()
        {
//#if DEBUG
//            return Path.Combine(this.Item.ContentPack.Name, this.Item.GetFolderName(), this.Item.FileName);
//#else
            return Path.Combine(ContentPackManager.PacksFolderPath, this.Item.ContentPack.Name, this.Item.GetFolderName(), this.Item.FileName);
//#endif
        }
    }
}
