using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сафари.ViewModels;

namespace Сафари.Data.Models.MaterialsModels
{
    public class CountOfBuyingByUsersMaterials : DataManageVM
    {
        public static string count { get; set; }

        public CountOfBuyingByUsersMaterials()
        {
            count = "";
        }
    }
}
