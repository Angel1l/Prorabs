using System.Windows;
using Сафари.Data.Models.MaterialsModels;

namespace Сафари.Views.ViewForMaterials
{
    /// <summary>
    /// Логика взаимодействия для BuyMaterialsByUsers.xaml
    /// </summary>
    public partial class BuyMaterialsByUsers : Window
    {
        public BuyMaterialsByUsers()
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
