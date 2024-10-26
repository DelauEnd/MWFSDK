using MWFSDK.Data.Types;
using MWFSDK.Data.Types.PackItems;
using MWFSDK.Data.Types.RenderConfigs;
using System;
using System.Collections.Generic;
using System.IO;

namespace MWFSDK.Data
{
    public class ContentPack
    {
        public string Name { get; private set; }
        public List<AbstractContentPackItem> ContentPackTypes { get; set; }

        public ContentPack(string dir) { this.Name = dir;  }

        public bool Load()
        {
            ContentPackTypes = new List<AbstractContentPackItem>();
            try
            {
                string contentPackFolder = Path.Combine(ContentPackManager.PacksFolderPath, Name);
                string[] contentTypesDirs = Directory.GetDirectories(contentPackFolder);
                foreach (string dirPath in contentTypesDirs)
                {
                    string dir = Path.GetFileName(dirPath);
                    if(ContentPackManager.ContentTypes.TryGetValue(dir, out Type contentType))
                    {
                        try
                        {
                            string[] packItems = Directory.GetFiles(Path.Combine(contentPackFolder, dir));
                            foreach (string packItemPath in packItems)
                            {
                                string packItem = Path.GetFileName(packItemPath);
                                if (!packItem.EndsWith(".json"))
                                    continue;

                                object obj = Activator.CreateInstance(contentType, this, packItem);
                                if(obj is AbstractContentPackItem contentPackType)
                                {
                                    ContentPackTypes.Add(contentPackType);
                                }
                            }
                        }
                        catch { }
                    }
                }
            }
            catch
            {
                return false;
            }

            return true;
        }

        public void Save()
        {
            foreach (var item in ContentPackTypes)
            {
                item.Save();
            }
        }
    }
}
