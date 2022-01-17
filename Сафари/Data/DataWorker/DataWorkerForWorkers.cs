//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Сафари.Data.MainData;
//using Сафари.Data.Models.WorkersModels;

//namespace Сафари.Data.DataWorker
//{
//    public class DataWorkerForWorkers
//    {
//        #region GetAllWorkers
//        public static List<Workers> GetAllWorkers()
//        {
//            //получаем всех работников
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                var result = db.Workers.ToList();
//                return result;
//            }
//        }
//        #endregion
//        #region Создаем Работникa
//        public static string CreateWorkers(string name, string surname, string patronymic, string phone, string notes)
//        {
//            string result = "Успешно!";
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                //смотрим существует ли сотрудник
//                bool checkIsExist = db.Workers.Any(el => el.Name == name && el.Surname == surname && el.Patronymic == patronymic && el.Phone == phone && el.Notes == notes);
//                if (!checkIsExist)
//                {
//                    Workers newworkers = new Workers
//                    {
//                        Name = name,
//                        Surname = surname,
//                        Patronymic = patronymic,
//                        Phone = phone,
//                        Notes = notes
//                    };
//                    db.Workers.Add(newworkers);
//                    db.SaveChanges();
//                }
//                return result;
//            }
//        }
//        #endregion
//        #region Удаляем Сотрудника    
//        public static string DeleteWorkers(Workers workers)
//        {
//            //удаляем сотрудника
//            string result = "Такого работника не существует";
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                db.Workers.Remove(workers);
//                db.SaveChanges();
//                result = "Співробітник " + workers.Name + " звільнений";
//            }
//            return result;
//        }
//        #endregion
//        #region Редактируем Сотрудника    
//        public static string EditWorkers(Workers oldworkers, string newname, string newsurname, string newpatronymic, string uniphone, string notes)
//        {
//            //редактируем сотрудника
//            string result = "Такого матеріалу не існує";
//            using (ApplicationContext db = new ApplicationContext())
//            {
//                Workers workers = db.Workers.FirstOrDefault(b => b.Id == oldworkers.Id);
//                workers.Name = newname;
//                workers.Surname = newsurname;
//                workers.Patronymic = newpatronymic;
//                workers.Phone = uniphone;
//                workers.Notes = notes;
//                db.SaveChanges();
//                result = "Співробітник" + workers.Name + "відредаговано";
//            }
//            return result;
//        }
//        #endregion
//    }
//}
