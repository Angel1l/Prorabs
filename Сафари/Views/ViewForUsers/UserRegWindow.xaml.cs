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
using Сафари.ViewModels;

namespace Сафари.Views.ViewForUsers
{
    /// <summary>
    /// Логика взаимодействия для UserRegWindow.xaml
    /// </summary>
    public partial class UserRegWindow : Window
    {
        public UserRegWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).password = ((PasswordBox)sender).Password; }
        }

        private void PasswordBox_PasswordChanged2(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).password2 = ((PasswordBox)sender).Password; }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainUserWindow mainUserWindow = new MainUserWindow();
            mainUserWindow.Show();
            Hide();
            this.Close();
        }
    }
}
