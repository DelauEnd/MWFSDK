using MWFSDK.Data.Types.PackItems;
using MWFSDK.Data.Types.RenderConfigs;
using MWFSDK.Data.Types.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MWFSDK.Data.Types.RenderConfigs
{
    public class AttachmentRenderConfig : AbstractRenderConfig
    {
        [JsonProperty("modelFileName")]
        public string ModelFileName { get; set; }

        [JsonProperty("attachmentSlots")]
        public List<AttachmentSlotRenderConfig> AttachmentSlots { get; set; }

        [JsonProperty("sights")]
        public List<SightRenderConfig> SightRenderConfigs { get; set; }
        
        public AttachmentRenderConfig(AbstractContentPackItem item) : base(item)
        {
        }

        public override void CreateDefaultConfiguration()
        {
        }
    }
}
