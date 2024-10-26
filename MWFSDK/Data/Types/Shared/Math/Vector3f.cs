using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.Shared
{
    public class Vector3f
    {
        [JsonProperty("x")]
        public float X {  get; set; }
        [JsonProperty("y")]
        public float Y { get; set; }    
        [JsonProperty("z")]
        public float Z { get; set; }
    }
}
