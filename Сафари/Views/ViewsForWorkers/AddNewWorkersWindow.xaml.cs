using System.Windows;
using Сафари.ViewModels.ForWorkers;

namespace Сафари.Views.ViewsForWorkers
{
    /// <summary>
    /// Логика взаимодействия для AddNewWorkersWindow.xaml
    /// </summary>
    public partial class AddNewWorkersWindow : Window
    {
        public AddNewWorkersWindow()
        {
            InitializeComponent();
            DataContext = new WorkersVM();
        }
    }
}
