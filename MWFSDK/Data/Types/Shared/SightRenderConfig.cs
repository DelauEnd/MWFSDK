using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.Shared
{
    public class SightRenderConfig
    {
        [JsonProperty("aimTranslate")]
        public Vector3f AimTranslate { get; set; }

        [JsonProperty("aimRotate")]
        public Vector3f AimRotate { get; set; }

        [JsonProperty("renderInsideGun")]
        public bool RenderInsideGun { get; set; }

        [JsonProperty("isMagnifier")]
        public bool IsMagnifier { get; set; }

        [JsonProperty("reticleModel")]
        public string ReticleModel { get; set; }

        [JsonProperty("scopeExtra")]
        public ScopeExtraConfig ScopeExtra { get; set; }

        [JsonProperty("fovZoom")]
        public float FovZoom { get; set; }

        [JsonProperty("mouseSensitivityFactor")]
        public float MouseSensitivityFactor { get; set; }

        [JsonProperty("maskTexture")]
        public string MaskTexture { get; set; }

        [JsonProperty("maskSize")]
        public float MaskSize { get; set; }

        [JsonProperty("uniformMaskRange")]
        public float UniformMaskRange { get; set; }

        [JsonProperty("uniformDrawRange")]
        public float UniformDrawRange { get; set; }

        [JsonProperty("uniformStrength")]
        public float UniformStrength { get; set; }

        [JsonProperty("uniformScaleRangeY")]
        public float UniformScaleRangeY { get; set; }

        [JsonProperty("uniformScaleStrengthY")]
        public float UniformScaleStrengthY { get; set; }

        [JsonProperty("uniformVerticality")]
        public float UniformVerticality { get; set; }

        public class ScopeExtraConfig
        {
            [JsonProperty("highlightEntities")]
            public bool HighlightEntities { get; set; }

            [JsonProperty("highlightColor")]
            public Vector3f HighlightColor { get; set; }

            [JsonProperty("disableEntityTexture")]
            public bool DisableEntityTexture { get; set; }

            [JsonProperty("postProcessEnabled")]
            public bool PostProcessEnabled { get; set; }

            [JsonProperty("postProcKernel")]
            public bool PostProcKernel { get; set; }

            [JsonProperty("postProcKernelMatrix")]
            public float[] PostProcKernelMatrix { get; set; }

            [JsonProperty("postProcCollorScale")]
            public bool PostProcCollorScale { get; set; }

            [JsonProperty("ignoredColorThreshold")]
            public float IgnoredColorThreshold { get; set; }

            [JsonProperty("ignoreEntityHighlightColor")]
            public bool IgnoreEntityHighlightColor { get; set; }

            [JsonProperty("colorScaleFactor")]
            public Vector3f ColorScaleFactor { get; set; }

            [JsonProperty("appliedColorFactor")]
            public Vector3f AppliedColorFactor { get; set; }

            [JsonProperty("resolution")]
            public int Resolution { get; set; }
        }
    }
}
