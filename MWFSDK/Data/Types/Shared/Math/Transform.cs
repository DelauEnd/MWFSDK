using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.Shared
{
    public class Transform
    {
        [JsonProperty("translate")]
        public Vector3f Translate {  get; set; }
        [JsonProperty("rotate")]
        public Vector3f Rotate { get; set;}
    }
}
