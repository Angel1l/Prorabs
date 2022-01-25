using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Сафари.Views.ViewForUsers;

namespace Сафари.ViewModels.MainModels
{
    public class SideProperties : INotifyPropertyChanged
    {
        public static TabItem SelectedTabItem { get; set; }
        public void SetRedBlockControll(Window wnd, string blockname)
        {
            Control block = wnd.FindName(blockname) as Control;
            block.BorderBrush = Brushes.Red;
        }

        public void ShowMessageToUser(string message)
        {
            ShowMessageToUser messageView = new ShowMessageToUser(message);
            SetCenterPositionAndOpen(messageView);
        }

        public void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
