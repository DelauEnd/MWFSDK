using MWFSDK.Data.Types.ItemConfigs;
using MWFSDK.Data.Types.RenderConfigs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.PackItems
{
    public class TextureItem : AbstractContentPackItem
    {
        public TextureItem(ContentPack contentPack, string fileName) : base(contentPack, fileName)
        {
        }

        public static string FolderName = "textures";
        public override string GetFolderName()
        {
            return FolderName;
        }

        public override Type GetItemConfigType()
        {
            return typeof(TextureItemConfig);
        }

        public override Type GetRenderConfigType()
        {
            return typeof(EmptyRenderConfig);
        }
    }
}
