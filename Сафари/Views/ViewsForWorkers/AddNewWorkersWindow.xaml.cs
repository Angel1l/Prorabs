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
            DataContext = new DataManageVM();
        }
    }
}
