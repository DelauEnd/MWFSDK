using MWFSDK.Data.Types.ItemConfigs;
using MWFSDK.Data.Types.RenderConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MWFSDK.Data.Types.PackItems
{
    public class SprayItem : AbstractContentPackItem
    {
        public SprayItem(ContentPack contentPack, string fileName) : base(contentPack, fileName)
        {
        }


        public static string FolderName = "sprays";
        public override string GetFolderName()
        {
            return FolderName;
        }

        public override Type GetItemConfigType()
        {
            return typeof(SprayItemConfig);
        }

        public override Type GetRenderConfigType()
        {
            return typeof(EmptyRenderConfig);
        }
    }
}
