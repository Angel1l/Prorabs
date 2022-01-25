using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сафари.Commands;
using Сафари.Data;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.ForMaterials;
using Сафари.ViewModels.MainModels;
using Сафари.Views.ViewForMaterials;

namespace Сафари.ViewModels.ForUsersWithMaterials
{
    public class UsersWithMaterialsVM : MaterialsVM
    {
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
    }
}
