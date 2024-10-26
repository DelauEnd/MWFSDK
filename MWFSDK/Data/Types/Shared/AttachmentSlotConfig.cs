using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.Shared
{
    public class AttachmentSlotConfig
    {
        [JsonProperty("hidenSlot")]
        public bool HiddenSlot { get; set; }

        [JsonProperty("allowedAttachmentTypes")]
        public List<string> AllowedAttachmentTypes { get; set; } = new List<string>();

        [JsonProperty("slotName")]
        public string SlotName { get; set; }
    }
}
