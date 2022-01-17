using System.Windows;
using System.Windows.Controls;
using Сафари.ViewModels;
using Сафари.Views.ViewForUsers;

namespace Сафари.Views
{
    /// <summary>
    /// Логика взаимодействия для MainUserWindow.xaml
    /// </summary>
    public partial class MainUserWindow : Window
    {
        public MainUserWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            //SettingMaterialsDataBase settingMaterialsDataBase = new SettingMaterialsDataBase();
            //settingMaterialsDataBase.AddData();
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).UsersPassword = ((PasswordBox)sender).Password; }
        }

        private void Button_RegWindow_Click(object sender, RoutedEventArgs e)
        {
            UserRegWindow userRegWindow = new UserRegWindow();
            userRegWindow.Show();
            this.Close();
        }
    }
}
