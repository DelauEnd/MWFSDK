using MWFSDK.Data.Types.PackItems;
using MWFSDK.Data.Types.Shared;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MWFSDK.Data.Types.ItemConfigs
{
    public class AttachmentItemConfig : AbstractItemConfig
    {
        [JsonProperty("attachmentType")]
        public string AttachmentType { get; set; }

        [JsonProperty("defaultAttachments")]
        public Dictionary<string, string> DefaultAttachments { get; set; } = new Dictionary<string, string>();

        [JsonProperty("modifiers")]
        public ModifiersConfig Modifiers { get; set; }

        [JsonProperty("barrel")]
        public BarrelConfig Barrel { get; set; }

        [JsonProperty("sights")]
        public List<SightConfig> Sights { get; set; }

        [JsonProperty("isLaser")]
        public bool IsLaser { get; set; }

        [JsonProperty("isFlashlight")]
        public bool IsFlashlight { get; set; }

        [JsonProperty("isGrip")]
        public bool IsGrip { get; set; }

        [JsonProperty("sameTextureAsGun")]
        public bool SameTextureAsGun { get; set; }

        [JsonProperty("attachmentSlots")]
        public List<AttachmentSlotConfig> AttachmentSlots { get; set; } = new List<AttachmentSlotConfig>();

        [JsonProperty("conflictAttachmentTypes")]
        public List<string> ConflictAttachmentTypes { get; set; } = new List<string>();

        [JsonProperty("canBeDetached")]
        public bool CanBeDetached { get; set; }
    
        public AttachmentItemConfig(AbstractContentPackItem item) : base(item)
        {
        }

        public override void CreateDefaultConfiguration()
        {

        }



        public class ModifiersConfig
        {
            [JsonProperty("cameraVerticalRecoilMod")]
            public float CameraVerticalRecoilMod { get; set; }

            [JsonProperty("cameraHorizontalRecoilMod")]
            public float CameraHorizontalRecoilMod { get; set; }

            [JsonProperty("gunVerticalRecoilMod")]
            public float GunVerticalRecoilMod { get; set; }

            [JsonProperty("gunHorizontalRecoilMod")]
            public float GunHorizontalRecoilMod { get; set; }

            [JsonProperty("ergonomicFactor")]
            public float ErgonomicFactor { get; set; }
        }

        public class SightConfig
        {
            [JsonProperty("modeType")]
            public WeaponScopeModeType ModeType { get; set; }

            [JsonProperty("customOverlayTexture")]
            public string CustomOverlayTexture { get; set; }

            [JsonProperty("usedDefaultOverlayModelTexture")]
            public bool UsedDefaultOverlayModelTexture { get; set; }

            [JsonProperty("extraScope")]
            public bool ExtraScope { get; set; }

            public enum WeaponScopeModeType
            {
                [JsonProperty("simple")]
                SIMPLE,
                [JsonProperty("normal")]
                NORMAL,
                [JsonProperty("pip")]
                PIP
            }
        }

        public class BarrelConfig
        {
            [JsonProperty("isSuppressor")]
            public bool IsSuppressor { get; set; }

            [JsonProperty("hideFlash")]
            public bool HideFlash { get; set; }
        }
    }
}
