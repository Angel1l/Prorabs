using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Сафари.Commands;
using Сафари.Data.DataWorker;
using Сафари.Data.Enum;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.Data.Models.WorkersModels;
using Сафари.ViewModels.ForUsers;
using Сафари.Views;
using Сафари.Views.ViewForMaterials;
using Сафари.Views.ViewForUsers;
using Сафари.Views.ViewsForWorkers;

namespace Сафари.ViewModels
{
    public class DataManageVM : INotifyPropertyChanged
    {

        #region Свойства для входа
        public static string UsersLogin { get; set; }
        public string UsersPassword { get; set; }

        private RelayCommand enterToProgramm;
        public RelayCommand EnterToProgramm
        {
            get
            {
                return enterToProgramm ?? (new RelayCommand(obj =>
                {
                    if(UsersLogin.Length == 0 || UsersPassword.Length == 0)
                    {
                        MessageBoxResult result = MessageBox.Show("Login or password incorrect");
                    }
                    else
                    {
                        var User =  DataWorker.findUser(UsersLogin, UsersPassword);

                        if(User != null)
                        {

                            UserMainWindow userMainWindow = new UserMainWindow();
                            SetCenterPositionAndOpen(userMainWindow);

                        }
                        else
                        {
                            MessageBoxResult result = MessageBox.Show("Login or password incorrect, if have not any account, you should create one");
                        }
                    }


                }));
            }
        }


        #endregion

        #region Свойства для Регистрации 

        public string login { get; set; } = "";
        public string password { get; set; } = "";
        public string password2 { get; set; } = "";
        public string email { get; set; } = "";

        private RelayCommand addUsersToDatabase;
        public RelayCommand AddUsersToDatabase {

            get
            {
                return addUsersToDatabase ?? (new RelayCommand(obj =>
                {

                    if (login.Length > 0 && password == password2 &&
                    email.Contains("@") && email.Contains(".") && email.Length > 0)
                    {
                        DataWorker.addUser(login, password, email);
                    }
                    else
                    {
                        MessageBoxResult result = MessageBox.Show("Something incorrect");
                    }

                }));
            }
        
        }

        #endregion

        #region Все отделы         
        //public static DataWorker _dataWorker = new DataWorker();
        //private List<BuyMaterials> _buymaterials = _dataWorker.GetMaterialsForUser();
        //public List<BuyMaterials> _BuyMaterials
        //{
        //    get { return _buymaterials; }
        //    set { _buymaterials = value; }
        //}

        private List<Materials> allMaterials = new List<Materials>();
        public List<Materials> AllMaterials 
        { get 
            { return allMaterials; }
            set
            {
                allMaterials = value;
                NotifyPropertyChanged("AllMaterials");
            }
        }

        private RelayCommand allButtonMaterial;
        public RelayCommand AllButtonMaterial
        {
            get
            {
                return allButtonMaterial ?? (new RelayCommand(obj =>
                {
                    allMaterials = DataWorker.GetAllMaterials();
                    UpdateAllMatetialsView();

                }));
            }
        }


        private List<Workers> allWorkers = DataWorker.GetAllWorkers();
        public List<Workers> AllWorkers
        {
            get
            { return allWorkers; }
            set
            {
                allWorkers = value;
                NotifyPropertyChanged("AllWorkers");
            }
        }
        private List<CategoryMaterials> allCategoryMaterials = DataWorker.GetAllCategoryMaterials();
        public List<CategoryMaterials> AllCategoryMaterials
        {
            get
            { return allCategoryMaterials; }
            set
            {
                allCategoryMaterials = value;
                NotifyPropertyChanged("AllCategoryMaterials");
            }
        }
        #endregion

