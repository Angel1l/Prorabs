using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сафари.Data.Models.MaterialsModels
{
    public class Materials
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Measure { get; set; }
        public int UnitPrice { get; set; }
        public int CategoryMaterialsId { get; set; }
        public Materials()
        {

        }
    }
    
}
