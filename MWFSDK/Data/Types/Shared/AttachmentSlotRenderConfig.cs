using Newtonsoft.Json;

namespace MWFSDK.Data.Types.Shared
{
    public class AttachmentSlotRenderConfig
    {
        [JsonProperty("attachPoint")]
        public Transform AttachPoint {  get; set; }
        [JsonProperty("aimPoint")]
        public Transform AimPoint { get; set; }
        [JsonProperty("leftHandPosition")]
        public Transform LeftHandPos { get; set; }
    }
}