        #region Отделы материалов
        private RelayCommand materialsForWalls;
        public RelayCommand MaterialsForWalls
        {
            get
            {
                return materialsForWalls ?? (new RelayCommand(obj =>
                {
                    allMaterials = DataWorker.GetAllMaterials().Where(m => m.CategoryMaterialsId == ((int)EnumForCategoryMaterials.MaterialsForWalls)).ToList();
                    UpdateAllMatetialsView();

                }));
            }
        }
        private RelayCommand materialsForRoofing;
        public RelayCommand MaterialsForRoofing
        {
            get
            {
                return materialsForRoofing ?? (new RelayCommand(obj =>
                {
                    allMaterials = DataWorker.GetAllMaterials().Where(m => m.CategoryMaterialsId == ((int)EnumForCategoryMaterials.MaterialsForRoofing)).ToList();
                    UpdateAllMatetialsView();

                }));
            }
        }
        private RelayCommand materialsForFoundation;
        public RelayCommand MaterialsForFoundation
        {
            get
            {
                return materialsForFoundation ?? (new RelayCommand(obj =>
                {
                    allMaterials = DataWorker.GetAllMaterials().Where(m => m.CategoryMaterialsId == ((int)EnumForCategoryMaterials.MaterialsForFoundation)).ToList();
                    UpdateAllMatetialsView();

                }));
            }
        }
        private RelayCommand materialsForFloor;
        public RelayCommand MaterialsForFloor
        {
            get
            {
                return materialsForFloor ?? (new RelayCommand(obj =>
                {
                    allMaterials = DataWorker.GetAllMaterials().Where(m => m.CategoryMaterialsId == ((int)EnumForCategoryMaterials.MaterialsForFloor)).ToList();
                    UpdateAllMatetialsView();

                }));
            }
        }
        private RelayCommand materialsForCeilings;
        public RelayCommand MaterialsForCeilings
        {
            get
            {
                return materialsForCeilings ?? (new RelayCommand(obj =>
                {
                    allMaterials = DataWorker.GetAllMaterials().Where(m => m.CategoryMaterialsId == ((int)EnumForCategoryMaterials.MaterialsForCeilings)).ToList();
                    UpdateAllMatetialsView();

                }));
            }
        }
        #endregion

        #region INotifyPropertyChanged       
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region  Команды додавание Материалов/Работников/Users  
        //Свойства для Работника
       
        public string WorkersName { get; set; }
        public string WorkersSurname { get; set; }
        public string WorkersPatronymic { get; set; }
        public string WorkersPhone { get; set; }
        public string WorkersNotes { get; set; }

