using MWFSDK.Data.Types.PackItems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.ItemConfigs
{
    public class SprayItemConfig : AbstractItemConfig
    {
        [JsonProperty("skinName")]
        public string SkinName { get; set; }

        public SprayItemConfig(AbstractContentPackItem item) : base(item)
        {
        }

        public override void CreateDefaultConfiguration()
        {
        }
    }
}
