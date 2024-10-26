using MWFSDK.Data;
using MWFSDK.Data.Types.RenderConfigs;
using MWFSDK.Data.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MWFSDK.Data.Types.PackItems;

namespace MWFSDK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            InitializeComponent();
            ContentPackManager.InitContentTypes();
            ContentPackManager.LoadContentPacks("D:\\dev\\ModularWarfare\\run\\ModularWarfare");

        }
    }
}
