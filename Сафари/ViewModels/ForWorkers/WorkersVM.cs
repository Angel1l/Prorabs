using System.Collections.Generic;
using System.Windows;
using Сафари.Commands;
using Сафари.Data.DataWorker.ForWorkers;
using Сафари.Data.Models.WorkersModels;
using Сафари.ViewModels.MainModels;
using Сафари.Views.ViewsForWorkers;

namespace Сафари.ViewModels.ForWorkers
{
    public class WorkersVM : SideProperties
    {
        public string WorkersName { get; set; }
        public string WorkersSurname { get; set; }
        public string WorkersPatronymic { get; set; }
        public string WorkersPhone { get; set; }
        public string WorkersNotes { get; set; }
        public static Workers SelectedWorkers { get; set; }
        public void UpdateAllWorkersView()
        {
            AllWorkers = DataWorkers.GetAllWorkers();
            WorkersWindow.AllWorkersView.ItemsSource = null;
            WorkersWindow.AllWorkersView.Items.Clear();
            WorkersWindow.AllWorkersView.ItemsSource = AllWorkers;
            WorkersWindow.AllWorkersView.Items.Refresh();
        }
        private List<Workers> allWorkers = DataWorkers.GetAllWorkers();
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
        public void SetNullValuesToWorkers()
        {                     
            WorkersName = null;
            WorkersSurname = null;
            WorkersPatronymic = null;
            WorkersPhone = null;
            WorkersNotes = null;
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
        private void OpenAddWorkersWindowMethod()
        {
            AddNewWorkersWindow newWorkersWindow = new AddNewWorkersWindow();
            SetCenterPositionAndOpen(newWorkersWindow);
        }
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
                        resultStr = DataWorkers.CreateWorkers(WorkersName, WorkersSurname, WorkersPatronymic, WorkersPhone, WorkersNotes);
                        ShowMessageToUser(resultStr);
                        UpdateAllWorkersView();
                        SetNullValuesToWorkers();
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
                        resultStr = DataWorkers.EditWorkers(SelectedWorkers, WorkersName, WorkersSurname, WorkersPatronymic, WorkersPhone, WorkersNotes);
                        UpdateAllWorkersView();
                        SetNullValuesToWorkers();
                        ShowMessageToUser(resultStr);
                        wnd.Close();
                    }
                    else ShowMessageToUser(resultStr);
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
        private void OpenEditWorkersWindowMethod()
        {
            EditWorkersWindow editWorkersWindow = new EditWorkersWindow();
            SetCenterPositionAndOpen(editWorkersWindow);
        }
        public RelayCommand deleteWorkers;
        public RelayCommand DeleteWorkers
        {
            get
            {
                return deleteWorkers ?? new RelayCommand(obj =>
                {
                    string resultStr = "Не вибраний співробітник";
                    if (SelectedTabItem.Name == "WorkersTab" && SelectedWorkers != null)
                    {
                        resultStr = DataWorkers.DeleteWorkers(SelectedWorkers);
                        UpdateAllWorkersView();
                    }
                }
                );
            }
        }
    }
}

