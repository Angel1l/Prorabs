using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Сафари.Commands;
using Сафари.Data.DataWorker.ForCount;
using Сафари.Data.DataWorker.ForMaterials;
using Сафари.Data.MainData;
using Сафари.Data.Models.CountModels;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.ForMaterials;
using Сафари.ViewModels.MainModels;
using Сафари.Views.ViewForMaterials;

namespace Сафари.ViewModels.ForCount
{
    public class CountVM : SideProperties
    {
        public int MaterialsCount { get; set; }
        public int MaterialsFullPrice { get; set; }
        public static Materials SelectedCount { get; set; }

        private RelayCommand addNewCount;
        public RelayCommand AddNewCount
        {
            get
            {
                return addNewCount ?? new RelayCommand(obj =>
                {
                    Window wnd = obj as Window;
                    string resultStr = "";
                    
                        resultStr = DataCount.CreateCount(MaterialsCount, MaterialsFullPrice);
                        ShowMessageToUser(resultStr);                        
                        wnd.Close();
                    
                }
                );
            }
        }

        private RelayCommand openCountWnd;
        public RelayCommand OpenCountWnd
        {
            get
            {
                return openCountWnd ?? new RelayCommand(obj =>
                {
                    OpenAddCountMethod();
                }
                    );
            }
        }
        private void OpenAddCountMethod()
        {
            CountWindow newCountWindow = new CountWindow();
            SetCenterPositionAndOpen(newCountWindow);
        }
        
    }
}
