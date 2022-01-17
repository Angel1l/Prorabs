using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Сафари.Commands;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.Views.ViewForUsers;

namespace Сафари.ViewModels.ForUsers
{
    public class UsersViewModels : DataManageVM
    {
        public static Materials SelectedMaterial { get; set; }
        public static string UsersLogin { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

       
    }
    
}
