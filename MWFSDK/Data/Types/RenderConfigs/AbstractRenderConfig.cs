using MWFSDK.Data.Implementation;
using MWFSDK.Data.Types.PackItems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.RenderConfigs
{
    public abstract class AbstractRenderConfig : AbstractJsonConfigFile
    {
        protected AbstractRenderConfig(AbstractContentPackItem item) : base(item)
        {
        }

        public override abstract void CreateDefaultConfiguration();

        public override string GetFilePath()
        {
//#if DEBUG
//            return Path.Combine(this.Item.ContentPack.Name, this.Item.GetFolderName(), "render", this.Item.FileName.Replace(".json", ".render.json"));
//#else
            return Path.Combine(ContentPackManager.PacksFolderPath, this.Item.ContentPack.Name, this.Item.GetFolderName(), "render", this.Item.FileName.Replace(".json", ".render.json"));
//#endif
        }
    }
}
