using Сафари.Commands;
using Сафари.ViewModels.MainModels;
using Сафари.Views.ViewForMaterials;
using Сафари.Views.ViewForUsers;
using Сафари.Views.ViewsForWorkers;

namespace Сафари.ViewModels.ForWindows
{
    public class WindowsVM : SideProperties
    {
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
        //private RelayCommand openEditMaterialsWnd;
        //public RelayCommand OpenEditMaterialsWnd
        //{
        //    get
        //    {
        //        return openEditMaterialsWnd ?? new RelayCommand(obj =>
        //        {
        //            OpenEditMaterialsWindowMethod();
        //        }
        //            );
        //    }
        //}
        //private RelayCommand openAddNewWorkersWnd;
        //public RelayCommand OpenAddNewWorkersWnd
        //{
        //    get
        //    {
        //        return openAddNewWorkersWnd ?? new RelayCommand(obj =>
        //        {
        //            OpenAddWorkersWindowMethod();
        //        }
        //            );
        //    }
        //}
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
        private void OpenAddMaterialsWindowMethod()
        {
            AddNewMaterialsWindow newMaterialsWindow = new AddNewMaterialsWindow();
            SetCenterPositionAndOpen(newMaterialsWindow);
        }
        //private void OpenEditMaterialsWindowMethod()
        //{
        //    EditMaterialsWindow editMaterialsWindow = new EditMaterialsWindow();
        //    SetCenterPositionAndOpen(editMaterialsWindow);
        //}
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
    }
}
