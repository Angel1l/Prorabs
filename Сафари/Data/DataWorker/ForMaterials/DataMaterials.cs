using System;
using System.Collections.Generic;
using System.Linq;
using Сафари.Commands;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.ForUsers;


namespace Сафари.Data.DataWorker.ForMaterials
{
    public class DataMaterials
    {
        public static List<Materials> GetAllMaterials()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Materials.ToList();
                return result;
            }
        }

        public static string CreateMaterials(string materialsName, string materialsMeasure, int materialsUnitPrice, int materialsCount, int materialsFullPrice)
        {
            string result = "Успешно!";
            using (ApplicationContext db = new ApplicationContext())
            {
                bool checkIsExist = db.Materials.Any(el => el.Name == materialsName && el.Measure == materialsMeasure && el.UnitPrice == materialsUnitPrice && el.Count == materialsCount && el.FullPrice == materialsFullPrice);
                if (!checkIsExist)
                {
                    Materials newmaterials = new Materials
                    {
                        Name = materialsName,
                        Measure = materialsMeasure,
                        UnitPrice = materialsUnitPrice,
                        Count = materialsCount,
                        FullPrice = materialsCount * materialsUnitPrice
                    };
                    db.Materials.Add(newmaterials);
                    db.SaveChanges();
                }
                return result;
            }
        }

        public static string EditMaterials(Materials oldmaterials, string newmaterialsName, string newmaterialsMeasure, int newmaterialsUnitPrice, int newmaterialsCount, int newmaterialsFullPrice)
        {
            string result = "Такого матеріалу не існує";
            using (ApplicationContext db = new ApplicationContext())
            {
                Materials materials = db.Materials.FirstOrDefault(b => b.Id == oldmaterials.Id);
                materials.Name = newmaterialsName;
                materials.Measure = newmaterialsMeasure;
                materials.UnitPrice = newmaterialsUnitPrice;
                materials.Count = newmaterialsCount;
                materials.FullPrice = newmaterialsCount * newmaterialsUnitPrice;
                db.SaveChanges();
                result = "Матеріал  " + materials.Name + "  відредагован";
            }
            return result;
        }

        public static string DeleteMaterials(Materials materials)
        {
            string result = "Такого работника не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Materials.Remove(materials);
                db.SaveChanges();
                result = "Матеріал " + materials.Name + " видалений";
            }
            return result;
        }
    }
}
