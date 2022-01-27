using System;
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
        public UsersWithMaterials( int count)
        {            
            Count = count;
            DatePurchase = DateTime.Now;
        }
    }
}
