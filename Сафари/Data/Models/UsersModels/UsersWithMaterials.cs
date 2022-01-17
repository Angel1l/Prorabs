using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сафари.Data.Models.MaterialsModels
{
    public class UsersWithMaterials
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MaterialId { get; set; }
        public int Count { get; set; }
        public DateTime DatePurchase { get; set; }

        public UsersWithMaterials()
        {

        }

        public UsersWithMaterials(int userid, int materialid, int count)
        {
            UserId = userid;
            MaterialId = materialid;
            Count = count;
            DatePurchase = DateTime.Now;
        }
    }
}
