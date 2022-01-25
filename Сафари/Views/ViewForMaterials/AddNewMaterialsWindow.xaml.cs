using System.Windows;
using Сафари.ViewModels.ForMaterials;

namespace Сафари.Views.ViewForMaterials
{
    /// <summary>
    /// Логика взаимодействия для AddNewMaterialsWindow.xaml
    /// </summary>
    public partial class AddNewMaterialsWindow : Window
    {
        public AddNewMaterialsWindow()
        {
            InitializeComponent();
            DataContext = new MaterialsVM();
        }
    }
}
