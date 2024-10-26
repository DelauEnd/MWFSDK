using MWFSDK.Data.Implementation;
using MWFSDK.Data.Types.ItemConfigs;
using MWFSDK.Data.Types.RenderConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWFSDK.Data.Types.PackItems
{
    public abstract class AbstractContentPackItem
    {
        public AbstractItemConfig ItemConfig { get; set; }
        public AbstractRenderConfig RenderConfig { get; set; }

        public ContentPack ContentPack { get; set; }
        public string FileName { get; set; }

        public AbstractContentPackItem(ContentPack contentPack, string fileName)
        {
            this.ContentPack = contentPack;
            this.FileName = fileName;

            var itemConfigInstance = Activator.CreateInstance(GetItemConfigType(), this);
            var renderConfigInstance = Activator.CreateInstance(GetRenderConfigType(), this);

            if(itemConfigInstance != null && itemConfigInstance is AbstractItemConfig itemConfig) 
            {
                ItemConfig = itemConfig;
            }

            if (renderConfigInstance != null && renderConfigInstance is AbstractRenderConfig renderConfig)
            {
                RenderConfig = renderConfig;
            }
            ItemConfig.Load();
            RenderConfig.Load();
        }

        public abstract Type GetItemConfigType();
        public abstract Type GetRenderConfigType();

        public abstract string GetFolderName();

        public void Save()
        {
            ItemConfig.Save();
            RenderConfig.Save();
        }

        public void Load()
        {
            ItemConfig.Load();
            RenderConfig.Load();
        }
    }
}
