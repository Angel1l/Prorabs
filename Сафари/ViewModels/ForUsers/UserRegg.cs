using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Сафари.Commands;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;

namespace Сафари.ViewModels.ForUsers
{
    public class UserRegg : DataManageVM
    {
        public string login { get; set; } = "";
        public string password { get; set; } = "";
        public string repassword { get; set; } = "";
        public string email { get; set; } = "";



    }
}
