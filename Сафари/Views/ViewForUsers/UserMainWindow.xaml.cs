using System.Windows;
using Сафари.Views.ViewForMaterials;
using Сафари.Views.ViewsForWorkers;

namespace Сафари.Views.ViewForUsers
{
    /// <summary>
    /// Логика взаимодействия для UserMainWindow.xaml
    /// </summary>
    public partial class UserMainWindow : Window
    {
        public UserMainWindow()
        {
            InitializeComponent();
        }
        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MaterialsWindow materialsWindow = new MaterialsWindow();
            materialsWindow.Show();
            Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WorkersWindow workersWindow = new WorkersWindow();
            workersWindow.Show();
            Hide();
        }
    }
}
