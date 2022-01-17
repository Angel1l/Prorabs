//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Сафари.Data.MainData;
//using Сафари.Data.Models.MaterialsModels;

//namespace Сафари.Data.DataWorker
//{
//    public class DataWorkerForMaterials
//    {
//        #region GetAllMaterials
//        public static List<Materials> GetAllMaterials()
//        {

//            using (ApplicationContext db = new ApplicationContext())
//            {
//                var result = db.Materials.ToList();
//                return result;
//            }
//        }
//        #endregion
//        #region Создаем Материал
//        public static string CreateMaterials(string name, string measure, int unitPrice, CategoryMaterials categoryMaterials)
//        {
//            string result = "Успішно!";
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                bool checkIsExist = db.Materials.Any(el => el.Name == name && el.Measure == measure && el.UnitPrice == unitPrice && el.CategoryMaterialsId == categoryMaterials.Id);
//                if (checkIsExist)
//                {
//                    Materials newmaterials = new Materials();
//                    {
//                        newmaterials.Name = name;
//                        newmaterials.Measure = measure;
//                        newmaterials.UnitPrice = unitPrice;
//                        newmaterials.CategoryMaterialsId = categoryMaterials.Id;
//                    };
//                    db.Materials.Add(newmaterials);
//                    db.SaveChanges();
//                }
//                return result;
//            }
//        }
//        #endregion
//        #region Удаляем Материал
//        public static string DeleteMaterials(Materials materials)
//        {

//            string result = "Такого материала не существует";
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                db.Materials.Remove(materials);
//                db.SaveChanges();
//                result = "Матеріал" + materials.Name + "видалений";
//            }
//            return result;
//        }
//        #endregion
//        #region Редактируем Материал
//        public static string EditMaterials(Materials oldmaterials, string newname, string newmeasure, int newunitPrice, CategoryMaterials newcategoryMaterials)
//        {
//            //редактируем матеріал
//            string result = "Такого матеріалу не існує";
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                Materials materials = db.Materials.FirstOrDefault(b => b.Id == oldmaterials.Id);
//                materials.Name = newname;
//                materials.Measure = newmeasure;
//                materials.UnitPrice = newunitPrice;
//                materials.CategoryMaterialsId = newcategoryMaterials.Id;
//                db.SaveChanges();
//                result = "Матеріал" + materials.Name + "відредаговано";
//            }
//            return result;
//        }
//        #endregion
//    }
//}
