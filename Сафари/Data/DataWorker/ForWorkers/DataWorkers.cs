using System.Collections.Generic;
using System.Linq;
using Сафари.Data.MainData;
using Сафари.Data.Models.WorkersModels;

namespace Сафари.Data.DataWorker.ForWorkers
{
    public class DataWorkers
    {
        public static List<Workers> GetAllWorkers()
        {           
            using (ApplicationContext db = new ApplicationContext())
            {
                var result = db.Workers.ToList();
                return result;
            }
        }
        public static string CreateWorkers(string name, string surname, string patronymic, string phone, string notes)
        {
            string result = "Успешно!";
            using (ApplicationContext db = new ApplicationContext())
            {                
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
        public static string DeleteWorkers(Workers workers)
        {            
            string result = "Такого работника не существует";
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Workers.Remove(workers);
                db.SaveChanges();
                result = "Співробітник " + workers.Name + " звільнений";
            }
            return result;
        }
        public static string EditWorkers(Workers oldworkers, string newname, string newsurname, string newpatronymic, string newuniphone, string newnotes)
        {
            //редактируем сотрудника
            string result = "Такого матеріалу не існує";
            using (ApplicationContext db = new ApplicationContext())
            {
                Workers workers = db.Workers.FirstOrDefault(b => b.Id == oldworkers.Id);
                workers.Name = newname;
                workers.Surname = newsurname;
                workers.Patronymic = newpatronymic;
                workers.Phone = newuniphone;
                workers.Notes = newnotes;
                db.SaveChanges();
                result = "Співробітник  " + workers.Name + "  відредагован";
            }
            return result;
        }
    }
}
