using MWFSDK.Data.Types.PackItems;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.ItemConfigs
{
    public class TextureItemConfig : AbstractItemConfig
    {
        public enum TextureType
        {
            [JsonProperty("flash")]
            Flash,
            [JsonProperty("overlay")]
            Overlay
        }

        [JsonProperty("textureType")]
        public TextureType Type { get; set; }

        [JsonProperty("imageLocation")]
        public string[] ImageLocation { get; set; }

        public TextureItemConfig(AbstractContentPackItem item) : base(item)
        {
        }

        public override void CreateDefaultConfiguration()
        {
            
        }
    }
}
