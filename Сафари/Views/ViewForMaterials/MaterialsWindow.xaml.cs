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
            DataContext = new DataManageVM();
            AllMaterialsView = ViewAllMaterials;
            //SettingMaterialsDataBase settingMaterialsDataBase = new SettingMaterialsDataBase();
            //settingMaterialsDataBase.AddData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserMainWindow userMainWindow = new UserMainWindow();
            userMainWindow.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MaterialsAfterBuyingByUsers materialsAfterBuyingByUsers = new MaterialsAfterBuyingByUsers();
            materialsAfterBuyingByUsers.Show();
            Hide();
        }
    }
}