        private RelayCommand addNewWorkers;
        public RelayCommand AddNewWorkers
        {
            get
            {
                return addNewWorkers ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    if (WorkersName == null || WorkersName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControll(wnd, "SurnameBlock");
                    }
                    if (WorkersSurname == null)
                    {
                        SetRedBlockControll(wnd, "NameBlock");
                    }
                    if (WorkersPatronymic == null)
                    {
                        SetRedBlockControll(wnd, "PatronymicBlock");
                    }
                    if (WorkersPhone == null)
                    {
                        SetRedBlockControll(wnd, "PhoneBlock");
                    }
                    if (WorkersNotes == null)
                    {
                        SetRedBlockControll(wnd, "NotesBlock");
                    }
                    else
                    {
                        resultStr = DataWorker.CreateWorkers(WorkersName, WorkersSurname, WorkersPatronymic, WorkersPhone, WorkersNotes);
                        ShowMessageToUser(resultStr);
                        UpdateAllWorkersView();
                        SetNullValuesToProperties();
                        wnd.Close();
                    }
                }
                );
            }
        }
        private RelayCommand editWorkers;
        public RelayCommand EditWorkers
        {
            get
            {
                return editWorkers ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "Не вибраний співробітник";
                    if (SelectedWorkers != null)
                    {
                        resultStr = DataWorker.EditWorkers(SelectedWorkers, WorkersName, WorkersSurname, WorkersPatronymic, WorkersPhone, WorkersNotes);
                        UpdateAllWorkersView();
                        SetNullValuesToProperties();
                        ShowMessageToUser(resultStr);
                        wnd.Close();
                    }
                    else ShowMessageToUser(resultStr);
                }
                );
            }
        }

        //Свойства для Материала

        public string MaterialsName { get; set; }
        public string MaterialsMeasure { get; set; }
        public int MaterialsUnitPrice { get; set; }
        public CategoryMaterials MaterialsCategoryMaterialsId { get; set; }

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
                    if (MaterialsCategoryMaterialsId == null)
                    {
                        MessageBox.Show("Вкажіть відділ");
                    }                   
                    else
                    {
                        resultStr = DataWorker.CreateMaterials(MaterialsName, MaterialsMeasure, MaterialsUnitPrice, MaterialsCategoryMaterialsId);
                        ShowMessageToUser(resultStr);
                        UpdateAllMatetialsView();
                        SetNullValuesToProperties();
                        wnd.Close();
                    }
                }
                );
            }
        }
        public static DataManageVM _dataManageVM = new DataManageVM();
        private RelayCommand buyMaterials;
        public RelayCommand BuyMaterials
        {
            get
            {
                return buyMaterials ?? (new RelayCommand(obj =>
                {
                    _dataManageVM.SetCenterPositionAndOpen(new BuyMaterialsByUsers());

                    using (ApplicationContext db = new ApplicationContext())
                    {
                        var user = db.Users.Where(u => u.Login == UsersLogin).FirstOrDefault();

                        db.UsersWithMaterials.Add(new UsersWithMaterials(user.Id, SelectedMaterial.Id, int.Parse(CountOfBuyingByUsersMaterials.count)));
                        db.SaveChanges();
                    }
                }));
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
                        resultStr = DataWorker.EditMaterials(SelectedMaterial, MaterialsName, MaterialsMeasure, MaterialsUnitPrice,MaterialsCategoryMaterialsId);
                        UpdateAllMatetialsView();
                        SetNullValuesToProperties();
                        ShowMessageToUser(resultStr);
                        wnd.Close();
                    }
                    else ShowMessageToUser(resultStr);
                }
                );
            }
        }
        //Свойства для выделеных елементов
        public static Materials SelectedMaterial { get; set; }
        public static Workers SelectedWorkers { get; set; }
        public static TabItem SelectedTabItem { get; set; }
        #endregion

        #region Команды удаления
        private RelayCommand deleteEverything;
        public RelayCommand DeleteEverything
        {
            get
            {
                return deleteEverything ?? new RelayCommand(obj =>
                {                   
                    string resultStr = "Нічого не вибрано";
                    if (SelectedTabItem.Name == "WorkersTab" && SelectedWorkers != null)
                    {
                        resultStr = DataWorker.DeleteWorkers(SelectedWorkers);
                        UpdateAllMatetialsView();
                    }
                    if (SelectedTabItem.Name == "MaterialsTab" && SelectedMaterial != null)
                    {
                        resultStr = DataWorker.DeleteMaterials(SelectedMaterial);
                        UpdateAllMatetialsView();
                    }
                    SetNullValuesToProperties();
                    ShowMessageToUser(resultStr);
                }
                );
            }
        }
        #endregion

        #region Побочные свойства: SetRedBlockControll,ShowMessageToUser,SetCenterPositionAndOpen,SetNullValuesToProperties
        private void SetNullValuesToProperties()
        {
            //
            MaterialsName = null;
            MaterialsMeasure = null;
            MaterialsUnitPrice = 0;
            //
            WorkersName = null;             
            WorkersSurname = null;
            WorkersPatronymic = null;
            WorkersPhone = null;
            WorkersNotes = null;
        }
        private void SetRedBlockControll(Window wnd, string blockname)
        {
            Control block = wnd.FindName(blockname) as Control;
            block.BorderBrush = Brushes.Red;
        }
        private void ShowMessageToUser(string message)
        {
            ShowMessageToUser messageView = new ShowMessageToUser(message);
            SetCenterPositionAndOpen(messageView);
        }
        private void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        #endregion

        #region Методы открытия окон Материалов/Работников/Users       
        
        private void OpenAddMaterialsWindowMethod()
        {
            AddNewMaterialsWindow newMaterialsWindow = new AddNewMaterialsWindow();
            SetCenterPositionAndOpen(newMaterialsWindow);
        }
        private void OpenEditMaterialsWindowMethod()
        {
            EditMaterialsWindow editMaterialsWindow = new EditMaterialsWindow();
            SetCenterPositionAndOpen(editMaterialsWindow);
        }
        private void OpenAddWorkersWindowMethod()
        {
            AddNewWorkersWindow newWorkersWindow = new AddNewWorkersWindow();
            SetCenterPositionAndOpen(newWorkersWindow);
        }
        private void OpenEditWorkersWindowMethod()
        {
            EditWorkersWindow editWorkersWindow = new EditWorkersWindow();
            SetCenterPositionAndOpen(editWorkersWindow);
        }
        private void OpenAddUsersWindowMethod()
        {
            UserMainWindow newUsersWindow = new UserMainWindow();
            SetCenterPositionAndOpen(newUsersWindow);
        }
        private void OpenAddUsersRegistrationWindowMethod()
        {
            UserRegWindow userRegWindow = new UserRegWindow();
            SetCenterPositionAndOpen(userRegWindow);
        }
        private void OpenUserMainWindowMethod()
        {
            UserMainWindow newUserMainWindow = new UserMainWindow();
            SetCenterPositionAndOpen(newUserMainWindow);
        }
        private void OpenWorkersMainWindowMethod()
        {
            WorkersWindow workersWindow = new WorkersWindow();
            SetCenterPositionAndOpen(workersWindow);
        }

        #endregion

        #region Команды открытия окон Материалов/Работников/Users     
        private RelayCommand openWorkersWindowWnd;
        public RelayCommand OpenWorkersWindowWnd
        {
            get
            {
                return openWorkersWindowWnd ?? new RelayCommand(obj =>
                {
                    OpenWorkersMainWindowMethod();
                }
                    );
            }
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
        private RelayCommand openAddNewWorkersWnd;
        public RelayCommand OpenAddNewWorkersWnd
        {
            get
            {
                return openAddNewWorkersWnd ?? new RelayCommand(obj =>
                {
                    OpenAddWorkersWindowMethod();
                }
                    );
            }
        }
        private RelayCommand openEditWorkersWnd;
        public RelayCommand OpenEditWorkersWnd
        {
            get
            {
                return openEditWorkersWnd ?? new RelayCommand(obj =>
                {
                    OpenEditWorkersWindowMethod();
                }
                    );
            }
        }
        private RelayCommand openAddNewUsersWnd;
        public RelayCommand OpenAddNewUsersWnd
        {
            get
            {
                return openAddNewUsersWnd ?? new RelayCommand(obj =>
                {
                    OpenAddUsersWindowMethod();
                }
                    );
            }
        }
        private RelayCommand openReggUsersWnd;
        public RelayCommand OpenReggUsersWnd
        {
            get
            {
                return openReggUsersWnd ?? new RelayCommand(obj =>
                {
                    OpenAddUsersRegistrationWindowMethod();
                }
                    );
            }
        }
        private RelayCommand openUserMainWindowWnd;
        public RelayCommand OpenUserMainWindowWnd
        {
            get
            {
                return openUserMainWindowWnd ?? new RelayCommand(obj =>
                {
                    OpenUserMainWindowMethod();
                }
                    );
            }
        }

        #endregion

        #region Обновление Окон       
        private void UpdateAllMatetialsView()
        {
            //AllMaterials = DataWorker.GetAllMaterials();
            MaterialsWindow.AllMaterialsView.ItemsSource = null;
            MaterialsWindow.AllMaterialsView.Items.Clear();
            MaterialsWindow.AllMaterialsView.ItemsSource = AllMaterials;
            MaterialsWindow.AllMaterialsView.Items.Refresh();
        }
        private void UpdateAllWorkersView()
        {
            AllWorkers = DataWorker.GetAllWorkers();
            WorkersWindow.AllWorkersView.ItemsSource = null;
            WorkersWindow.AllWorkersView.Items.Clear();
            WorkersWindow.AllWorkersView.ItemsSource = AllWorkers;
            WorkersWindow.AllWorkersView.Items.Refresh();
        }

        #endregion
    }
}
