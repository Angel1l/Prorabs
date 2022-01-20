using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сафари.Data.Models.MaterialsModels;

namespace Сафари.Data
{
    public class ResMaterial
    {
        public Materials material { get; set; }
        public int Count { get; set; }
        public int FullPrice { get; set; }
        public ResMaterial()
        {

        }
    }
}
