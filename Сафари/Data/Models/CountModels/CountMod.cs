using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.ForCount;

namespace Сафари.Data.Models.CountModels
{
    public class CountMod : CountVM
    {
        public Materials Materials { get; set; }
        public int Count { get; set; }
        public int FullPrice { get; set; }
        public CountMod()
        {

        }
    }
    public class CountOfBuyingByUsersMaterials : CountVM
    {
        public static string count { get; set; }

        public CountOfBuyingByUsersMaterials()
        {
            count = "";
        }
    }
}
