using MWFSDK.Data.Types;
using MWFSDK.Data.Types.PackItems;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data
{
    public class ContentPackManager
    {
        public static string PacksFolderPath { get; private set; }
        public static Dictionary<string, Type> ContentTypes { get; private set; }
        
        public static List<ContentPack> ContentPacks = new List<ContentPack>();

        public static List<ContentPack> LoadContentPacks(string folderPath)
        {
            ContentPacks.Clear();

            PacksFolderPath = folderPath;
            try
            {
                string[] contentPacksDirs = Directory.GetDirectories(PacksFolderPath);
                foreach (string dir in contentPacksDirs)
                {
                    string packName = Path.GetFileName(dir);
                    ContentPack contentPack = new ContentPack(packName);
                    if(contentPack.Load())
                        ContentPacks.Add(contentPack);
                }
            }
            catch
            {

            }

            return ContentPacks;
        }

        public static void InitContentTypes()
        {
            ContentTypes = new Dictionary<string, Type>
            {
                {AttachmentItem.FolderName, typeof(AttachmentItem)},
                {SprayItem.FolderName, typeof(SprayItem)},
                {TextureItem.FolderName, typeof(TextureItem)},
            };
        }
    }
}
