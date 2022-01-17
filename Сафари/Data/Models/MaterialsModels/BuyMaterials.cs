using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сафари.Data.Models.MaterialsModels
{
    public class BuyMaterials
    {
        public Materials Materials { get; set; }
        public int Count { get; set; }
        public int FullPrice { get; set; }
        public BuyMaterials()
        {

        }
    }
}
