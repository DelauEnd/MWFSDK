using MWFSDK.Data.Types.PackItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.RenderConfigs
{
    public class EmptyRenderConfig : AbstractRenderConfig
    {
        public EmptyRenderConfig(AbstractContentPackItem item) : base(item)
        {
        }



        public override void CreateDefaultConfiguration()
        {
        }
    }
}
