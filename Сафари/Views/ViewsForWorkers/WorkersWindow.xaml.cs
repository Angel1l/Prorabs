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
    /// Логика взаимодействия для WorkersWindow.xaml
    /// </summary>
    public partial class WorkersWindow : Window
    {
        public static ListView AllWorkersView;
        public WorkersWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllWorkersView = ViewAllWorkers;
        }
    }
}
