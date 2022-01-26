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
using Сафари.Data.Models.CountModels;

namespace Сафари.Views.ViewForMaterials
{
    /// <summary>
    /// Логика взаимодействия для CountWindow.xaml
    /// </summary>
    public partial class CountWindow : Window
    {
        public CountWindow()
        {
            InitializeComponent();
            DataContext = new CountOfBuyingByUsersMaterials();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
