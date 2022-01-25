using System.Windows;

namespace Сафари.Views.ViewForUsers
{
    /// <summary>
    /// Логика взаимодействия для ShowMessageToUser.xaml
    /// </summary>
    public partial class ShowMessageToUser : Window
    {
        public ShowMessageToUser(string text)
        {
            InitializeComponent();
            MessageText.Text = text;
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
