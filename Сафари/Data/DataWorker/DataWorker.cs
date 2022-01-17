using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Сафари.Data.MainData;
using Сафари.Data.Models.MaterialsModels;
using Сафари.Data.Models.WorkersModels;
using Сафари.ViewModels.ForUsers;
using Сафари.Views;

namespace Сафари.Data.DataWorker
{
    public class DataWorker
    {
        #region GetAllCategory
        public static List<CategoryMaterials> GetAllCategoryMaterials()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.CategoryMaterials.ToList();
            }
        }
        #endregion
        #region GetAllMaterials
        public static List<Materials> GetAllMaterials()
        {

            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Materials.ToList();
                return result;
            }
        }        
        #endregion
        #region Создаем Материал
        public static string CreateMaterials(string name, string measure, int unitPrice, CategoryMaterials categoryMaterials)
        {
            string result = "Успішно!";
            using (ApplicationContext db = new ApplicationContext())
            {
                bool checkIsExist = db.Materials.Any(el => el.Name == name && el.Measure == measure && el.UnitPrice == unitPrice && el.CategoryMaterialsId == categoryMaterials.Id);
                if (checkIsExist)
                {
                    Materials newmaterials = new Materials();
                    {
                        newmaterials.Name = name;
                        newmaterials.Measure = measure;
                        newmaterials.UnitPrice = unitPrice;
                        newmaterials.CategoryMaterialsId = categoryMaterials.Id;
                    };
                    db.Materials.Add(newmaterials);
                    db.SaveChanges();
                }
                return result;
            }
        }

        public static Users findUser(string usersLogin, string usersPassword)
        {
            using(ApplicationContext db = new ApplicationContext())
            {
               return db.Users.Where(u => u.Login == usersLogin && u.Pass == usersPassword).FirstOrDefault();
                
            }
        }

        public static void addUser(string login, string password, string email)
        {
            using(ApplicationContext db = new ApplicationContext())
            {

                Users user = new Users(login, email, password);
                db.Users.Add(user);

                db.SaveChanges();

                MessageBoxResult result = MessageBox.Show("Успішно!");

            }
            MainUserWindow mainUserWindow = new MainUserWindow();
            mainUserWindow.Show();
        }
        #endregion
        #region Удаляем Материал
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
        #endregion
        #region Редактируем Материал
        public static string EditMaterials(Materials oldmaterials, string newname, string newmeasure, int newunitPrice, CategoryMaterials newcategoryMaterials)
        {
            //редактируем матеріал
            string result = "Такого матеріалу не існує";
            using (ApplicationContext db = new ApplicationContext())
            {
                Materials materials = db.Materials.FirstOrDefault(b => b.Id == oldmaterials.Id);
                materials.Name = newname;
                materials.Measure = newmeasure;
                materials.UnitPrice = newunitPrice;
                materials.CategoryMaterialsId = newcategoryMaterials.Id;
                db.SaveChanges();
                result = "Матеріал" + materials.Name + "відредаговано";
            }
            return result;
        }
        #endregion
        #region +Юзер
        //public static string CreateUsers(string login, string pass, string email)
        //{
        //    string result = "Успішно!";
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        bool checkIsExist = db.Users.Any(el => el.Login == login && el.Pass == pass && el.Email == email);
        //        if (checkIsExist)
        //        {
        //            Users newusers = new Users();
        //            {
        //                newusers.Login = login;
        //                newusers.Pass = pass;
        //                newusers.Email = email;
        //            };
        //            db.Users.Add(newusers);
        //            db.SaveChanges();

        //        }
        //        return result;
        //    }
        //}
        #endregion
        #region GetAllUsers
        public List<Users> GetAllUsers()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Users.ToList();
            }
        }
        #endregion
        #region Материал для юзера
        public List<BuyMaterials> GetMaterialsForUser()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var mat = new List<BuyMaterials>();
                var dataMaterial = db.UsersWithMaterials.ToList();
                var user = GetAllUsers().Where(u => u.Login == UsersViewModels.UsersLogin).FirstOrDefault();
                var material = db.Materials.ToList();
                foreach (var item in dataMaterial)
                {
                    if (item.UserId == user.Id)
                    {
                        var resMaterial = material.Where(m => m.Id == item.MaterialId).FirstOrDefault();
                        mat.Add(new BuyMaterials()
                        {
                            Materials = resMaterial,
                            Count = item.Count,
                            FullPrice = item.Count * resMaterial.UnitPrice

                        });
                       
                    }
                }
                
                return mat;
            }
        }
        #endregion
        #region Работники для юзера
        public List<ConnectWorkersToSalary> GetJobbersForUser()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var work = new List<ConnectWorkersToSalary>();
                var dataPeople = db.UserWithWorkers.ToList();
                var user = GetAllUsers().Where(u => u.Login == UsersViewModels.UsersLogin).FirstOrDefault();
                var Workers = db.Workers.ToList();
                foreach (var item in dataPeople)
                {
                    if (item.UserId == user.Id)
                    {
                        var resPerson = Workers.Where(m => m.Id == item.WorkersId).FirstOrDefault();
                        work.Add(new ConnectWorkersToSalary()
                        {
                            WorkersSal = resPerson,
                            Salary = item.Salary
                        });
                    }
                }

                return work;
            }
        }
        #endregion
        #region GetAllWorkers
        public static List<Workers> GetAllWorkers()
        {
            //получаем всех работников
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Workers.ToList();
                return result;
            }
        }
        #endregion
        #region Создаем Работникa
        public static string CreateWorkers(string name, string surname, string patronymic, string phone, string notes)
        {
            string result = "Успешно!";
            using (ApplicationContext db = new ApplicationContext())
            {
                //смотрим существует ли сотрудник
                bool checkIsExist = db.Workers.Any(el => el.Name == name && el.Surname == surname && el.Patronymic == patronymic && el.Phone == phone && el.Notes == notes);
                if (!checkIsExist)
                {
                    Workers newworkers = new Workers
                    {
                        Name = name,
                        Surname = surname,
                        Patronymic = patronymic,
                        Phone = phone,
                        Notes = notes
                    };
                    db.Workers.Add(newworkers);
                    db.SaveChanges();
                }
                return result;
            }
        }
        #endregion
        #region Удаляем Сотрудника    
        public static string DeleteWorkers(Workers workers)
        {
            //удаляем сотрудника
            string result = "Такого работника не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Workers.Remove(workers);
                db.SaveChanges();
                result = "Співробітник " + workers.Name + " звільнений";
            }
            return result;
        }
        #endregion
        #region Редактируем Сотрудника    
        public static string EditWorkers(Workers oldworkers, string newname, string newsurname, string newpatronymic, string uniphone, string notes)
        {
            //редактируем сотрудника
            string result = "Такого матеріалу не існує";
            using (ApplicationContext db = new ApplicationContext())
            {
                Workers workers = db.Workers.FirstOrDefault(b => b.Id == oldworkers.Id);
                workers.Name = newname;
                workers.Surname = newsurname;
                workers.Patronymic = newpatronymic;
                workers.Phone = uniphone;
                workers.Notes = notes;
                db.SaveChanges();
                result = "Співробітник  " + workers.Name + "  відредагован";
            }
            return result;
        }
        #endregion
    }
}
