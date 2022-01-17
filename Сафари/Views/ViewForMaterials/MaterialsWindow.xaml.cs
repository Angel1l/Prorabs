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
using System.Windows.Shapes;
using Сафари.Data.MainData;
using Сафари.ViewModels;

namespace Сафари.Views.ViewForMaterials
{
    /// <summary>
    /// Логика взаимодействия для MaterialsWindow.xaml
    /// </summary>
    public partial class MaterialsWindow : Window
    {
        public static ListView AllMaterialsView;
        public MaterialsWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllMaterialsView = ViewAllMaterials;
            SettingMaterialsDataBase settingMaterialsDataBase = new SettingMaterialsDataBase();
            settingMaterialsDataBase.AddData();
        }
    }
}
