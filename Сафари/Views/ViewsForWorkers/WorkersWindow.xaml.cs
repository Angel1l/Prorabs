using System.Windows;
using System.Windows.Controls;
using Сафари.ViewModels.ForWorkers;
using Сафари.Views.ViewForUsers;

namespace Сафари.Views.ViewsForWorkers
{
    /// <summary>
    /// Логика взаимодействия для WorkersWindow.xaml
    /// </summary>
    public partial class WorkersWindow : Window
    {
        public static ListView AllWorkersView;
        public WorkersWindow()
        {
            InitializeComponent();
            DataContext = new WorkersVM();
            AllWorkersView = ViewAllWorkers;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserMainWindow userMainWindow = new UserMainWindow();
            userMainWindow.Show();
            Hide();
        }
    }
}
