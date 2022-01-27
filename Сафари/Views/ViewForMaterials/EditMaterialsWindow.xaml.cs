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
using Сафари.ViewModels.ForMaterials;

namespace Сафари.Views.ViewForMaterials
{
    /// <summary>
    /// Логика взаимодействия для EditMaterialsWindow.xaml
    /// </summary>
    public partial class EditMaterialsWindow : Window
    {
        public EditMaterialsWindow(Materials SelectedMaterials)
        {
            InitializeComponent();
            DataContext = new MaterialsVM();
            MaterialsVM.SelectedMaterials = SelectedMaterials;
            MaterialsVM.MaterialsCount = SelectedMaterials.Count;
            MaterialsVM.MaterialsMeasure = SelectedMaterials.Measure;
            MaterialsVM.MaterialsName = SelectedMaterials.Name;
            MaterialsVM.MaterialsUnitPrice = SelectedMaterials.UnitPrice;
        }
    }
}
