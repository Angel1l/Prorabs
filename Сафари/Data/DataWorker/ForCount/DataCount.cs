using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Сафари.Commands;
using Сафари.Data.MainData;
using Сафари.Data.Models.CountModels;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.ForMaterials;
using Сафари.Views.ViewForMaterials;

namespace Сафари.Data.DataWorker.ForCount
{
    public class DataCount
    {
        
        public static string CreateCount(int materialsCount, int materialsFullPrice)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                string result = "Успішно!";
                bool checkIsExist = db.Materials.Any((el => el.Count == materialsCount && el.FullPrice == materialsFullPrice));
                if (!checkIsExist)
                {


                    var mat = new List<CountMod>();
                    var dataMaterial = db.UsersWithMaterials.ToList();
                    var material = db.Materials.ToList();

                    foreach (var item in dataMaterial)
                    {
                        var resMaterial = material.Where(m => m.Id == item.MaterialId).FirstOrDefault();
                        mat.Add(new CountMod()
                        {
                            Materials = resMaterial,
                            Count = item.Count,
                            FullPrice = item.Count * resMaterial.UnitPrice

                        });
                    }                  
                }
                return result;
            }           
        }
    }
}
