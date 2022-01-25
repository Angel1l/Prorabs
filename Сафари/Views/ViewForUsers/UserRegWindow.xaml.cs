using System.Windows;
using System.Windows.Controls;
using Сафари.ViewModels.ForUsers;

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
            DataContext = new UsersVM();
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
