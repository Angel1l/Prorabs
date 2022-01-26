using System.Windows;
using System.Windows.Controls;
using Сафари.ViewModels.ForMaterials;
using Сафари.Views.ViewForUsers;

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
            DataContext = new MaterialsVM();
            AllMaterialsView = ViewAllMaterials;
            //SettingMaterialsDataBase settingMaterialsDataBase = new SettingMaterialsDataBase();
            //settingMaterialsDataBase.AddData();
        }     
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserMainWindow userMainWindow = new UserMainWindow();
            userMainWindow.Show();
            Hide();
        }
    }
}
