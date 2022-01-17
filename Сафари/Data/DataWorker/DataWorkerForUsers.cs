//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Сафари.Data.MainData;
//using Сафари.Data.Models.MaterialsModels;
//using Сафари.Data.Models.UsersModels;
//using Сафари.Data.Models.WorkersModels;
//using Сафари.ViewModels.ForUsers;
 

//namespace Сафари.Data.DataWorker
//{
//    public class DataWorkerForUsers
//    {
//        #region +Юзер
//        public static string CreateUsers(string login, string pass)
//        {
//            string result = "Успішно!";
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                bool checkIsExist = db.Users.Any(el => el.Login == login && el.Pass == pass);
//                if (checkIsExist)
//                {
//                    Users newusers = new Users();
//                    {
//                        newusers.Login = login;
//                        newusers.Pass = pass;
                        
//                    };
//                    db.Users.Add(newusers);
//                    db.SaveChanges();
//                }
//                return result;
//            }
//        }
//        #endregion
//        #region GetAllUsers
//        public List<Users> GetAllUsers()
//        {
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                return db.Users.ToList();
//            }
//        }
//        #endregion
//        #region Материал для юзера
//        public List<BuyMaterials> GetMaterialsForUser()
//        {
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                var mat = new List<BuyMaterials>();
//                var dataMaterial = db.UsersWithMaterials.ToList();
//                var user = GetAllUsers().Where(u => u.Login == UsersViewModels.UsersLogin).FirstOrDefault();
//                var material = db.Materials.ToList();
//                foreach (var item in dataMaterial)
//                {
//                    if (item.UserId == user.Id)
//                    {
//                        var resMaterial = material.Where(m => m.Id == item.MaterialId).FirstOrDefault();
//                        mat.Add(new BuyMaterials()
//                        {
//                            Materials = resMaterial,
//                            Count = item.Count,
//                            FullPrice = item.Count * resMaterial.UnitPrice
//                        });
//                    }
//                }

//                return mat;
//            }
//        }
//        #endregion
//        #region Работники для юзера
//        public List<ConnectWorkersToSalary> GetJobbersForUser()
//        {
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                var work = new List<ConnectWorkersToSalary>();
//                var dataPeople = db.UserWithWorkers.ToList();
//                var user = GetAllUsers().Where(u => u.Login == UsersViewModels.UsersLogin).FirstOrDefault();
//                var Workers = db.Workers.ToList();
//                foreach (var item in dataPeople)
//                {
//                    if (item.UserId == user.Id)
//                    {
//                        var resPerson = Workers.Where(m => m.Id == item.WorkersId).FirstOrDefault();
//                        work.Add(new ConnectWorkersToSalary()
//                        {
//                            WorkersSal = resPerson,
//                            Salary = item.Salary
//                        });
//                    }
//                }

//                return work;
//            }
//        }
//        #endregion
//    }
//}
