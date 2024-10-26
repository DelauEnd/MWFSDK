using MWFSDK.Data.Types.ItemConfigs;
using MWFSDK.Data.Types.RenderConfigs;
using System;

namespace MWFSDK.Data.Types.PackItems
{
    public class AttachmentItem : AbstractContentPackItem
    {
        public AttachmentItem(ContentPack contentPack, string fileName) : base(contentPack, fileName)
        {
        }


        public static string FolderName = "attachments";
        public override string GetFolderName()
        {
            return FolderName;
        }

        public override Type GetItemConfigType()
        {
            return typeof(AttachmentItemConfig);
        }

        public override Type GetRenderConfigType()
        {
            return typeof(AttachmentRenderConfig);
        }
    }
}
