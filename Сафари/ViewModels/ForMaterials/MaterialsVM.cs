using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Сафари.Commands;
using Сафари.Data;
using Сафари.Data.DataWorker.ForMaterials;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.MainModels;
using Сафари.Views.ViewForMaterials;

namespace Сафари.ViewModels.ForMaterials
{
    public class MaterialsVM : SideProperties
    {
        public string MaterialsName { get; set; }
        public string MaterialsMeasure { get; set; }
        public int MaterialsUnitPrice { get; set; }       
        public static Materials SelectedMaterial { get; set; }


        private List<Materials> allMaterials = new List<Materials>();
        public List<Materials> AllMaterials
        {
            get
            { return allMaterials; }
            set
            {
                allMaterials = value;
                NotifyPropertyChanged("AllMaterials");
            }
        }
        private List<ResMaterial> allForUserMaterials = getMaterialsForUser();
        public List<ResMaterial> AllForUserMaterials
        {
            get
            { return allForUserMaterials; }
            set
            {
                allForUserMaterials = value;
                NotifyPropertyChanged("AllForUserMaterials");
            }
        }
        private static List<ResMaterial> getMaterialsForUser()
        {
            return DataMaterials.GetMaterialForTheUserMaterials();
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
        public void UpdateAllMatetialsView()
        {
            AllMaterials = DataMaterials.GetAllMaterials();
            MaterialsWindow.AllMaterialsView.ItemsSource = null;
            MaterialsWindow.AllMaterialsView.Items.Clear();
            MaterialsWindow.AllMaterialsView.ItemsSource = AllMaterials;
            MaterialsWindow.AllMaterialsView.Items.Refresh();
        }
        public void SetNullValuesToMaterials()
        {
            //
            MaterialsName = null;
            MaterialsMeasure = null;
            MaterialsUnitPrice = 0;
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
                        SetRedBlockControll(wnd, "NaimenovanieBlock");
                    }
                    if (MaterialsMeasure == null)
                    {
                        SetRedBlockControll(wnd, "MeasureBlock");
                    }
                    if (MaterialsUnitPrice == 0)
                    {
                        SetRedBlockControll(wnd, "UnitPriceBlock");
                    }                    
                    else
                    {
                        resultStr = DataMaterials.CreateMaterials(MaterialsName, MaterialsMeasure, MaterialsUnitPrice);
                        ShowMessageToUser(resultStr);
                        UpdateAllMatetialsView();
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
                    string nocategory = "";
                    if (SelectedMaterial != null)
                    {
                        resultStr = DataMaterials.EditMaterials(SelectedMaterial, MaterialsName, MaterialsMeasure, MaterialsUnitPrice);
                        UpdateAllMatetialsView();
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
                    OpenEditMaterialsWindowMethod();
                }
                    );
            }
        }
        private void OpenEditMaterialsWindowMethod()
        {
            EditMaterialsWindow editMaterialsWindow = new EditMaterialsWindow();
            SetCenterPositionAndOpen(editMaterialsWindow);
        }
        public RelayCommand deleteMaterials;
        public RelayCommand DeleteMaterials
        {
            get
            {
                return deleteMaterials ?? new RelayCommand(obj =>
                {
                    string resultStr = "Не вибраний співробітник";
                    if (SelectedTabItem.Name == "MaterialsTab" && SelectedMaterial != null)
                    {
                        resultStr = DataMaterials.DeleteMaterials(SelectedMaterial);
                        UpdateAllMatetialsView();
                    }
                }
                );
            }
        }
        public static SideProperties _dataManageVM = new SideProperties();
        public static string UsersLogin { get; set; }

        private RelayCommand buyMaterials;
        public RelayCommand BuyMaterials
        {
            get
            {
                return buyMaterials ?? (new RelayCommand(obj =>
                {
                    _dataManageVM.SetCenterPositionAndOpen(new AddMaterialsByUser());

                    using (ApplicationContext db = new ApplicationContext())
                    {
                        var user = db.Users.Where(u => u.Login == UsersLogin).FirstOrDefault();

                        db.UsersWithMaterials.Add(new UsersWithMaterials(user.Id, SelectedMaterial.Id, int.Parse(CountOfBuyingByUsersMaterials.count)));
                        db.SaveChanges();
                    }
                }));
            }
        }
        public static ResMaterial SelectedMaterialForUser { get; set; }
    }
}
