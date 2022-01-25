using System;
using System.Collections.Generic;
using System.Linq;
using Сафари.Commands;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.ViewModels.ForUsersWithMaterials;

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

        public static string CreateMaterials(string name, string measure, int unitPrice)
        {
            string result = "Успішно!";
            using (ApplicationContext db = new ApplicationContext())
            {
                bool checkIsExist = db.Materials.Any(el => el.Name == name && el.Measure == measure && el.UnitPrice == unitPrice);
                if (checkIsExist)
                {
                    Materials newmaterials = new Materials();
                    {
                        newmaterials.Name = name;
                        newmaterials.Measure = measure;
                        newmaterials.UnitPrice = unitPrice;                      
                    };
                    db.Materials.Add(newmaterials);
                    db.SaveChanges();
                }
                return result;
            }
        }
        public static List<ResMaterial> GetMaterialForTheUserMaterials()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var mat = new List<ResMaterial>();
                try
                {
                    var dataMaterial = db.UsersWithMaterials.ToList();
                    var user = db.Users.Where(u => u.Login == UsersWithMaterialsVM.UsersLogin).FirstOrDefault();
                    var material = db.Materials.ToList();
                    foreach (var item in dataMaterial)
                    {
                        if (user != null && item.UserId == user.Id)
                        {
                            var resMaterial = material.Where(m => m.Id == item.MaterialId).FirstOrDefault();
                            mat.Add(new ResMaterial()
                            {
                                material = resMaterial,
                                Count = item.Count,
                                FullPrice = item.Count * resMaterial.UnitPrice
                            });
                        }
                    }
                }
                catch (NullReferenceException)
                {


                }

                return mat;
            }
        }
        public static string DeleteMaterials(Materials materials)
        {

            string result = "Такого материала не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Materials.Remove(materials);
                db.SaveChanges();
                result = "Матеріал" + materials.Name + "видалений";
            }
            return result;
        }

        public static string EditMaterials(Materials oldmaterials, string newname, string newmeasure, int newunitPrice)
        {           
            string result = "Такого матеріалу не існує";
            using (ApplicationContext db = new ApplicationContext())
            {
                Materials materials = db.Materials.FirstOrDefault(b => b.Id == oldmaterials.Id);
                materials.Name = newname;
                materials.Measure = newmeasure;
                materials.UnitPrice = newunitPrice;                
                db.SaveChanges();
                result = "Матеріал" + materials.Name + "відредаговано";
            }
            return result;
        }
       
        }
}
