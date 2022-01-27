using System.Collections.Generic;
using System.Windows;
using Сафари.Commands;
using Сафари.Data.DataWorker.ForMaterials;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.MainModels;
using Сафари.Views.ViewForMaterials;

namespace Сафари.ViewModels.ForMaterials
{
    public class MaterialsVM : SideProperties
    {
        public static string MaterialsName { get; set; }
        public static string MaterialsMeasure { get; set; }
        public static int MaterialsUnitPrice { get; set; }
        public static int MaterialsCount { get; set; }
        public int MaterialsFullPrice { get; set; }
        public static Materials SelectedMaterials { get; set; }

        public void UpdateAllMaterialsView()
        {
            AllMaterials = DataMaterials.GetAllMaterials();
            MaterialsWindow.AllMaterialsView.ItemsSource = null;
            MaterialsWindow.AllMaterialsView.Items.Clear();
            MaterialsWindow.AllMaterialsView.ItemsSource = AllMaterials;
            MaterialsWindow.AllMaterialsView.Items.Refresh();
        }

        private List<Materials> allMaterials = DataMaterials.GetAllMaterials();
        public List<Materials> AllMaterials
        {
            get
            { return allMaterials; }
            set
            {
                allMaterials = value;
                NotifyPropertyChanged("AllWorkers");
            }
        }
        public void SetNullValuesToMaterials()
        {
            MaterialsName = null;
            MaterialsMeasure = null;
            MaterialsUnitPrice = 0;
            MaterialsCount = 0;
            MaterialsFullPrice = 0;
        }
        private RelayCommand openAddNewMaterialsWnd;
        public RelayCommand OpenAddNewMaterialsWnd
        {
            get
            {
                return openAddNewMaterialsWnd ?? new RelayCommand(obj =>
                {
                    OpenAddMaterialsWindowMethod();
                }
                    );
            }
        }
        private void OpenAddMaterialsWindowMethod()
        {
            AddNewMaterialsWindow newMaterialsWindow = new AddNewMaterialsWindow();
            SetCenterPositionAndOpen(newMaterialsWindow);
        }
        private RelayCommand addNewMaterials;
        public RelayCommand AddNewMaterials
        {
            get
            {
                return addNewMaterials ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (MaterialsName == null || MaterialsName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "MaterialsNameBlock");
                    }
                    if (MaterialsMeasure == null)
                    {
                        SetRedBlockControll(wnd, "MaterialsMeasureBlock");
                    }
                    if (MaterialsUnitPrice == 0)
                    {
                        SetRedBlockControll(wnd, "MaterialsUnitPriceBlock");
                    }
                    if (MaterialsCount == 0)
                    {
                        SetRedBlockControll(wnd, "MaterialsCountBlock");
                    }
                    else
                    {
                        resultStr = DataMaterials.CreateMaterials(MaterialsName, MaterialsMeasure, MaterialsUnitPrice, MaterialsCount, MaterialsFullPrice);
                        ShowMessageToUser(resultStr);
                        UpdateAllMaterialsView();
                        SetNullValuesToMaterials();
                        wnd.Close();
                    }
                }
                );
            }
        }        
        private RelayCommand editMaterials;
        public RelayCommand EditMaterials
        {
            get
            {
                return editMaterials ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "Не вибраний співробітник";
                    if (SelectedMaterials != null)
                    {
                        resultStr = DataMaterials.EditMaterials(SelectedMaterials, MaterialsName, MaterialsMeasure, MaterialsUnitPrice, MaterialsCount, MaterialsFullPrice);
                        UpdateAllMaterialsView();
                        SetNullValuesToMaterials();
                        ShowMessageToUser(resultStr);
                        wnd.Close();
                    }
                    else ShowMessageToUser(resultStr);
                }
                );
            }
        }
        private RelayCommand openEditMaterialsWnd;
        public RelayCommand OpenEditMaterialsWnd
        {
            get
            {
                return openEditMaterialsWnd ?? new RelayCommand(obj =>
                {
                    OpenEditMaterialsWindowMethod(SelectedMaterials);
                } );
            }
        }
        private void OpenEditMaterialsWindowMethod(Materials material)
        {
            EditMaterialsWindow editMaterialsWindow = new EditMaterialsWindow(material);
            SetCenterPositionAndOpen(editMaterialsWindow);
        }
        public RelayCommand deleteMaterials;
        public RelayCommand DeleteMaterials
        {
            get
            {
                return deleteMaterials ?? new RelayCommand(obj =>
                {
                    string resultStr = "Не вибраний матеріал";
                    if (SelectedTabItem.Name == "MaterialsTab" && SelectedMaterials != null)
                    {
                        resultStr = DataMaterials.DeleteMaterials(SelectedMaterials);
                        UpdateAllMaterialsView();
                    }
                }
                );
            }
        }       
        
    }
}
