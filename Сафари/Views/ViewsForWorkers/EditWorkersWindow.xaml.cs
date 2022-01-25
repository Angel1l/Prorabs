using System.Windows;
using Сафари.ViewModels.ForWorkers;

namespace Сафари.Views.ViewsForWorkers
{
    /// <summary>
    /// Логика взаимодействия для EditWorkersWindow.xaml
    /// </summary>
    public partial class EditWorkersWindow : Window
    {
        public EditWorkersWindow()
        {
            InitializeComponent();
            DataContext = new WorkersVM();
        }
    }
}
