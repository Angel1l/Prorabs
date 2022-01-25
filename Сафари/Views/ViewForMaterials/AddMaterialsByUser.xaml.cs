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
using Сафари.Data.Models.MaterialsModels;

namespace Сафари.Views.ViewForMaterials
{
    /// <summary>
    /// Логика взаимодействия для AddMaterialsByUser.xaml
    /// </summary>
    public partial class AddMaterialsByUser : Window
    {
        public AddMaterialsByUser()
        {
            InitializeComponent();
            DataContext = new CountOfBuyingByUsersMaterials();
        }
        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
